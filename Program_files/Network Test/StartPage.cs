using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Network_Test
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            startPanel1.Visible = true;
            testing_Panel1.Visible = false;
            Results_Panel1.Visible = false;
        }
    }

   
}
