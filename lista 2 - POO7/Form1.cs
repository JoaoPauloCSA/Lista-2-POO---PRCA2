using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CotaDolar c;
            c = new CotaDolar();

            c.setCotacao(int.Parse(txtCotacao.Text));
            c.setQuantia(int.Parse(txtQuantia.Text));
            c.calcular();
            lblResultado.Text = c.getResultado().ToString();

        }

        private void txtCotacao_TextChanged(object sender, EventArgs e)
        {
            txtQuantia.Enabled = true;
        }

        private void txtQuantia_TextChanged(object sender, EventArgs e)
        {
            txtCotacao.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCotacao.Text = "";
            txtQuantia.Text = "";
            txtCotacao.Enabled = true;
            txtQuantia.Enabled = false;
        }
    }
}
