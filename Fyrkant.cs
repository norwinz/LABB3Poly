using System;
using System.Collections.Generic;
using System.Text;

namespace LABB3Poly
{
    public class Fyrkant : Teckning //Kvadrat
    {
        private double side;
        

        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Fyrkant()
        {
            Side = 4.28;
        }
        
        public override double Area()
        {
            double svar;
            svar = side * side;
            return svar;
        }
        public override void Printout()
        {
            double print = Math.Round(Area(), 2);
            Console.WriteLine("Area Fyrkant: {0}", print);
        }
    }
}
