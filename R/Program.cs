using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Massive
    {
        public int Sum(int[] x)
        {
            int summa = 0;
            foreach (int c in x)
            { summa += c; }
            return summa;
        }
        public int Sum1(int[] x)
        {
            int summa = 0;
            bool f = false;
            foreach (int c in x)
            {
                if (f)
                {
                    summa += c;
                    f = false;
                }
                else
                    f = true;
            }
            return summa;
        }
        public int SumOtr(int[] x)
        {
            int summa = 0;
            foreach (int c in x)
            {
                if (c < 0)
                    return summa;
                summa += c;
            }
            return summa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
