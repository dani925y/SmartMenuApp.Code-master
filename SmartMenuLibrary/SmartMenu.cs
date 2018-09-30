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
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:..\..\MenuSpec.txt");
        }
        public void Activate()
        {
            Console.WriteLine("Choose Language/Vælg Sprog - Press 1 for english - Tast 2 for dansk");
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
                    Functions.DoThat();
                    break;
                case "3":
                    Functions.DoSomething();
                    break;
                case "4":
                    Functions.GetTheAnswerToLifeTheUniverseAndEverything();
                    break;
                case "5":
                    LoadMenu();
                    break;
                case "0":
                    return;
            }

        }// Husk at kigge på tekstens farve ændring
    }
}
