﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lr5
{
    class Sportsmen : IInfo
    {
        enum level
        {
            low, strong, expert
        }

        private string LevelS;

        public int Energy = 100;
        private string name;
        private int age;
        private int weight;
        private string club;
        static bool check1 = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Club
        {
            get { return club; }
            set { club = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public static void FillInfo(Sportsmen Bob)
        {
            Console.WriteLine("Enter Name: ");
            Bob.Name = Console.ReadLine();
            while (!check1)
            {
                try
                {
                    Console.WriteLine("Enter Age: ");
                    Bob.Age = Convert.ToInt32(Console.ReadLine());
                    check1 = true;
                }
                catch
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }
            }
            check1 = false;
            while (!check1)
            {
                try
                {
                    Console.WriteLine("Enter Weight: ");
                    Bob.Weight = Convert.ToInt32(Console.ReadLine());
                    check1 = true;
                }
                catch
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }
            }

            Console.WriteLine("Enter Club Name: ");
            Bob.Club = Console.ReadLine();
        }

        public static void ShowInfo(Sportsmen Bob)
        {
            Console.WriteLine($"\nName: {Bob.Name}\nAge: {Bob.Age}\nWeight: {Bob.Weight}\nClub name: {Bob.Club}\nEnergy: {Bob.Energy}\nLevel: {Bob.LevelS}");
        }

        
        
        public void AddLevel()
        {
            check1 = false;
            while (!check1)
            {
                Console.WriteLine("Enter Category\n0: low\n1: strong\n2: Expert");
                try
                {
                    int CategBuf = Convert.ToInt32(Console.ReadLine());
                    if (CategBuf >= 0 && CategBuf <= 2)
                    {
                        LevelS = ($"{Enum.GetName(typeof(level), CategBuf)}");
                        check1 = true;
                    }
                    else
                        throw new Exception("Введен неверный символ!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка:{ex.Message}");
                }
            }
          
            
         
        }
    }
}


