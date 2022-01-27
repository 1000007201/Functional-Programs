using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class WindChill
    {
        public void Wind(double temp,double vel)
        {
            double w = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(vel, 0.16);
            Console.WriteLine(w);

        }
    }
}
