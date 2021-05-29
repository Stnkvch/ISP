using System;

namespace Lr5
{
    public delegate void EventDelegate();
    class Event
    {
        public event EventDelegate myEvent;

        public void Choose()
        {
            myEvent();
        }

    }

    interface ISport
    {
        void Training();
    }
    interface IInfo
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    class Program
    {
        public static void Sport_type()
        {
            if (Switcher == 1)
                Console.WriteLine("Вы выбрали футбол\n");
            else if (Switcher == 2)
                Console.WriteLine("Вы выбрали баскетбол\n");
            else if (Switcher == 3)
                Console.WriteLine("Вы выбрали плавание\n");
        }

        static int Switcher;

        static void Main(string[] args)
        {
            Event ev = new Event();
            ev.myEvent += Sport_type;
            bool bolean = true;
            bool check = false;
            Console.WriteLine("Choose:\n1-Football\n2-Bascetball\n3-Swiming");
            do
            {
                while (!check)
                {
                    try
                    {
                        Switcher = Convert.ToInt32(Console.ReadLine());
                       
                        check = true;
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели неверные символы");
                    }
                }
                ev.Choose();
                switch (Switcher)
                {
                    case 1:
                        Football BobF = new Football();
                        Sportsmen.FillInfo(BobF);
                        BobF.AddLevel();
                        do
                        {
                         
                            Console.WriteLine("\n1-Throw\n2-training\n3-info");
                            check = false;
                            while (!check)
                            {
                                try
                                {
                                    Switcher = Convert.ToInt32(Console.ReadLine());

                                    check = true;
                                }
                                catch
                                {
                                    Console.WriteLine("Вы ввели неверные символы");
                                }
                            }
                            switch (Switcher)
                            {
                                case 1: BobF.Throw(); bolean = false; break;
                                case 2: BobF.Training(); bolean = false; break;
                                case 3: Sportsmen.ShowInfo(BobF); bolean = false; break;
                                default: Console.WriteLine("Вы ввели неверное значение"); bolean = false; break;
                            }

                        } while (!bolean && BobF.Energy > 0);
                        Sportsmen.ShowInfo(BobF);
                        bolean = false; break;
                    case 2:
                        Bascet BobB = new Bascet();
                        Sportsmen.FillInfo(BobB);
                        BobB.AddLevel();
                        do
                        {
                            Console.WriteLine("\n1-Throw\n2-training\n3-info");
                            check = false;
                            while (!check)
                            {
                                try
                                {
                                    Switcher = Convert.ToInt32(Console.ReadLine());

                                    check = true;
                                }
                                catch
                                {
                                    Console.WriteLine("Вы ввели неверные символы");
                                }
                            }
                            switch (Switcher)
                            {
                                case 1: BobB.Throw(); bolean = false; break;
                                case 2: BobB.Training(); bolean = false; break;
                                case 3: Sportsmen.ShowInfo(BobB); bolean = false; break;
                                default: Console.WriteLine("Вы ввели неверное значение"); bolean = false; break;
                            }

                        } while (!bolean && BobB.Energy > 0);
                        Sportsmen.ShowInfo(BobB);
                        bolean = false; break;
                    case 3:
                        Swim BobS = new Swim();
                        Sportsmen.FillInfo(BobS);
                        BobS.AddLevel();
                        BobS.Training();
                        Sportsmen.ShowInfo(BobS);
                        bolean = false; break;
                    default: Console.WriteLine("Вы ввели неверное значение"); check = false; break;
                }
            } while (bolean);
        }
    }
}
