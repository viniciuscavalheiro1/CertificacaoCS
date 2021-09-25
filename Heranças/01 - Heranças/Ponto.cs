using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças._01___Heranças
{
    class Ponto
    {
        public int x, y;

        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void calcularDistancia()
        {
            //Fazer o calculo
        }

        private void calcularDistancia2()
        {
            //Fazer o calculo
        }

        public virtual void calcularDistancia3()
        {
            //Fazer o calculo
        }
    }
}
