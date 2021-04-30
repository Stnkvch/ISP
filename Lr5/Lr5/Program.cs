using System;

namespace Lr5
{
    struct Person
    {
        public string name;
        public int age;
    }

    class Program
    {
        static int Switcher;

        public static void ShowPerson(Person person)
        {
            Console.WriteLine($"name:{person.name}");
            Console.WriteLine($"age:{person.age}");
        }
        static void Main(string[] args)
        {
            Person person = new Person();
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
                        Console.WriteLine("Вы ввели неверное значение");
                    }
                }
                switch (Switcher)
                {
                    case 1:
                        Football BobF = new Football();
                        Sportsmen.FillInfo(BobF);
                        BobF.AddLevel();
                        do
                        {
                            Console.WriteLine("1-Throw\n2-training\n3-info");
                            Switcher = Convert.ToInt32(Console.ReadLine());
                            switch (Switcher)
                            {
                                case 1: BobF.Throw(); bolean = false; break;
                                case 2: BobF.Training(); bolean = false; break;
                                case 3: Sportsmen.ShowInfo(BobF); bolean = false; break;
                                default: Console.WriteLine("Вы ввели неверное значение"); break;
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
                            Console.WriteLine("1-Throw\n2-training\n3-info");
                            Switcher = Convert.ToInt32(Console.ReadLine());
                            switch (Switcher)
                            {
                                case 1: BobB.Throw(); bolean = false; break;
                                case 2: BobB.Training(); bolean = false; break;
                                case 3: Sportsmen.ShowInfo(BobB); bolean = false; break;
                                default: Console.WriteLine("Вы ввели неверное значение"); break;
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
