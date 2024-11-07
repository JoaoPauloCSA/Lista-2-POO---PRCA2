using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2
{
    internal class Area
    {
        private int b1;
        private int altura;
        private int resultado;

        #region constructors
        public Area()
        {
            this.b1 = 0;
            this.altura = 0;
        }

        public Area(int b1, int altura)
        {
            this.b1 = b1;
            this.altura = altura;
        }
        #endregion

        #region getset
        public void setBase(int x)
        {
            this.b1 = x;
        }

        public void setAltura(int x)
        {
            this.altura = x; ;
        }

        public int getB1()
        {
            return this.b1;
        }

        public int getAltura()
        {
            return this.altura;
        }

        public int getResultado()
        {
            return this.resultado;
        }
        #endregion

        public void calcular()
        {
            this.resultado = this.b1 * this.altura;
        }
    }
}
