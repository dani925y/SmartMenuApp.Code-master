﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            Console.WriteLine("Choose Language");
            Console.WriteLine("1. Dansk");
            Console.WriteLine("2. English");
            Console.WriteLine("0. Exit");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "1":
                    goto danskMenu;
                    break;
                case "2":
                    goto englishMenu;
                    break;
            }






            Console.WriteLine("1. Punkt");
            Console.WriteLine("2. Punkt");
            Console.WriteLine("3. Punkt");
            Console.WriteLine("4. Punkt");
            Console.WriteLine("5. Tilbage til sporg valg");
            Console.WriteLine("0. Exit");
            string menuChoiceDK = Console.ReadLine();


            Console.WriteLine("1. Punkt");
            Console.WriteLine("2. Punkt");
            Console.WriteLine("3. Punkt");
            Console.WriteLine("4. Punkt");
            Console.WriteLine("5. Back to first menu");
            Console.WriteLine("0. Exit");
            string menuChoiceEN = Console.ReadLine();
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
