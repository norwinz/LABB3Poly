using System;
using System.Collections.Generic;
using System.Text;

namespace LABB3Poly
{
    public class Rektangel : Teckning
    {
        private double height;
        private double width;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rektangel()
            {
            Height = 4.11;
            Width = 8.40;
            }
    
        public override double Area()
        {
            double svar;
            svar = width * height;
            return svar;
        }
        public override void Printout()
        {
            double print = Math.Round(Area(), 2);
            Console.WriteLine("Area Rektangel: {0}", print);
        }
    }
}
