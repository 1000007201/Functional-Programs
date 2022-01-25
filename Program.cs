// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;


            while (flag)
            {
                Console.WriteLine("Enter value:\n1.For String Replacement.\n2.Head and Tail Percentage.\n3.Check Leap Year.\n4.Harmonic Number.\n5.Sum of Three.\n5.Exit.");
                int task = (int)Convert.ToDouble(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        StringReplace rep = new StringReplace();
                        rep.StrReplace("Nishant");
                        break;
                    case 2:
                        TossResult tos = new TossResult();
                        tos.Toss();
                        break;
                    case 3:
                        LeapYear ly = new LeapYear();
                        ly.YearCheck();
                        break;
                    case 4:
                        HarmonicNumber hn = new HarmonicNumber();
                        hn.GetHarmonic();
                        break;
                    case 5:
                        ThreeInteger ti = new ThreeInteger();
                        int[] arr = { 0, -1, 2, -3, 1 };
                        int number = arr.Length;
                        ti.FindTriplet(arr, number);
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter right value");
                        break;

                }
            }


        }
    }
}