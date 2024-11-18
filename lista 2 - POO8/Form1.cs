using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Maior m;
            m = new Maior();

            m.setn1(int.Parse(txtN1.Text));
            m.setn2(int.Parse(txtN2.Text));
            m.indicarMaior();
            lblResultado.Text = m.getns();

            txtN1.Text = "";
            txtN2.Text = "";
            txtN1.Enabled = true;
            txtN2.Enabled = false;
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
            txtN2.Enabled = true;
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
            txtN1.Enabled = false;
        }
    }
}
