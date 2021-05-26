using System;
using System.Collections.Generic;
using System.Text;

namespace Lr7
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber num1 = new RationalNumber(28, 56);
            RationalNumber num2 = new RationalNumber(10, -8);
            RationalNumber num3 = new RationalNumber(11, 5);
            RationalNumber num4 = new RationalNumber(34, 17);
            RationalNumber[] rationalNumbers = new RationalNumber[] { num1, num2, num3, num4 };

            foreach (RationalNumber i in rationalNumbers)
            {
                RationalNumber.reduceFraction(i);
            }

            Array.Sort(rationalNumbers);
            foreach (RationalNumber i in rationalNumbers)
            {
                RationalNumber.getType(i, "in decimal");
            }

            Console.WriteLine();

            Console.WriteLine(num1 > num2);
            Console.WriteLine(num4 < num3);
            Console.WriteLine(num4 == num3);
            Console.WriteLine(num2.Equals(num4));
            Console.WriteLine(num4.Equals(num3));
            Console.WriteLine();

            RationalNumber rationalNumber = new RationalNumber();

            rationalNumber = num1 + num2;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();

            rationalNumber = num1 - num2;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();

            rationalNumber = num1 * num2;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();

            rationalNumber = num1 / num2;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();

            num1++;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(num1, "with fractions");
            Console.WriteLine();

            num1--;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(num1, "with fractions");
            Console.WriteLine();

            rationalNumber = num1 + 10;
            RationalNumber.reduceFraction(rationalNumber);
            RationalNumber.getType(rationalNumber, "with fractions");
            Console.WriteLine();

            int buf1;
            double buf2;
            buf1 = num1;
            Console.WriteLine(buf1);
            buf2 = (double)num1;
            Console.WriteLine(buf2 + "\n");

            Console.WriteLine(num1.ToString("in decimal"));
            Console.WriteLine(num1.ToString("with fractions"));
            Console.WriteLine();

            RationalNumber num = new RationalNumber();
            string str = "99/17";
            num2 = (RationalNumber)str;
            RationalNumber.getType(num2, "with fractions");
            Console.WriteLine();

            string inputStr = Console.ReadLine();
            string[] rationalNumbers1 = inputStr.Split(' ');
            List<RationalNumber> listNumbers = new List<RationalNumber>();
            RationalNumber.processStr(rationalNumbers1, listNumbers);
            foreach (RationalNumber i in listNumbers)
            {
                Console.WriteLine(i.ToString("in decimal"));
            }
        }
    }
}
