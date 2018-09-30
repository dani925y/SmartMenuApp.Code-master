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
            string line;
            int counter = 0;

            Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");

            //char menuinput er character input - det som bliver indskrevet
            char menuInput;
            char menuInputEN;
            char menuInputDK;

            menuInput = char.Parse(Console.ReadLine());

            //vælger punkt 1
            if (menuInput == '1')
            {
                //indlæser engelsk tekstfil med metoder vi lærte i mandags
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:..\..\MenuSpec.txt");

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                menuInputEN = char.Parse(Console.ReadLine());

                //herunder vælger den hvad outputtet er alt efter hvad indputtet er

                //indputtet er 1 og outputter er dothis fra functions - lige nu looper den bare for evigt though lol
                if (menuInputEN == '1')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThis());
                    Console.ReadLine();
                }

                if (menuInputEN == '2')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThat());
                    Console.ReadLine();
                }

                if (menuInputEN == '3')
                {
                    Console.Clear();
                    //den her skal have et string indput for at fungere, derfor er der først defineret en string som læser det som man indtaster 
                    string doSomethingInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomethingInput));
                    Console.ReadLine();
                }

                if (menuInputEN == '4')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.ReadLine();
                }

                if (menuInputEN == '0')
                {
                    Console.Clear();
                    //afslutter programmet
                    Environment.Exit(0);
                    Console.ReadLine();
                }
            }

            //præcis det samme som øverst, bare repeat på dansk
            if (menuInput == '2')
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:..\..\MenuSpecDA.txt");

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                menuInputDK = char.Parse(Console.ReadLine());

                if (menuInputDK == '1')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThis());
                    Console.ReadLine();
                }

                if (menuInputDK == '2')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThat());
                    Console.ReadLine();
                }

                if (menuInputDK == '3')
                {
                    Console.Clear();
                    string doSomethingInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomethingInput));
                    Console.ReadLine();
                }

                if (menuInputDK == '4')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.ReadLine();
                }

                if (menuInputDK == '0')
                {
                    Console.Clear();
                    Environment.Exit(0);
                    Console.ReadLine();
                }


                if (menuInput == '0')
                {
                    Console.Clear();
                    Environment.Exit(0);
                    Console.ReadLine();
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
