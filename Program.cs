using System;

//Dan Gustafsson LABB 3 Polymorphism SUT-21
namespace LABB3Poly
{
    public class Program
    {
        static void Main(string[] args)
        {

            Teckning t1 = new Cirkel();
            Teckning t2 = new Fyrkant();
            Teckning t3 = new Rektangel();
           
            t1.Printout();
            t2.Printout();
            t3.Printout();                   
        }
    }
}
