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
            // string selection = Console.ReadLine();
            int counter = 0;

            Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");

            //char menuinput er character input - det som bliver indskrevet
            char menuInput;
            char menuInputEN;
            char menuInputDK;

            menuInput = char.Parse(Console.ReadLine());

            //vælger punkt 1
            while (menuInput == '1')
            {
                Console.Clear();
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
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                if (menuInputEN == '2')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThat());
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                if (menuInputEN == '3')
                {
                    Console.Clear();
                    //den her skal have et string indput for at fungere, derfor er der først defineret en string som læser det som man indtaster
                    Console.WriteLine("Do something");
                    string doSomethingInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomethingInput));
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                if (menuInputEN == '4')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }
                if (menuInputEN == '5')
                {
                    Console.Clear();
                    Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");
                    menuInput = char.Parse(Console.ReadLine());
                }

                if (menuInputEN == '0')
                {
                    Console.Clear();
                    //afslutter programmet
                    Environment.Exit(0);
                }
            }

            //præcis det samme som øverst, bare repeat på dansk
            while (menuInput == '2')
            {
                Console.Clear();
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
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                if (menuInputDK == '2')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThat());
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                if (menuInputDK == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Gør noget");
                    string doSomethingInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomethingInput));
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                if (menuInputDK == '4')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                if (menuInputDK == '5')
                {
                    Console.Clear();
                    Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");
                    menuInput = char.Parse(Console.ReadLine());
                }

                if (menuInputDK == '0')
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
        }// Husk at kigge på tekstens farve ændring
    }
}
