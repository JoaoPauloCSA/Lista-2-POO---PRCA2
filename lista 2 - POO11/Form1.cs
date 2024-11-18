using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IMC i;
            i = new IMC();

            i.setPeso(double.Parse(txtPeso.Text));
            i.setAltura(double.Parse(txtAltura.Text));
            i.calcular();
            lblResultado.Text = i.getImc().ToString("#,00");


        }
    }
}
