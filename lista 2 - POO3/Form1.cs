using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AreaDiagonal a;
            a = new AreaDiagonal();

            a.setDiagonal(int.Parse(txtDiagonal.Text));
            a.calcular();
            lblResultado.Text = a.getResultado().ToString();
        }
    }
}
