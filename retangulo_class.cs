using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class retangulo
    {
        public double Base;

        public double altura;
        
       
        public double area()
        {
            
            double p = (Base * altura);
            return p;
        }


        public double perimetro()
        {
            double q = 2 * (Base + altura);
            return q;
        }

        public double diagonal()
        {
         double r = Math.Sqrt(Base * Base + altura * altura);

            return r;
        }
    }
}
