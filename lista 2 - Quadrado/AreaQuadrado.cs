using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2___Quadrado
{
    internal class AreaQuadrado
    {
        private double aresta;
        private double resultado;


        public AreaQuadrado()
        {
            this.aresta = 0;
        }

        public AreaQuadrado(double aresta, double resultado)
        {
            this.aresta = aresta;
        }


        public void setAresta(double x)
        {
            this.aresta = x;
        }

        public double getAresta()
        {
            return this.aresta;
        }

        public double getResultado()
        {
            return this.resultado;
        }



        public void calcular()
        {
            this.resultado = Math.Pow(this.aresta, 2);
        }
    }
}
