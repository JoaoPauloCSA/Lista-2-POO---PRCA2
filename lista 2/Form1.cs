using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            Area area = new Area();
            area.setBase(int.Parse(txtBase.Text));
            area.setAltura(int.Parse(txtAltura.Text));
            area.calcular();
            lblArea.Text = area.getResultado().ToString();
        }
    }
}
