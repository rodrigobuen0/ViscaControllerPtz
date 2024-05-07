namespace ViscaControllerPtz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDownLeft = new System.Windows.Forms.Button();
            this.btnDownRight = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnZoomMenos = new System.Windows.Forms.Button();
            this.btnZoomMais = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(157, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Serial Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDownLeft);
            this.groupBox2.Controls.Add(this.btnDownRight);
            this.groupBox2.Controls.Add(this.btnTopLeft);
            this.groupBox2.Controls.Add(this.btnTopRight);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.btnZoomMenos);
            this.groupBox2.Controls.Add(this.btnZoomMais);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Location = new System.Drawing.Point(10, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 244);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // btnDownLeft
            // 
            this.btnDownLeft.Location = new System.Drawing.Point(20, 182);
            this.btnDownLeft.Name = "btnDownLeft";
            this.btnDownLeft.Size = new System.Drawing.Size(49, 40);
            this.btnDownLeft.TabIndex = 14;
            this.btnDownLeft.Text = "←↓";
            this.btnDownLeft.UseVisualStyleBackColor = true;
            this.btnDownLeft.Click += new System.EventHandler(this.btnDownLeft_Click);
            // 
            // btnDownRight
            // 
            this.btnDownRight.Location = new System.Drawing.Point(116, 182);
            this.btnDownRight.Name = "btnDownRight";
            this.btnDownRight.Size = new System.Drawing.Size(49, 40);
            this.btnDownRight.TabIndex = 13;
            this.btnDownRight.Text = "↓→";
            this.btnDownRight.UseVisualStyleBackColor = true;
            this.btnDownRight.Click += new System.EventHandler(this.btnDownRight_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.Location = new System.Drawing.Point(18, 102);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(49, 40);
            this.btnTopLeft.TabIndex = 12;
            this.btnTopLeft.Text = "←↑";
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.Location = new System.Drawing.Point(116, 102);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(49, 40);
            this.btnTopRight.TabIndex = 11;
            this.btnTopRight.Text = "↑→";
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(67, 142);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(49, 40);
            this.button23.TabIndex = 10;
            this.button23.Text = "Home";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(54, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Enable lens operation";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(54, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Enable pan-tilt operation";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(278, 146);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 32);
            this.button12.TabIndex = 8;
            this.button12.Text = "Stop";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(213, 49);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(166, 31);
            this.button11.TabIndex = 7;
            this.button11.Text = "Get Pan-Tilt Current Position";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnZoomMenos
            // 
            this.btnZoomMenos.Location = new System.Drawing.Point(318, 182);
            this.btnZoomMenos.Name = "btnZoomMenos";
            this.btnZoomMenos.Size = new System.Drawing.Size(61, 32);
            this.btnZoomMenos.TabIndex = 6;
            this.btnZoomMenos.Text = "Zoom -";
            this.btnZoomMenos.UseVisualStyleBackColor = true;
            this.btnZoomMenos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomMenos_MouseDown);
            this.btnZoomMenos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomMenos_MouseUp);
            // 
            // btnZoomMais
            // 
            this.btnZoomMais.Location = new System.Drawing.Point(237, 182);
            this.btnZoomMais.Name = "btnZoomMais";
            this.btnZoomMais.Size = new System.Drawing.Size(61, 32);
            this.btnZoomMais.TabIndex = 6;
            this.btnZoomMais.Text = "Zoom +";
            this.btnZoomMais.UseVisualStyleBackColor = true;
            this.btnZoomMais.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomMais_MouseDown);
            this.btnZoomMais.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomMais_MouseUp);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(318, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 45);
            this.button8.TabIndex = 6;
            this.button8.Text = "Power Off";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(237, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Power On";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(116, 142);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(49, 40);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(67, 182);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(49, 40);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(18, 142);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(49, 40);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(67, 102);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(49, 40);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(133, 50);
            this.textBox1.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadTimeout = 2000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnRevData);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Location = new System.Drawing.Point(249, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 84);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Receive";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Location = new System.Drawing.Point(415, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 148);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Presets";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(164, 21);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(84, 26);
            this.button22.TabIndex = 20;
            this.button22.Text = "Excluir Preset";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(80, 21);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(78, 26);
            this.button21.TabIndex = 19;
            this.button21.Text = "Salvar Preset";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox2.Location = new System.Drawing.Point(15, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(70, 97);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(49, 40);
            this.button17.TabIndex = 17;
            this.button17.Text = "6";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(125, 97);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(49, 40);
            this.button18.TabIndex = 16;
            this.button18.Text = "7";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(180, 97);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(49, 40);
            this.button19.TabIndex = 15;
            this.button19.Text = "8";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(15, 97);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(49, 40);
            this.button20.TabIndex = 14;
            this.button20.Text = "5";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(70, 51);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(49, 40);
            this.button16.TabIndex = 13;
            this.button16.Text = "2";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(125, 51);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(49, 40);
            this.button15.TabIndex = 12;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(180, 51);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(49, 40);
            this.button14.TabIndex = 11;
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(15, 51);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(49, 40);
            this.button13.TabIndex = 10;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(415, 198);
            this.trackBar1.Maximum = 18;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(265, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.MouseLeave += new System.EventHandler(this.trackBar1_MouseLeave);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(415, 249);
            this.trackBar2.Maximum = 18;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(265, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.MouseLeave += new System.EventHandler(this.trackBar2_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "PAN Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "TILT Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sony VISCA Control Protocol";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnZoomMenos;
        private System.Windows.Forms.Button btnZoomMais;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDownLeft;
        private System.Windows.Forms.Button btnDownRight;
        private System.Windows.Forms.Button btnTopLeft;
    }
}
