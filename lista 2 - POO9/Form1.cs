using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiorIgual m;
            m = new MaiorIgual();

            m.setn1(int.Parse(txtN1.Text));
            m.setn2(int.Parse(txtN2.Text));
            m.indicarMaior();
            lblResultado.Text = m.getns();
        }
    }
}
