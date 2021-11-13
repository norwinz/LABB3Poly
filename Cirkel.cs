using System;
using System.Collections.Generic;
using System.Text;

namespace LABB3Poly
{
    public class Cirkel : Teckning
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Cirkel()
            {
            Radius = 13.37;
            }
        public override double Area()
        {
            double svar;
            svar = 3.14 * radius * radius;
           
            return svar;
        }
        
        
        
    }
}
