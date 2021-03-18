using System;


namespace ConsoleApp2
{

    class Program
    {
        static double a, b, c, d;
        static void Main(string[] args)
        {
            for (; ; )
            {
                double D, x1, x2, x3;
                bool check = false;
                bool check1 = false;
                bool check2 = false;
                bool check3 = false;
                while (!check)
                {
                    string str = "Введите коэффициент x в кубе";
                    Console.WriteLine(str);
                    try
                    {
                        check = true;
                        a = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        check = false;
                        Console.WriteLine("Введен неверный символ, введите число!\n\n");

                    }
                }
                while (!check1)
                {
                    string str1 = "Введите коэффициент x в квадрате";
                    Console.WriteLine(str1);


                    try
                    {
                        check1 = true;
                        b = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {

                        Console.WriteLine("Введен неверный символ, введите число!\n");
                        check1 = false;
                    }
                }
                while (!check2)
                {
                    string str2 = "Введите коэффициент x";
                    Console.WriteLine(str2);


                    try
                    {
                        check2 = true;
                        c = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введен неверный символ, введите число!\n");
                        check2 = false;
                    }
                }
                while (!check3)
                {

                    string str3 = "Введите коэффициент свободного члена";
                    Console.WriteLine(str3);

                    try
                    {
                        check3 = true;
                        d = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введен неверный символ, введите число!\n");
                        check3 = false;
                    }
                }

                if (d == 0 && a != 0)
                {

                    D = (Math.Pow(b, 2) - 4 * a * c);
                    if (D > 0)
                    {
                        x1 = 0;
                        x2 = (-b + Math.Sqrt(D)) / (2 * a);
                        x3 = (-b - Math.Sqrt(D)) / (2 * a);
                        Console.WriteLine("Корни уравнения :" + "\nx1 = " + x1);
                        Console.WriteLine("x2 = " + x2);
                        Console.WriteLine("x3 = " + x3);
                    }
                    if (D == 0 && b != 0)
                    {
                        x1 = 0;
                        x2 = -b / (2 * a);
                        Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                        Console.WriteLine("x2 = " + x2);
                    }
                    if (D < 0)
                    {
                        x1 = 0;
                        Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                    }
                }
                if (a == 0 && b != 0 && c != 0)
                {
                    if (d != 0)
                    {
                        D = (Math.Pow(c, 2) - 4 * b * d);
                        if (D > 0)
                        {
                            x1 = (-c + Math.Sqrt(D)) / (2 * b);
                            x2 = (-c - Math.Sqrt(D)) / (2 * b);
                            Console.WriteLine("Корни уравнения :" + "\nx1 = " + x1);
                            Console.WriteLine("x2 = " + x2);

                        }
                        if (D == 0)
                        {
                            x1 = -c / (2 * b);
                            Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                        }
                        if (D < 0)
                            Console.WriteLine("Нет корней");
                    }
                    else
                    {
                        x1 = 0;
                        x2 = -c / b;
                        Console.WriteLine("Корни уравнения :" + "\nx1 = " + x1);
                        Console.WriteLine("x2 = " + x2);
                    }
                }
                if (a == 0 && b == 0 && c != 0)
                {
                    x1 = -d / c;
                    Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                }
                if (b == 0 && c == 0 && a != 0)
                {
                    if (d == 0)
                    {
                        x1 = 0;
                        Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                    }
                    else
                    {
                        x1 = Math.Pow((-d / a), 1.0 / 3.0);
                        Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                    }

                }
                if (a != 0 && b != 0 && d != 0 && d == 0)
                {

                }
                if (a == 0 && c == 0 && b != 0)
                {
                    if (d == 0)
                    {
                        x1 = 0;
                        Console.WriteLine("Корень уравнения :" + "\nx1 = " + x1);
                    }
                    else
                    {
                        if (-d / b < 0)
                            Console.WriteLine("Нет корней");
                        else
                        {
                            x1 = Math.Sqrt(-d / b);
                            x2 = -Math.Sqrt(-d / b);
                            Console.WriteLine("Корни уравнения :" + "\nx1 = " + x1);
                            Console.WriteLine("x2 = " + x2);
                        }
                    }
                }
                if (a == 0 && b == 0 && c == 0)
                {
                    if (d == 0)
                        Console.WriteLine("Нет корней");
                    else
                        Console.WriteLine("Нет корней");

                }
                if (a != 0 && b != 0 && c != 0 && d != 0 || a != 0 && b == 0 && c != 0 && d != 0)
                {
                    b /= a;
                    c /= a;
                    d /= a;
                    double x22;
                    double x33;
                    double Q = (Math.Pow(b, 2) - 3 * c) / 9;
                    double R = (2 * Math.Pow(b, 3) - 9 * b * c + 27 * d) / 54;
                    double S = Math.Pow(Q, 3) - Math.Pow(R, 2);

                    if (S < 0.001 && S > -0.001)
                        S = 0;

                    if (S > 0)
                    {
                        double g = R / (Math.Sqrt(Math.Pow(Q, 3)));
                        double F = 1.0 / 3.0 * (Math.Acos(g));
                        x1 = -2 * Math.Sqrt(Q) * Math.Cos(F) - (b / 3);
                        Console.WriteLine("x1 = " + Math.Round(x1) + "\n");
                        x2 = -2 * Math.Sqrt(Q) * Math.Cos(F + (2 * 3.14 / 3)) - (b / 3);
                        Console.WriteLine("x2 = " + x2 + "\n");
                        x3 = -2 * Math.Sqrt(Q) * Math.Cos(F - (2 * 3.14 / 3)) - (b / 3);
                        Console.WriteLine("x3 = " + x3 + "\n\n");
                    }
                    if (S < 0)
                    {
                        if (Q > 0)
                        {
                            double g = Math.Abs(R) / (Math.Sqrt(Math.Pow(Q, 3)));
                            double F = 1.0 / 3.0 * Math.Log(g + Math.Sqrt(Math.Pow(g, 2) - 1));
                            x1 = -2 * Math.Sign(R) * Math.Sqrt(Q) * ((Math.Pow(2.71, F) + Math.Pow(2.71, -F)) / 2) - b / 3;
                            x2 = Math.Sign(R) * Math.Sqrt(Q) * ((Math.Pow(2.71, F) + Math.Pow(2.71, -F)) / 2) - b / 3;
                            x22 = Math.Sqrt(3) * Math.Sqrt(Q) * ((Math.Pow(2.71, F) - Math.Pow(2.71, -F)) / 2);
                            x3 = Math.Sign(R) * Math.Sqrt(Q) * ((Math.Pow(2.71, F) + Math.Pow(2.71, -F)) / 2) - b / 3;
                            Console.WriteLine("x1 = " + Math.Round(x1) + "\n");
                            Console.WriteLine("x2 = " + x2 + "+" + x22 + "i" + "\n");
                            Console.WriteLine("x3 = " + x3 + "-" + x22 + "i" + "\n\n");
                        }
                        if (Q < 0)
                        {
                            double g = Math.Abs(R) / (Math.Sqrt(Math.Pow(Math.Abs(Q), 3)));
                            double F = 1.0 / 3.0 * Math.Log(g + Math.Sqrt(Math.Pow(g, 2) + 1));
                            x1 = -2 * Math.Sign(R) * Math.Sqrt(Math.Abs(Q)) * ((Math.Pow(2.71, F) - Math.Pow(2.71, -F)) / 2) - b / 3;
                            x2 = Math.Sign(R) * Math.Sqrt(Math.Abs(Q)) * ((Math.Pow(2.71, F) - Math.Pow(2.71, -F)) / 2) - b / 3;
                            x33 = Math.Sqrt(3) * Math.Sqrt(Math.Abs(Q)) * ((Math.Pow(2.71, F) + Math.Pow(2.71, -F)) / 2);
                            x3 = Math.Sign(R) * Math.Sqrt(Math.Abs(Q)) * ((Math.Pow(2.71, F) - Math.Pow(2.71, -F)) / 2) - b / 3;

                            Console.WriteLine("x1 = " + Math.Round(x1) + "\n");
                            Console.WriteLine("x2 = " + x2 + "+" + x33 + "i" + "\n");
                            Console.WriteLine("x3 = " + x3 + "-" + x33 + "i" + "\n\n");
                        }
                    }
                    if (S == 0)
                    {
                        x1 = -2 * Math.Sign(R) * Math.Sqrt(Q) - b / 3;
                        x2 = Math.Sign(R) * Math.Sqrt(Q) - b / 3;
                        Console.WriteLine("x1 = " + Math.Round(x1) + "\n");
                        Console.WriteLine("x2 = " + Math.Round(x2) + "\n\n");
                    }
                }
            }
        }
    }
}