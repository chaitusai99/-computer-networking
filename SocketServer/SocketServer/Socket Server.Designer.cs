namespace SocketServer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBoxSendMsg = new System.Windows.Forms.RichTextBox();
			this.ButtonSendMsg = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBoxReceivedMsg = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.buttonStartListen = new System.Windows.Forms.Button();
			this.buttonStopListen = new System.Windows.Forms.Button();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxMsg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server IP : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Port : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Broadcast Message to Client";
			// 
			// richTextBoxSendMsg
			// 
			this.richTextBoxSendMsg.Location = new System.Drawing.Point(16, 116);
			this.richTextBoxSendMsg.Name = "richTextBoxSendMsg";
			this.richTextBoxSendMsg.Size = new System.Drawing.Size(231, 150);
			this.richTextBoxSendMsg.TabIndex = 3;
			this.richTextBoxSendMsg.Text = "";
			// 
			// ButtonSendMsg
			// 
			this.ButtonSendMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSendMsg.Location = new System.Drawing.Point(16, 272);
			this.ButtonSendMsg.Name = "ButtonSendMsg";
			this.ButtonSendMsg.Size = new System.Drawing.Size(231, 36);
			this.ButtonSendMsg.TabIndex = 4;
			this.ButtonSendMsg.Text = "Send";
			this.ButtonSendMsg.UseVisualStyleBackColor = true;
			this.ButtonSendMsg.Click += new System.EventHandler(this.ButtonSendMsg_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 347);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Status :";
			// 
			// richTextBoxReceivedMsg
			// 
			this.richTextBoxReceivedMsg.Location = new System.Drawing.Point(274, 116);
			this.richTextBoxReceivedMsg.Name = "richTextBoxReceivedMsg";
			this.richTextBoxReceivedMsg.ReadOnly = true;
			this.richTextBoxReceivedMsg.Size = new System.Drawing.Size(238, 150);
			this.richTextBoxReceivedMsg.TabIndex = 7;
			this.richTextBoxReceivedMsg.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(271, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "Message Received from Clients";
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(274, 272);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(231, 36);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// buttonStartListen
			// 
			this.buttonStartListen.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonStartListen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStartListen.Location = new System.Drawing.Point(274, 25);
			this.buttonStartListen.Name = "buttonStartListen";
			this.buttonStartListen.Size = new System.Drawing.Size(116, 51);
			this.buttonStartListen.TabIndex = 10;
			this.buttonStartListen.Text = "Start Listening";
			this.buttonStartListen.UseVisualStyleBackColor = false;
			this.buttonStartListen.Click += new System.EventHandler(this.ButtonStartListenClick_Click);
			// 
			// buttonStopListen
			// 
			this.buttonStopListen.BackColor = System.Drawing.Color.Salmon;
			this.buttonStopListen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStopListen.Location = new System.Drawing.Point(396, 25);
			this.buttonStopListen.Name = "buttonStopListen";
			this.buttonStopListen.Size = new System.Drawing.Size(116, 51);
			this.buttonStopListen.TabIndex = 11;
			this.buttonStopListen.Text = "Stop Listening";
			this.buttonStopListen.UseVisualStyleBackColor = false;
			this.buttonStopListen.Click += new System.EventHandler(this.buttonStopListen_Click);
			// 
			// textBoxIP
			// 
			this.textBoxIP.Enabled = false;
			this.textBoxIP.Location = new System.Drawing.Point(83, 25);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(123, 20);
			this.textBoxIP.TabIndex = 12;
			this.textBoxIP.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(83, 56);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(123, 20);
			this.textBoxPort.TabIndex = 1;
			this.textBoxPort.Text = "1096";
			// 
			// textBoxMsg
			// 
			this.textBoxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMsg.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.textBoxMsg.Location = new System.Drawing.Point(79, 347);
			this.textBoxMsg.Multiline = true;
			this.textBoxMsg.Name = "textBoxMsg";
			this.textBoxMsg.Size = new System.Drawing.Size(311, 15);
			this.textBoxMsg.TabIndex = 14;
			this.textBoxMsg.Text = "None";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 382);
			this.Controls.Add(this.textBoxMsg);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.textBoxIP);
			this.Controls.Add(this.buttonStopListen);
			this.Controls.Add(this.buttonStartListen);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBoxReceivedMsg);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ButtonSendMsg);
			this.Controls.Add(this.richTextBoxSendMsg);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Socket Server";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxSendMsg;
        private System.Windows.Forms.Button ButtonSendMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxReceivedMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonStartListen;
        private System.Windows.Forms.Button buttonStopListen;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxMsg;
    }
}

