namespace SocketClient
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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextRxMessage = new System.Windows.Forms.RichTextBox();
            this.ButtonSendMsg = new System.Windows.Forms.Button();
            this.richTextTxMessage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnectStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(111, 48);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(123, 20);
            this.textBoxPort.TabIndex = 14;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(111, 17);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(123, 20);
            this.textBoxIP.TabIndex = 24;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Salmon;
            this.buttonDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(424, 17);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(116, 51);
            this.buttonDisconnect.TabIndex = 23;
            this.buttonDisconnect.Text = "Disconnect fro Server";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(302, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(116, 51);
            this.buttonConnect.TabIndex = 22;
            this.buttonConnect.Text = "Connect to Server";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(302, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(231, 36);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Message Received from Server";
            // 
            // richTextRxMessage
            // 
            this.richTextRxMessage.Location = new System.Drawing.Point(302, 108);
            this.richTextRxMessage.Name = "richTextRxMessage";
            this.richTextRxMessage.ReadOnly = true;
            this.richTextRxMessage.Size = new System.Drawing.Size(238, 150);
            this.richTextRxMessage.TabIndex = 19;
            this.richTextRxMessage.Text = "";
            // 
            // ButtonSendMsg
            // 
            this.ButtonSendMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendMsg.Location = new System.Drawing.Point(44, 264);
            this.ButtonSendMsg.Name = "ButtonSendMsg";
            this.ButtonSendMsg.Size = new System.Drawing.Size(231, 36);
            this.ButtonSendMsg.TabIndex = 18;
            this.ButtonSendMsg.Text = "Send";
            this.ButtonSendMsg.UseVisualStyleBackColor = true;
            this.ButtonSendMsg.Click += new System.EventHandler(this.ButtonSendMsg_Click);
            // 
            // richTextTxMessage
            // 
            this.richTextTxMessage.Location = new System.Drawing.Point(44, 108);
            this.richTextTxMessage.Name = "richTextTxMessage";
            this.richTextTxMessage.Size = new System.Drawing.Size(231, 150);
            this.richTextTxMessage.TabIndex = 17;
            this.richTextTxMessage.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Message to Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server IP : ";
            // 
            // textBoxConnectStatus
            // 
            this.textBoxConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxConnectStatus.Location = new System.Drawing.Point(107, 330);
            this.textBoxConnectStatus.Multiline = true;
            this.textBoxConnectStatus.Name = "textBoxConnectStatus";
            this.textBoxConnectStatus.Size = new System.Drawing.Size(189, 15);
            this.textBoxConnectStatus.TabIndex = 26;
            this.textBoxConnectStatus.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Status :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.textBoxConnectStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextRxMessage);
            this.Controls.Add(this.ButtonSendMsg);
            this.Controls.Add(this.richTextTxMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Socket Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextRxMessage;
        private System.Windows.Forms.Button ButtonSendMsg;
        private System.Windows.Forms.RichTextBox richTextTxMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnectStatus;
        private System.Windows.Forms.Label label4;
    }
}

