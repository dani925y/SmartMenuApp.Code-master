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
            Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");

            char menuInput;
            menuInput = char.Parse(Console.ReadLine());
            string line;
            int counter = 0;
            char menuInputEN;
            menuInputEN = char.Parse(Console.ReadLine());
            char menuInputDK;
            menuInputDK= char.Parse(Console.ReadLine());

            while (menuInput == 1)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:..\..\MenuSpec.txt");
                while((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                        counter++;
                }

                while (menuInputEN == 1)
                {
                    Functions.DoThis();
                }

                while (menuInputEN == 2)
                {
                    Functions.DoThat();
                }

                while (menuInputEN == 3)
                {
                    string doSomethingInput = Console.ReadLine();
                    Functions.DoSomething(doSomethingInput);
                }

                while (menuInputEN == 4)
                {
                    Functions.GetTheAnswerToLifeTheUniverseAndEverything();
                }

                while (menuInputDK == 0)
                {
                    Environment.Exit(0);
                }
            }

            while (menuInput == 2)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:..\..\MenuSpecDA.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                while (menuInputDK == 1)
                {
                    Functions.DoThis();
                }

                while (menuInputDK == 2)
                {
                    Functions.DoThat();
                }

                while (menuInputDK == 3)
                {
                    string doSomethingInput = Console.ReadLine();
                    Functions.DoSomething(doSomethingInput);
                }

                while (menuInputDK == 4)
                {
                    Functions.GetTheAnswerToLifeTheUniverseAndEverything();
                }

                while (menuInputDK == 0)
                {
                    Environment.Exit(0);
                }
            

            while (menuInput == 0)
                {
                    Environment.Exit(0);
                }
            }


            //gamle kode som måske kan bruges til noget????
            /*Console.WriteLine("Choose Language/Vælg Sprog");
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
            }*/

        }// Husk at kigge på tekstens farve ændring
    }
}
