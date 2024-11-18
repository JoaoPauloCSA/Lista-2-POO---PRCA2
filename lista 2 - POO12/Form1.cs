using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            FTriangulo f;
            f = new FTriangulo();

            f.setA(int.Parse(txtLadoA.Text));
            f.setB(int.Parse(txtLadoB.Text));
            f.setC(int.Parse(txtLadoC.Text));
            f.triangular();
            lblResultado.Text = f.getNs();

        }
    }
}
