using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace BACS380ServerUDP
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }
        private void Receiver()
        {
            UdpClient udpClient = new UdpClient(1100); //add using system.net.sockets //port must be specified on server side
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0); //add using system.net
            string receiveString;
            Byte[] receiveBytes = new byte[] { }; //array of bytes

            while (true)
            {
                receiveBytes = udpClient.Receive(ref RemoteIpEndPoint); //waits for message, when received, assigns message to Byte container, blocking call
                receiveString = Encoding.ASCII.GetString(receiveBytes); //converts bytes to string
                txtMessage.AppendText(receiveString);
                txtMessage.AppendText(Environment.NewLine); //new line
                txtMessage.Refresh(); //refreshes form manually to show any new text
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread receivingThread = new Thread(Receiver);
            receivingThread.IsBackground = true;
            receivingThread.Start();
            btnStart.Enabled = false;
        }
    }
}
