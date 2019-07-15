using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Sockets;

namespace Network_Test
{
    public partial class StartPanel : UserControl
    {
        public StartPanel()
        {
            InitializeComponent();
            GetStartPageData();
        }

        void GetStartPageData()
        {
            Console.WriteLine("Printing Network Information:");
            // Hostname stuff
            string hostName = Dns.GetHostName();
            HostnameData.Text = hostName;
            Console.WriteLine("Hostname: " + hostName.ToString());
            // IP Address Stuff
            string GetIP()
            {
                string IPAddress = "";
                foreach (IPAddress ipAdd in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (ipAdd.AddressFamily.ToString() == AddressFamily.InterNetwork.ToString())
                    {
                        IPAddress = ipAdd.ToString();
                    }
                }
                return IPAddress;
            }
            string IPAddr = GetIP();
            IPAddrData.Text = IPAddr;
            Console.WriteLine("IP: " + IPAddr.ToString());
            // Gateway Stuff
            IPAddress GetDefaultGateway()
            {
                return NetworkInterface
                    .GetAllNetworkInterfaces()
                    .Where(n => n.OperationalStatus == OperationalStatus.Up)
                    .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                    .Select(g => g?.Address)
                    .Where(a => a != null)
                    // might need to be commented out
                    .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                    .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                    //
                    .FirstOrDefault();
            }
            string GWay = GetDefaultGateway().ToString();
            GatewayData.Text = GWay;
            Console.WriteLine("Gateway: " + GWay.ToString());
        }


        private void Label1_Click(object sender, EventArgs e)
        { }


        private void Label6_Click(object sender, EventArgs e)
        { }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            // Go Button Action here
        }

        private void Label2_Click(object sender, EventArgs e)
        { }


    }


}

