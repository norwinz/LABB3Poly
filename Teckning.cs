using System;
using System.Collections.Generic;
using System.Text;

namespace LABB3Poly
{
    public class Teckning
    {
        public virtual double Area()
        {
            double svar = 0;
            return svar;
        }
        public virtual void Printout()
        {
            double print = Math.Round(Area(), 2);
            Console.WriteLine("Arean är: {0}", print);
        }
    }
}
