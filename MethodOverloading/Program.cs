

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            int result = c1.Addition(20, 30);
            double result2 = c1.Addition(23.21, 32.02);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            int result3=c1.Substration(20, 30);
            double result4 = c1.Substration(52.23, 36.21);
            int result5 = c1.Substration(50, 63, 23);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            int result6=c1.Multiplication(20, 30);
            double result7 = c1.Multiplication(10.3, 53.2);
            int result8 = c1.Multiplication(2, 3, 6);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);

            int res=c1.Division(50,10);
            double res1 = c1.Division(10.2, 2);
            int res2=c1.Division(10,10,10);
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);

        }
    }
}
