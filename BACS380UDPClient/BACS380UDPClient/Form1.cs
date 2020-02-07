using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets; //added

namespace BACS380UDPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient(1100); //creates new instance of class using constructor of same name as class, parameter of port number
            Byte[] sendBytes = new Byte[] { }; //creates container for bytes
            sendBytes = Encoding.ASCII.GetBytes(txtMessage.Text); //puts text from textbox into array of bytes using library
            udpClient.Send(sendBytes, sendBytes.Length, txtIPadd.Text, Convert.ToInt32(txtPort.Text)); //hint 3 of 3 in tips bubble (bytearray[] dgram, length of array, host name, port #);
            udpClient.Close();
        }
    }
}
