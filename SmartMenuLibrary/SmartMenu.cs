using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            Console.WriteLine("Choose Language/Vælg Sprog");
            Console.WriteLine("1. Dansk/Danish");
            Console.WriteLine("2. English/Engelsk");
            Console.WriteLine("0. Exit");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "1":
                    DanskMenu();
                    break;
                case "2":
                    EnglishMenu();
                    break;
                case "0":
                    return;
            }
        }

        public void DanskMenu()
        {
            Console.WriteLine("1. Punkt");
            Console.WriteLine("2. Punkt");
            Console.WriteLine("3. Punkt");
            Console.WriteLine("4. Punkt");
            Console.WriteLine("5. Tilbage til sporg valg");
            Console.WriteLine("0. Exit");
            string menuChoiceDK = Console.ReadLine();
            switch (menuChoiceDK)
            {
                case "1":
                    Functions.DoThis();
                    break;
                case "2":
                    Punkt2();
                    break;
                case "3":
                    Punkt3();
                    break;
                case "4":
                    Punkt4();
                    break;
                case "5":
                    LoadMenu();
                    break;
                case "0":
                    return;
            }

        }

        public void EnglishMenu()
        {
            Console.WriteLine("1. Punkt");
            Console.WriteLine("2. Punkt");
            Console.WriteLine("3. Punkt");
            Console.WriteLine("4. Punkt");
            Console.WriteLine("5. Back to first menu");
            Console.WriteLine("0. Exit");
            string menuChoiceEN = Console.ReadLine();
            switch (menuChoiceEN)
            {
                case "1":
                    Punkt1();
                    break;
                case "2":
                    Punkt2();
                    break;
                case "3":
                    Punkt3();
                    break;
                case "4":
                    Punkt4();
                    break;
                case "5":
                    LoadMenu();
                    break;
                case "0":
                    return;

            }
        }

        public void Activate()
        {
            // Implement ...
        }
    } // Husk at kigge på tekstens farve ændring
}
