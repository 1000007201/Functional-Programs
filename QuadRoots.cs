using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class QuadRoots
    {
        //Quadratic Equation : a*x*x +b*x + c
        public void GetRoots()
        {
            double a, b, c;//Theese are taken by the user
            double delta, x1, x2;//These are which we have to calculate
            Console.WriteLine("Enter the value of A,B,C:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are linear :{0}", x1);

            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta >= 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Roots of this equation is {0} and {1}", x1, x2);
                }
                else
                {
                    Console.WriteLine("Roots are imaginary");
                }

            }



        }
    }
}
