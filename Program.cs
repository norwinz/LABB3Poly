using System;

//Dan Gustafsson LABB 3 Polymorphism SUT-21
namespace LABB3Poly
{
    public class Program
    {
        static void Main(string[] args)
        {

            Teckning t1 = new Cirkel();
            Console.WriteLine("Area Cirkel: "+ Math.Round(t1.Area(), 2));

            Teckning t2 = new Fyrkant();
            Console.WriteLine("Area Fyrkant: "+ Math.Round(t2.Area(), 2));

            Teckning t3 = new Rektangel();
            Console.WriteLine("Area Rektangel: "+ Math.Round(t3.Area(), 2));
        }
    }
}
