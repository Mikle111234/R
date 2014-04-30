using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Figure
    {
        //Площадь фигуры 
        public abstract double square();
        public abstract double perimeter();
    }

    class Triangle : Figure
    {
        double a, b, c; //Стороны 
        //Конструктор 
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double square()
        {
            //Используем формулу Герока 
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override double perimeter()
        {
            double per = a + b + c;
            return per;
        }
    }

    class PrintFigur
    {
        public void print(Figure f)
        {
            Console.WriteLine("perimetr figure = " + f.perimeter() + ", square figure = " + f.square());
        }
    }

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
            int[] a = { 1, -2, -1, 1, 1 };
            Massive ob = new Massive();
            Console.WriteLine(ob.Sum(a));
            Console.WriteLine(ob.Sum1(a));
            Console.WriteLine(ob.SumOtr(a));
            Console.ReadLine();
        }
    }
}
