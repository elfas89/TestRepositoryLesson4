using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //1
            //  Hello(); 

            //2
            //Sum();
            
            //3
            //InvertDigits(427);
            //Console.WriteLine(InvertDigits(427));

            //4
            //Console.WriteLine(Even(Convert.ToInt32(Console.ReadLine())));

            //Console.WriteLine("Enter a number below:");
            //int k = Convert.ToInt32(Console.ReadLine());
            //bool torf = Even(k);
            //Console.WriteLine("Your number is even: " + torf);

            //5
            //double perimeter;
            //double square;
            //double side = 45.0;
            //TrianglePS(side, out perimeter, out square);
            //Console.WriteLine("Сторона равностороннего треугольника: " + side);
            //Console.WriteLine("Периметр: " + perimeter);
            //Console.WriteLine("Площадь: " + "{0:F2}", square);
            
            //6
            //double x = 67.0;
            //double y = 45.0;
            //MinMax (ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //7
            //int sum = SumAnyInts(2, 56, 3, 4, 15);
            //Console.WriteLine(sum);

            //8
            //int k = 537;
            //int kSum = DigitSum(k);
            //Console.WriteLine(kSum);

            //9
            //float result;
            //result = Calc(5, 6, MathOperations.sub);
            //Console.WriteLine(result);

            //10

            Goods[] arrG = new Goods[3];

            arrG[0].name = "tovar1";
            arrG[0].date = "01-11-2015";
            arrG[0].mass = 5.0;
            arrG[0].cost = 29.9;
            arrG[0].vendor = "Vendor1";
            arrG[0].save = 14;

            arrG[1].name = "tovar2";
            arrG[1].date = "25-09-2015";
            arrG[1].mass = 3.2;
            arrG[1].cost = 45.5;
            arrG[1].vendor = "Vendor2";
            arrG[1].save = 48;

            arrG[2] = new Goods("Tovar3", "13-12-2015", 8.8, 99.9, "Vendor3", 60);

            foreach (Goods i in arrG)
            {
                Console.WriteLine(i.name + ' ' + i.date + ' ' + i.mass + ' ' + i.cost + ' ' + i.vendor + ' ' + i.save);
            }



 }



        static void Hello()
        {
            string userName = "noName";

            Console.WriteLine("Ваше имя?");
            userName = Console.ReadLine();
            Console.WriteLine("Привет, " + userName);
        }

        static void Sum()
        {
            double a;
            double b;

            Console.WriteLine("Введите два числа:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + b);
        }

        static int InvertDigits(int k)
        {
            int d3 = k % 10;
            int d2 = k / 10 % 10;
            int d1 = k / 100;
            int res = Convert.ToInt32(Convert.ToString(d3) + Convert.ToString(d2) + Convert.ToString(d1));
            return res;
        }

        static bool Even(int k)
        {
            if (k % 2 == 0)
            {
                return true;
            } else {
                return false;
            }
        }

        static void TrianglePS (double a, out double P, out double S)
        {
            P = a * 3;
            S = a * a * System.Math.Sqrt(3.0) / 4.0;
        }

        static void MinMax(ref double x, ref double y)
        {
            double min;
            double max;
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            x = min;
            y = max;

        }

        static int SumAnyInts(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum = sum + ints[i];
            }
            return sum;
        }

        static int DigitSum(int k)
        {
            if (k == 0)
            {
                return 0;
            }
            else return k % 10 + DigitSum(k / 10);
        }

        static float Calc(float x, float y, MathOperations z)
        {
            float res = 0f;

            switch (z)
            {
                case MathOperations.add:
                    res = x + y;
                    break;
                case MathOperations.div:
                    res = x - y;
                    break;
                case MathOperations.mul:
                    res = x * y;
                    break;
                case MathOperations.sub:
                    res = x / y;
                    break;
            }

            return res;
        }


  }
}

