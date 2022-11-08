using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Application;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Kondo.Left += 1;
        }



        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
