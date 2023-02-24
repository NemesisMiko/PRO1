using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvaOkenska
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btnIzhod_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRezultat_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textprvo.Text);
            double b = double.Parse(textdrugo.Text);

            if(rbSestej.Checked==true)
            textrez.Text = (a + b).ToString();

            if(rbOdstej.Checked == true)
            textrez.Text = (a - b).ToString();

            if(rbMnozi.Checked == true)
            textrez.Text = (a * b).ToString();

            if(rbDeli.Checked == true)
            textrez.Text = (a / b).ToString();

            if (cbNeg.Checked == true && double.Parse(textrez.Text) < 0)
            {
                textrez.ForeColor = Color.Red;
            }
            else
                textrez.ForeColor = Color.Black;
            
                

        }
    }
}
