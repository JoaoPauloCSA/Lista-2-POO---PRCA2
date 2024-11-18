using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Terreno t;
            t = new Terreno();

            t.setBasin(int.Parse(txtBase.Text));
            t.setAltura(int.Parse(txtAltura.Text));
            t.calcular();
            lblResultado.Text = t.getArea().ToString();

        }
    }
}
