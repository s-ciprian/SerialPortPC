
namespace SerialPortPC_App
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_CloseComPort = new System.Windows.Forms.Button();
            this.label_PortStaus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenComPort = new System.Windows.Forms.Button();
            this.comboBox_ExisitingSerialPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_CloseComPort);
            this.groupBox1.Controls.Add(this.label_PortStaus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_OpenComPort);
            this.groupBox1.Controls.Add(this.comboBox_ExisitingSerialPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial port";
            // 
            // button_CloseComPort
            // 
            this.button_CloseComPort.Location = new System.Drawing.Point(9, 76);
            this.button_CloseComPort.Name = "button_CloseComPort";
            this.button_CloseComPort.Size = new System.Drawing.Size(75, 23);
            this.button_CloseComPort.TabIndex = 5;
            this.button_CloseComPort.Text = "Close COM";
            this.button_CloseComPort.UseVisualStyleBackColor = true;
            this.button_CloseComPort.Click += new System.EventHandler(this.button_CloseComPort_Click);
            // 
            // label_PortStaus
            // 
            this.label_PortStaus.AutoSize = true;
            this.label_PortStaus.Location = new System.Drawing.Point(43, 105);
            this.label_PortStaus.Name = "label_PortStaus";
            this.label_PortStaus.Size = new System.Drawing.Size(53, 13);
            this.label_PortStaus.TabIndex = 4;
            this.label_PortStaus.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM port selection";
            // 
            // btn_OpenComPort
            // 
            this.btn_OpenComPort.Location = new System.Drawing.Point(9, 47);
            this.btn_OpenComPort.Name = "btn_OpenComPort";
            this.btn_OpenComPort.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenComPort.TabIndex = 0;
            this.btn_OpenComPort.Text = "Open COM";
            this.btn_OpenComPort.UseVisualStyleBackColor = true;
            this.btn_OpenComPort.Click += new System.EventHandler(this.btn_OpenComPort_Click);
            // 
            // comboBox_ExisitingSerialPorts
            // 
            this.comboBox_ExisitingSerialPorts.FormattingEnabled = true;
            this.comboBox_ExisitingSerialPorts.Location = new System.Drawing.Point(109, 20);
            this.comboBox_ExisitingSerialPorts.Name = "comboBox_ExisitingSerialPorts";
            this.comboBox_ExisitingSerialPorts.Size = new System.Drawing.Size(66, 21);
            this.comboBox_ExisitingSerialPorts.TabIndex = 1;
            this.comboBox_ExisitingSerialPorts.DropDown += new System.EventHandler(this.comboBox_ExisitingSerialPorts_DropDown);
            this.comboBox_ExisitingSerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox_ExisitingSerialPorts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_CloseComPort;
        private System.Windows.Forms.Label label_PortStaus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenComPort;
        private System.Windows.Forms.ComboBox comboBox_ExisitingSerialPorts;
    }
}

