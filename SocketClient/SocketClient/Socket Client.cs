using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        byte[] m_dataBuffer = new byte[10];
        IAsyncResult m_result;
        public AsyncCallback m_pfnCallBack;
        public Socket m_clientSocket;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // See if we have text on the IP and Port text fields
            if (textBoxIP.Text == "" || textBoxPort.Text == "")
            {
                MessageBox.Show("IP Address and Port Number are required to connect to the Server\n");
                return;
            }
            try
            {
                UpdateControls(false);
                // Create the socket instance
                m_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Cet the remote IP address
                IPAddress ip = IPAddress.Parse(textBoxIP.Text);
                int iPortNo = System.Convert.ToInt16(textBoxPort.Text);
                // Create the end point 
                IPEndPoint ipEnd = new IPEndPoint(ip, iPortNo);
                // Connect to the remote host
                m_clientSocket.Connect(ipEnd);
                if (m_clientSocket.Connected)
                {

                    UpdateControls(true);
                    //Wait for data asynchronously 
                    WaitForData();
                }
            }
            catch (SocketException se)
            {
                string str;
                str = "\nConnection failed, is the server running?\n" + se.Message;
                MessageBox.Show(str);
                UpdateControls(false);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (m_clientSocket != null)
            {
                m_clientSocket.Close();
                m_clientSocket = null;
                UpdateControls(false);
            }
        }

        private void ButtonSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                Object objData = richTextTxMessage.Text;
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(objData.ToString());
                if (m_clientSocket != null)
                {
                    m_clientSocket.Send(byData);
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextRxMessage.Text = string.Empty;
        }

        public class SocketPacket
        {
            public System.Net.Sockets.Socket thisSocket;
            public byte[] dataBuffer = new byte[1];
        }

        public void WaitForData()
        {
            try
            {
                if (m_pfnCallBack == null)
                {
                    m_pfnCallBack = new AsyncCallback(OnDataReceived);
                }
                SocketPacket theSocPkt = new SocketPacket();
                theSocPkt.thisSocket = m_clientSocket;
                // Start listening to the data asynchronously
                m_result = m_clientSocket.BeginReceive(theSocPkt.dataBuffer,
                                                        0, theSocPkt.dataBuffer.Length,
                                                        SocketFlags.None,
                                                        m_pfnCallBack,
                                                        theSocPkt);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void UpdateControls(bool connected)
        {
            buttonConnect.Enabled = !connected;
            buttonDisconnect.Enabled = connected;
            string connectStatus = connected ? "Connected" : "Not Connected";

            SetText(connectStatus);
            //textBoxConnectStatus.Text = connectStatus;
        }

        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                SocketPacket theSockId = (SocketPacket)asyn.AsyncState;
                int iRx = theSockId.thisSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(theSockId.dataBuffer, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);

                SetRichText(szData);

                //richTextRxMessage.Text = richTextRxMessage.Text + szData;
                WaitForData();
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxConnectStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxConnectStatus.Text = text;
            }
        }

        delegate void SetRichTextCallback(string text);
        private void SetRichText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextRxMessage.InvokeRequired)
            {
                SetRichTextCallback d = new SetRichTextCallback(SetRichText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextRxMessage.AppendText(text);
            }
        }
    }
}
