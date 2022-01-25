using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class EuclideDistance
    {
        public void Distance()
        {
            Console.WriteLine("Enter value of x and y cordinate");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
    }
}