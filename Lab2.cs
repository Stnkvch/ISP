
using System;
namespace ConsoleApp3
{
    class lab2
    {
        static ulong a, b;
        static void Main(string[] args)
        {
            ulong counter = 1, v;
            bool check0 = false;
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;

            while (!check)
            {
                Console.WriteLine("Введите a:");
                try
                {
                    check = true;
                    a = Convert.ToUInt64(Console.ReadLine());
                }
                catch
                {
                    check = false;
                    check0 = false;
                    Console.WriteLine("Введен неверный символ, введите число!\n\n");

                }
            }
            while (!check1)
            {


                Console.WriteLine("Введите b:");
                try
                {
                    check1 = true;
                    b = Convert.ToUInt64(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Введен неверный символ, введите число!\n");
                    check1 = false;
                    check0 = false;
                }
            }
            while (!check0)
            {
                while (!check2)
                {
                    if (a > b && b != 0)
                    {
                        Console.WriteLine("Повторно введите числа, а должно быть меньше b\n");
                        Console.WriteLine("Введите a:");
                        a = Convert.ToUInt64(Console.ReadLine());
                        Console.WriteLine("Введите b:");
                        b = Convert.ToUInt64(Console.ReadLine());
                        check2 = false;
                        check0 = false;
                    }
                    if (a == 0 || b == 0 || a == 0 && b == 0)
                    {
                        Console.WriteLine("Повторно введите числа, а и b должны быть больше нуля\n");
                        Console.WriteLine("Введите a:");
                        a = Convert.ToUInt64(Console.ReadLine());
                        Console.WriteLine("Введите b:");
                        b = Convert.ToUInt64(Console.ReadLine());
                        check2 = false;
                        check0 = false;
                    }
                    else
                    {
                        check2 = true;
                        check0 = true;
                    }
                }

            }


            v = a;
            if (a == 1)
                for (ulong i = 1; i <= b; i++)
                {
                    if (i >= a)
                    {
                        v *= i;
                    }
                }
            else
                for (ulong i = 1; i < b; i++)
                {
                    if (i >= a)
                    {
                        v *= i + 1;
                    }
                }
            if (v == 0)
            {
                Console.WriteLine("Число слишком большое");
            }
            else
            {
                for (ulong i = 1; i <= counter; i++)
                {
                    if (v % Math.Pow(2, counter) == 0)
                        counter++;
                }
                Console.WriteLine("\nМаксимальная степень двойки равна : " + (counter - 1));
            }
        }
    }
}

using System;
namespace lab_2

{
    class Lab2
    {
        static void Main(string[] args)

        {

            int count0 = 0,
            count1 = 0,
            count2 = 0,
            count3 = 0,
            count4 = 0,
            count5 = 0,
            count6 = 0,
            count7 = 0,
            count8 = 0,
            count9 = 0;

            DateTime data1 = new DateTime();
            data1 = DateTime.Now;
            string num = data1.ToString();
            Console.WriteLine(data1.ToLongDateString() + "\n");
            DateTime now = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\n{0:dddd dd MMMM yyyy HH:mm:ss:fff}", now);

            for (int i = 0; i < num.Length; i++)

            {
                if (num[i] == '0')
                    count0++;
                if (num[i] == '1')
                    count1++;
                if (num[i] == '2')
                    count2++;
                if (num[i] == '3')
                    count3++;
                if (num[i] == '4')
                    count4++;
                if (num[i] == '5')
                    count5++;
                if (num[i] == '6')
                    count6++;
                if (num[i] == '7')
                    count7++;
                if (num[i] == '8')
                    count8++;
                if (num[i] == '9')
                    count9++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Количество 0: " + count0);
            Console.WriteLine("Количество 1: " + count1);
            Console.WriteLine("Количество 2: " + count2);
            Console.WriteLine("Количество 3: " + count3);
            Console.WriteLine("Количество 4: " + count4);
            Console.WriteLine("Количество 5: " + count5);
            Console.WriteLine("Количество 5: " + count6);
            Console.WriteLine("Количество 7: " + count7);
            Console.WriteLine("Количество 8: " + count8);
            Console.WriteLine("Количество 9: " + count9);

            Console.ReadKey();
        }
    }
}




using System;
namespace Lab2

{
    class Program

    {
        static double a, b, c;
        static void Main(string[] args)
        {
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;

            while (!check3)
            {
                while (!check)
                {
                    Console.WriteLine("Введите a:");
                    try
                    {
                        check = true;
                        a = Convert.ToUInt64(Console.ReadLine());
                    }
                    catch
                    {
                        check = false;
                        Console.WriteLine("Введен неверный символ, введите число!\n\n");

                    }
                }
                while (!check1)
                {


                    Console.WriteLine("Введите b:");
                    try
                    {
                        check1 = true;
                        b = Convert.ToUInt64(Console.ReadLine());
                    }
                    catch
                    {

                        Console.WriteLine("Введен неверный символ, введите число!\n");
                        check1 = false;
                    }
                }
                while (!check2)
                {


                    Console.WriteLine("Введите c:");
                    try
                    {
                        check2 = true;
                        c = Convert.ToUInt64(Console.ReadLine());
                    }
                    catch
                    {

                        Console.WriteLine("Введен неверный символ, введите число!\n");
                        check2 = false;
                    }
                }
                if (a + b <= c || a + c <= b || c + b <= a)
                {
                    check3 = false;
                    check2 = false;
                    check1 = false;
                    check = false;
                    Console.WriteLine("Данные стороны не составляют треугольник!\n");
                }
                else
                    check3 = true;
            }

            double P = a + b + c;
            double p = (a + b + c) / 2.0;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double r = S / p;
            double R = (a * b * c) / (4 * S);
            double sinA = a / (2 * R);
            double sinB = b / (2 * R);
            double sinC = c / (2 * R);
            double ha = 2 * S / a;
            double hb = 2 * S / b;
            double hc = 2 * S / c;
            Console.WriteLine("Периметр = " + P + " cm");
            Console.WriteLine("Площадь = " + S + " cm^2");
            Console.WriteLine("Радиус вписанной окружности = " + r + " cm");
            Console.WriteLine("Радиус описанной окружности = " + R + " cm");
            Console.WriteLine("sinA = " + sinA + "\nsinB = " + sinB + "\nsinC = " + sinC);
            Console.WriteLine("Высота проведенная к стороне а = " + ha + " cm");
            Console.WriteLine("Высота проведенная к стороне b = " + hb + " cm");
            Console.WriteLine("Высота проведенная к стороне c = " + hc + " cm");
        }
    }
}
