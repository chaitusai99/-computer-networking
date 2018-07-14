using System;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    public partial class Form1 : Form
    {
        const int MAX_CLIENTS = 10;

        public AsyncCallback pfnWorkerCallBack;
        private Socket m_mainSocket;
        private Socket[] m_workerSocket = new Socket[10];
        private int m_clientCount = 0;

        public Form1()
        {
            InitializeComponent();
            textBoxIP.Text = GetIP();
        }

        string GetIP()
        {
            String strHostName = Dns.GetHostName();

            // Find host by name
#pragma warning disable CS0618 // 'Dns.GetHostByName(string)' is obsolete: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
#pragma warning restore CS0618 // 'Dns.GetHostByName(string)' is obsolete: 'GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202'

            // Grab the first IP addresses
            String IPStr = "";
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                IPStr = ipaddress.ToString();
                return IPStr;
            }
            return IPStr;
        }

        private void ButtonStartListenClick_Click(object sender, EventArgs e)
        {
            try
            {
                // Check the port value
                if (textBoxPort.Text == "")
                {
                    MessageBox.Show("Please enter a Port Number");
                    return;
                }
                string portStr = textBoxPort.Text;
                int port = System.Convert.ToInt32(portStr);
                // Create the listening socket...
                m_mainSocket = new Socket(AddressFamily.InterNetwork,
                                          SocketType.Stream,
                                          ProtocolType.Tcp);
                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, port);
                // Bind to local IP Address...
                m_mainSocket.Bind(ipLocal);
                // Start listening...
                m_mainSocket.Listen(4);
                // Create the call back for any client connections...
                m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

                UpdateControls(true);

            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void UpdateControls(bool listening)
        {
            buttonStartListen.Enabled = !listening;
            buttonStopListen.Enabled = listening;
        }

        // This is the call back function, which will be invoked when a client is connected
        public void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                // Here we complete/end the BeginAccept() asynchronous call
                // by calling EndAccept() - which returns the reference to
                // a new Socket object
                m_workerSocket[m_clientCount] = m_mainSocket.EndAccept(asyn);

                // Let the worker Socket do the further processing for the 
                // just connected client
                WaitForData(m_workerSocket[m_clientCount]);

                // Now increment the client count
                ++m_clientCount;

                // Display this client connection as a status message on the GUI	
                String str = String.Format("Client # {0} connected", m_clientCount);
                SetText(str);

                // Since the main Socket is now free, it can go back and wait for
                // other clients who are attempting to connect
                m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\n OnClientConnection: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        public class SocketPacket
        {
            public System.Net.Sockets.Socket m_currentSocket;
            public byte[] dataBuffer = new byte[1];
        }

        // Start waiting for data from the client
        public void WaitForData(System.Net.Sockets.Socket soc)
        {
            try
            {
                if (pfnWorkerCallBack == null)
                {
                    // Specify the call back function which is to be 
                    // invoked when there is any write activity by the 
                    // connected client
                    pfnWorkerCallBack = new AsyncCallback(OnDataReceived);
                }
                SocketPacket theSocPkt = new SocketPacket();
                theSocPkt.m_currentSocket = soc;
                // Start receiving any data written by the connected client
                // asynchronously
                soc.BeginReceive(theSocPkt.dataBuffer, 0,
                                   theSocPkt.dataBuffer.Length,
                                   SocketFlags.None,
                                   pfnWorkerCallBack,
                                   theSocPkt);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        // This the call back function which will be invoked when the socket
        // detects any client writing of data on the stream
        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                SocketPacket socketData = (SocketPacket)asyn.AsyncState;

                int iRx = 0;
                // Complete the BeginReceive() asynchronous call by EndReceive() method
                // which will return the number of characters written to the stream 
                // by the client
                iRx = socketData.m_currentSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(socketData.dataBuffer,
                                         0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                SetRichText(szData);
                //richTextBoxReceivedMsg.AppendText(szData);

                // Continue the waiting for data on the Socket
                WaitForData(socketData.m_currentSocket);
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

        private void ButtonSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                Object objData = richTextBoxSendMsg.Text;
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(objData.ToString());
                for (int i = 0; i < m_clientCount; i++)
                {
                    if (m_workerSocket[i] != null)
                    {
                        if (m_workerSocket[i].Connected)
                        {
                            m_workerSocket[i].Send(byData);
                        }
                    }
                }

            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void buttonStopListen_Click(object sender, EventArgs e)
        {
            CloseSockets();
            UpdateControls(false);
        }

        void CloseSockets()
        {
            if (m_mainSocket != null)
            {
                m_mainSocket.Close();
            }
            for (int i = 0; i < m_clientCount; i++)
            {
                if (m_workerSocket[i] != null)
                {
                    m_workerSocket[i].Close();
                    m_workerSocket[i] = null;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBoxReceivedMsg.Clear();  
        }
        

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxMsg.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxMsg.Text = text;
            }
        }

        delegate void SetRichTextCallback(string text);
        private void SetRichText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBoxReceivedMsg.InvokeRequired)
            {
                SetRichTextCallback d = new SetRichTextCallback(SetRichText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBoxReceivedMsg.AppendText(text);
            }
        }

		private void textBoxIP_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
