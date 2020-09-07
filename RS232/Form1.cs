using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS232
{
    public partial class Form1 : Form
    {
        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        string pingTest = "pingT";
        string pingRequest = "pingR";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());

            /*//generowanie listy prędkości (jeśli nie zrobiono ręcznie)
            int speedMin = 150;
            int speedMax = 115000;
            int dataNumber = 30;
            int jump = (speedMax - speedMin) / dataNumber;
            for (int i = 0; i < dataNumber; i++)
            {
                comboBoxSpeed.Items.Add(i * jump + speedMin);
            }*/


            //sortowanie wyswietlanych nazw dostępnych portów
            comboBoxPort.Sorted = true;     //true - sortuj, false - nie sortuj
            //comboBoxSpeed.Sorted = true;  //coś nie działa

            if (comboBoxPort.Items.Count > 0)
                comboBoxPort.SelectedIndex = 0;
            if (comboBoxSpeed.Items.Count > 0)
                comboBoxSpeed.SelectedIndex = 0;
            comboBoxParityBits.SelectedIndex = 0;
            comboBoxDataBits.SelectedIndex = 0;
            comboBoxStopBits.SelectedIndex = 0;

            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBoxPort.Enabled = true;   //lista z portami
            comboBoxSpeed.Enabled = true;   //lista z prędkością
            comboBoxParityBits.Enabled = true;   //lista z kontrolą znaku
            comboBoxDataBits.Enabled = true;   //lista z bitami pola danych
            comboBoxStopBits.Enabled = true;   //lista z bitami stopu
            buttonConnect.Enabled = true;   //przycisk połącz
            buttonDisconnect.Enabled = false;   //przycisk rozłącz
            buttonSend.Enabled = false;     //przycisk wyślij
            buttonClearReceiveTxt.Enabled = false;  //przycisk odbierz

            //inicjalizacja kontroli sprzętowej
            checkBoxDTR.Checked = false;
            serialPort.DtrEnable = false;
            checkBoxRTS.Checked = false;
            serialPort.RtsEnable = false;

            //blokowanie wpisywania danych do okna
            txtReceive.ReadOnly = true;

            checkBoxHandshake.Checked = false;
            serialPort.Handshake = Handshake.None;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //zmiana stanu przycisków po kliknięciu
            buttonConnect.Enabled = false;      //przycisk połącz
            buttonDisconnect.Enabled = true;   //przycisk rozłącz
            buttonSend.Enabled = true;         //przycisk wyślij 
            buttonClearReceiveTxt.Enabled = true;       //przycisk odbierz
            try
            {
                serialPort.BaudRate = Convert.ToInt32(comboBoxSpeed.Text);  //konwersja i ustawienie prędkości transmisji
                serialPort.PortName = comboBoxPort.Text;
                serialPort.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);
                serialPort.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    //wysłanie bufora na łącze
                    //serialPort.Write(txtMessage.Text.ToString());

                    //dopisanie terminatora do bufora
                    if(checkBoxCR.Checked == checkBoxLF.Checked == false)
                    {
                        if (textBoxTerminatorManualy.Text.Length == 0 || textBoxTerminatorManualy.Text.Length > 2)
                        {
                            if (checkBoxCR.Checked)     //czy ma wysyłać polecenie powrotu karetki
                            {
                                //wysłanie polecenia powrotu
                                serialPort.Write(txtMessage.Text.ToString() + "\r");
                            }
                            if (checkBoxLF.Checked)     //czy ma wysyłać polecenie nowej lini
                            {
                                //wysłanie polecenia nowej lini
                                serialPort.Write(txtMessage.Text.ToString() + "\n");
                            }
                        }
                        else
                        {
                            serialPort.Write(txtMessage.Text.ToString() + textBoxTerminatorManualy.Text.ToString());
                        }
                    }
                    else
                    {
                        serialPort.Write(txtMessage.Text.ToString() + textBoxTerminatorManualy.Text.ToString());
                    }



                    txtMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            //zmiana stanu przycisków po kliknięciu
            buttonConnect.Enabled = true;       //przycisk połącz
            buttonDisconnect.Enabled = false;   //przycisk rozłącz
            buttonSend.Enabled = false;         //przycisk wyślij 
            buttonClearReceiveTxt.Enabled = false;      //przycisk odbierz
            try
            {
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
            /*try
            {
                if (serialPort.IsOpen)
                {  
                    txtReceive.Text += serialPort.ReadExisting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();

            //sprawdzanie czy wykonujemy test połączenia
            if (data == pingTest)
            {
                try
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Write(pingRequest);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            //wyświetlamy wynik testu
            if(data == pingRequest)
            {
                this.stopwatch.Stop();
                data = "Opuźnienie w obie strony: " + this.stopwatch.Elapsed.TotalMilliseconds + " ms\n";
                this.stopwatch.Reset();
            }

            //sprawdzenie czy komponent gdzie wypisywane są odebrane dane jest w tym samym wątku co odbiór danych
            if (txtReceive.InvokeRequired)
            {
                //utworzenie delegata (wskaźnika do mikro funkcji) metody do wpisywania danych w komponencie z bufora odbioru danych
                Action act = () => txtReceive.Text += data;

                //wykonanie delegata dla wątku głównego
                Invoke(act);   //wywołanie delegata
            }
            else
            {
                //jeżeli jest w tym samym wątku przepisz normalnie dane z bufora do komponentu
                txtReceive.Text += data;
            }
                
        }

        private void comboBoxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRTS.Checked)
            {
                serialPort.RtsEnable = true;
            }
            else
            {
                serialPort.RtsEnable = false;
            }
        }

        private void checkBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDTR.Checked)
            {
                serialPort.DtrEnable = true;
            }
            else
            {
                serialPort.DtrEnable = false;
            }
        }

        private void buttonFlowControl_Click(object sender, EventArgs e)
        {
            checkBoxDTR.Checked = false;
            checkBoxRTS.Checked = false;
        }

        string dataIN;
        private void txtReceive_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowData(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHandshake.Checked)
            {
                serialPort.Handshake = Handshake.XOnXOff;
            }
            else
            {
                serialPort.Handshake = Handshake.None;
            }
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    this.stopwatch.Start();
                    serialPort.Write(pingTest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxParityBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
