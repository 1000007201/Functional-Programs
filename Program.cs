// See https://aka.ms/new-console-template for more information
using FunctionalProgram;

bool Flag = true;
Console.WriteLine("1.Display array entered by you.\n2.Find distance from origin.\n3.Find roots of Quadratic equation." +
    "\n4.Summ of three.\n5.Find velocity of Wind Chill.\n6.Exit");
int number = Convert.ToInt32(Console.ReadLine());
while (Flag)
{
    switch (number)
    {
        case 1:
            MultiArray multiArray = new MultiArray();
            multiArray.ShowArray();
            break;
        case 2:
            EuclideDistance distance = new EuclideDistance();
            distance.Distance();
            break;
        case 3:
            QuadRoots quadRoots = new QuadRoots();
            quadRoots.GetRoots();
            break;
        case 4:
            ThreeInteger ti = new ThreeInteger();
            int[] arr = { 0, -1, 2, -3, 1 };
            ti.FindTriplet(arr, arr.Length);
            break;
        case 5:
            WindChill windChill = new WindChill();
            windChill.Wind(40, 10);
            break;
        case 6:
            Flag = false;
            break;

    }
}
