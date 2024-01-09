using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_örneği_815
{
    public partial class Form1 : Form
    {
        int sayac = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
                this.BackColor = Color.Black;
                lblSayac.ForeColor = Color.White;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
    }
}
