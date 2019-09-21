using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = System.DateTime.Now.ToShortTimeString();
            this.label1.Text = time;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(2200, 900);
            this.timer1.Start();
            this.timer1_Tick(this, null);
        }
    }
}
