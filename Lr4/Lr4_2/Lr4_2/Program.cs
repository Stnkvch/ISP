using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lr4_2
{
    class Program
    {
        public const string CppFunctionsDll = @"C:\Users\denis\source\repos\Lr4_2\Debug\CppFunctions.dll";

        [DllImport(CppFunctionsDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
        [DllImport(CppFunctionsDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Subtract(int a, int b);
        [DllImport(CppFunctionsDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Multiply(int a, int b);
        [DllImport(CppFunctionsDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Dividing(int a, int b);


        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите а:");

            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введены неверные символы!");
                a = 7;
            }

            Console.WriteLine("Введите b:");

            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введены неверные символы!");
                b = 9;
            }

            Console.WriteLine($"a + b = { Add(a, b) }");       
            Console.WriteLine($"\na - b = { Subtract(a, b) }");          
            Console.WriteLine($"\na * b = { Multiply(a, b) }");    
            Console.WriteLine($"\na / b = {(double)Dividing(a, b) }");

            Console.ReadKey();
        }
    }
}