using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPOO10
{
    class Terreno
    {
        private double basin;
        private double altura;
        private double area;

        #region construtores

        public Terreno()
        {
            this.basin = 0;
            this.altura = 0;
        }

        public Terreno(double basin, double altura)
        {
            this.basin = basin;
            this.altura = altura;
        }

        #endregion

        #region getset
        public void setBasin(double x)
        {
            this.basin = x;
        }

        public void setAltura(double x)
        {
            this.altura = x;
        }

        public double getBasin()
        {
            return this.basin;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public double getArea()
        {
            return this.area;
        }
        #endregion

        public void calcular()
        {
            this.area = this.basin * this.altura;
        }
    }
}
