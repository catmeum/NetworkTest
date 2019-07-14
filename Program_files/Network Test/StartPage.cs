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
using System.Net.NetworkInformation;
using System.IO;



namespace Network_Test
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            Console.WriteLine("Printing Network Information:");
            // Hostname stuff
            string hostName = Dns.GetHostName();
            HostnameData.Text = hostName;
            Console.WriteLine("Hostname: $1 ", hostName);
            // IP Address Stuff
            string IPAddr = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            IPAddrData.Text = IPAddr;
            Console.WriteLine("IP: $1 ", IPAddr);
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
                    // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                    // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                    .FirstOrDefault();
            }
            string GWay = GetDefaultGateway().ToString();
            GatewayData.Text = GWay;
            Console.WriteLine("Gateway: $1", GWay);
            // MAC Address stuff
            var macAddr =
                (from nic in NetworkInterface.GetAllNetworkInterfaces()
                 where nic.OperationalStatus == OperationalStatus.Up
                 select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();
            MACAddrData.Text = macAddr;
            Console.WriteLine("MAC: $1 ", macAddr);
            // Hard Drive Space
            long GetTotalFreeSpace(string driveName)
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady && drive.Name == driveName)
                    {
                        return drive.TotalFreeSpace;
                    }
                }
                return -1;
            }
            long driveSpace = GetTotalFreeSpace("C:");
            HDData.Text = driveSpace.ToString();
            Console.WriteLine("HD Space: $1", driveSpace.ToString());
            

    }

    private void Label1_Click(object sender, EventArgs e)
    {

    }


    private void Label6_Click(object sender, EventArgs e)
    { }

    private void Button1_Click(object sender, EventArgs e)
    {

    }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
