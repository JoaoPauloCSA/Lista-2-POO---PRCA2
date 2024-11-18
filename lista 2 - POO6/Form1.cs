using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MilhaQuilo m;
            m = new MilhaQuilo();

            m.setMilhas(int.Parse(txtMilhas.Text));
            m.calcular();
            lblResultado.Text = m.getResultado().ToString();
        }
    }
}
