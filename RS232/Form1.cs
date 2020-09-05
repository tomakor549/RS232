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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int speedMin = 20;
            int speedMax = 115000;
            int dataNumber = 30;
            Double number;
           
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());

            int jump = (speedMax - speedMin) / dataNumber;
            for (double i = 0; i < dataNumber; i++)
            {
                comboBoxSpeed.Items.Add(Convert.ToString(i * jump + speedMin + " b/s"));
            }

            //sortowanie wyswietlanych nazw dostępnych portów
            comboBoxPort.Sorted = true;     //true - sortuj, false - nie sortuj

            if (comboBoxPort.Items.Count > 0)
                comboBoxPort.SelectedIndex = 0;
            if (comboBoxSpeed.Items.Count > 0)
                comboBoxSpeed.SelectedIndex = 0;

            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBoxPort.Enabled = true;   //lista z portami
            comboBoxSpeed.Enabled = true;   //lista z prędkością
            buttonConnect.Enabled = true;   //przycisk połącz
            buttonDisconnect.Enabled = false;   //przycisk rozłącz
            buttonSend.Enabled = false;
            buttonReceive.Enabled = false;
              
            


        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //zmiana stanu przycisków po kliknięciu
            buttonConnect.Enabled = false;   //przycisk połącz
            buttonDisconnect.Enabled = true;   //przycisk rozłącz
            buttonSend.Enabled = true;
            buttonReceive.Enabled = true;
            try
            {
                serialPort.PortName = comboBoxPort.Text;
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
                    serialPort.WriteLine(txtMessage.Text + Environment.NewLine);
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
            buttonConnect.Enabled = true;   //przycisk połącz
            buttonDisconnect.Enabled = false;   //przycisk rozłącz
            buttonSend.Enabled = false;
            buttonReceive.Enabled = false;
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
            try
            {
                if (serialPort.IsOpen)
                {
                    txtReceive.Text = serialPort.ReadExisting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }
    }
}
