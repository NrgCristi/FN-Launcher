using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite_MP_Accounts_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            string args = "-AUTH_LOGIN=unused, -AUTH_PASSWORD=textBox1.Text, -AUTH_TYPE=textBox1.Text, -epicapp=Fortnite, -epicenv-Prod, -EpicPortal";
            System.Diagnostics.Process.Start("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe");
        }
    }
}