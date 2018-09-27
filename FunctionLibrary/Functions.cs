using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class Functions
    {
        public static string DoThis()
        {
            return "it just works";
        }
        public static string DoThat()
        {
            return "It just keeps working";
        }
        public static string DoSomething(string something)
        {
            if (string.IsNullOrEmpty(something))
                Console.WriteLine("it keeps on working and working");

            return "Result from doing: " + something;
        }
        public static int GetTheAnswerToLifeTheUniverseAndEverything()
        {
            return 42;
        }
    }
}
