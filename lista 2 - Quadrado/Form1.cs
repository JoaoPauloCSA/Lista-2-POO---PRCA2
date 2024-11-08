using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_2___Quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("==Área do quadrado (aresta)==");

            AreaQuadrado aq;
            aq = new AreaQuadrado();

            do
            {
                Console.Write("Digite o valor da Aresta: ");
                aq.setAresta(double.Parse(txtAresta.Text));
            }
            while (aq.getAresta() <= 0);

            aq.calcular();
            lblÁrea.Text = aq.getResultado().ToString();


            Console.WriteLine();
            Console.WriteLine("Aresta: {0}", aq.getAresta());
            Console.Write("Área do Quadrado = {0}", aq.getResultado());
        }

 

    }
}
