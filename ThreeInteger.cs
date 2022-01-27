using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class ThreeInteger
    {
        public void FindTriplet(int[] arr, int number)
        {
            bool found = false;
            for (int i = 0; i < number - 2; i++)
            {
                for (int j = i + 1; i < number - 1; j++)
                {
                    for (int k = j + 1; k < number - 1; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine(arr[i] + arr[j] + arr[k]);
                            found = true;

                        }
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("Not Exist");
            }
        }
    }
}