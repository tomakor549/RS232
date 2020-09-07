namespace RS232
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClearReceiveTxt = new System.Windows.Forms.Button();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.checkBoxLF = new System.Windows.Forms.CheckBox();
            this.textBoxTerminatorManualy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFlowControl = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxHandshake = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szybkość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nadawanie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Odbiór";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(502, 228);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(103, 110);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(611, 228);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(95, 110);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Rozłącz";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(300, 57);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(78, 21);
            this.comboBoxPort.TabIndex = 8;
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "76800",
            "115000"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(387, 57);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(88, 21);
            this.comboBoxSpeed.TabIndex = 9;
            this.comboBoxSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeed_SelectedIndexChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 389);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(611, 32);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.Text = "";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(12, 41);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(266, 259);
            this.txtReceive.TabIndex = 11;
            this.txtReceive.Text = "";
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(632, 389);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 32);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClearReceiveTxt
            // 
            this.buttonClearReceiveTxt.Location = new System.Drawing.Point(12, 306);
            this.buttonClearReceiveTxt.Name = "buttonClearReceiveTxt";
            this.buttonClearReceiveTxt.Size = new System.Drawing.Size(121, 32);
            this.buttonClearReceiveTxt.TabIndex = 13;
            this.buttonClearReceiveTxt.Text = "Wyczyść";
            this.buttonClearReceiveTxt.UseVisualStyleBackColor = true;
            this.buttonClearReceiveTxt.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(101, 32);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(87, 21);
            this.comboBoxDataBits.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bity pola danych";
            // 
            // comboBoxParityBits
            // 
            this.comboBoxParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParityBits.FormattingEnabled = true;
            this.comboBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParityBits.Location = new System.Drawing.Point(13, 32);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(82, 21);
            this.comboBoxParityBits.TabIndex = 16;
            this.comboBoxParityBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxParityBits_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kontrola";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(13, 81);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(82, 21);
            this.comboBoxStopBits.TabIndex = 20;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopBits_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bity stopu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Location = new System.Drawing.Point(6, 24);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(41, 17);
            this.checkBoxCR.TabIndex = 22;
            this.checkBoxCR.Text = "CR";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            // 
            // checkBoxLF
            // 
            this.checkBoxLF.AutoSize = true;
            this.checkBoxLF.Location = new System.Drawing.Point(68, 24);
            this.checkBoxLF.Name = "checkBoxLF";
            this.checkBoxLF.Size = new System.Drawing.Size(38, 17);
            this.checkBoxLF.TabIndex = 23;
            this.checkBoxLF.Text = "LF";
            this.checkBoxLF.UseVisualStyleBackColor = true;
            // 
            // textBoxTerminatorManualy
            // 
            this.textBoxTerminatorManualy.Location = new System.Drawing.Point(6, 78);
            this.textBoxTerminatorManualy.Name = "textBoxTerminatorManualy";
            this.textBoxTerminatorManualy.Size = new System.Drawing.Size(100, 20);
            this.textBoxTerminatorManualy.TabIndex = 24;
            this.textBoxTerminatorManualy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Terminator ręczny (1 lub 2 znaki)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxParityBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.comboBoxStopBits);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(287, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 125);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format Znaku";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxCR);
            this.groupBox2.Controls.Add(this.checkBoxLF);
            this.groupBox2.Controls.Add(this.textBoxTerminatorManualy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(289, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 110);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonFlowControl);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(502, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 125);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrola Przepływu";
            // 
            // buttonFlowControl
            // 
            this.buttonFlowControl.Location = new System.Drawing.Point(109, 80);
            this.buttonFlowControl.Name = "buttonFlowControl";
            this.buttonFlowControl.Size = new System.Drawing.Size(85, 39);
            this.buttonFlowControl.TabIndex = 4;
            this.buttonFlowControl.Text = "Brak kontroli przepływu";
            this.buttonFlowControl.UseVisualStyleBackColor = true;
            this.buttonFlowControl.Click += new System.EventHandler(this.buttonFlowControl_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxHandshake);
            this.groupBox5.Location = new System.Drawing.Point(109, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(85, 50);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Programowa";
            // 
            // checkBoxHandshake
            // 
            this.checkBoxHandshake.AutoSize = true;
            this.checkBoxHandshake.Location = new System.Drawing.Point(4, 27);
            this.checkBoxHandshake.Name = "checkBoxHandshake";
            this.checkBoxHandshake.Size = new System.Drawing.Size(81, 17);
            this.checkBoxHandshake.TabIndex = 0;
            this.checkBoxHandshake.Text = "XON/XOFF";
            this.checkBoxHandshake.UseVisualStyleBackColor = true;
            this.checkBoxHandshake.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxDTR);
            this.groupBox4.Controls.Add(this.checkBoxRTS);
            this.groupBox4.Location = new System.Drawing.Point(6, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(82, 95);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sprzętowa";
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Location = new System.Drawing.Point(6, 63);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDTR.TabIndex = 1;
            this.checkBoxDTR.Text = "Użyj DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBoxDTR_CheckedChanged);
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Location = new System.Drawing.Point(6, 33);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(71, 17);
            this.checkBoxRTS.TabIndex = 0;
            this.checkBoxRTS.Text = "Użyj RTS";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            this.checkBoxRTS.CheckedChanged += new System.EventHandler(this.checkBoxRTS_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "b/s";
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(156, 307);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(122, 31);
            this.buttonPing.TabIndex = 30;
            this.buttonPing.Text = "PING";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 449);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearReceiveTxt);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClearReceiveTxt;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxParityBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxLF;
        private System.Windows.Forms.CheckBox checkBoxCR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTerminatorManualy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.Button buttonFlowControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxHandshake;
        private System.Windows.Forms.Button buttonPing;
    }
}

