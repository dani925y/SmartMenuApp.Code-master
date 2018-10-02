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
            System.IO.StreamReader file = 
                new System.IO.StreamReader(@"..\..\MenuSpec.txt");
        }

        public void Activate()
        {
            string line;
            int counter = 0;

            Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");

            char menuInput;
            char menuInputEN;
            char menuInputDK;

            menuInput = char.Parse(Console.ReadLine());

            while (menuInput == '1')
            {
                Console.Clear();
                System.IO.StreamReader file = 
                       new System.IO.StreamReader(@"..\..\MenuSpec.txt");

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                menuInputEN = char.Parse(Console.ReadLine());

                if (menuInputEN == '1')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThis());
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                else if (menuInputEN == '2')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThat());
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                else if (menuInputEN == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Do something");
                    string doSomethingInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomethingInput));
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                else if (menuInputEN == '4')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.WriteLine("\nPress enter to go back");
                    Console.ReadLine();
                }

                else if (menuInputEN == '5')
                {
                    Console.Clear();
                    Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");
                    menuInput = char.Parse(Console.ReadLine());
                }

                else if (menuInputEN == '0')
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }

            while (menuInput == '2')
            {
                Console.Clear();
                System.IO.StreamReader file = 
                    new System.IO.StreamReader(@"..\..\MenuSpecDA.txt");

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

                else if (menuInputDK == '2')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.DoThat());
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                else if (menuInputDK == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Gør noget");
                    string doSomethingInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomethingInput));
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                else if (menuInputDK == '4')
                {
                    Console.Clear();
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    Console.WriteLine("\nTryk enter for at gå tilbage");
                    Console.ReadLine();
                }

                else if (menuInputDK == '5')
                {
                    Console.Clear();
                    Console.WriteLine("For english press 1 and enter - for dansk tryk 2 og enter - 0 for exit ");
                    menuInput = char.Parse(Console.ReadLine());
                }

                else if (menuInputDK == '0')
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
        }
    }
}
