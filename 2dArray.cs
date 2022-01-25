using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class MultiArray
    {
        public void ShowArray()
        {
            int[,] arr = new int[3, 2];//Assigning Array
            //Taking values of array from user
            Console.WriteLine("Enter values for 3*2 array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Displaying array to user
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", arr[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}