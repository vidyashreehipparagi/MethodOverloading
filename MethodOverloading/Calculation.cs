using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a,int b,int c)
        {
            return a+b+c;
        }
        public double Addition(double a, double b)
        {
            return a + b;
        }

        public int Substration(int a, int b)
        {
            return a - b;
        }
        public int Substration(int a, int b, int c)
        {
            return a - b - c;
        }
        public double Substration(double a, double b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Multiplication(double a, double b)
        {
            return a - b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
        public int Division(int a, int b, int c)
        {
            return a / b / c;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
    }
}
