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
            return "Result from DoThis1";
        }
        public static string DoThat()
        {
            return "Result from Do That";
        }
        public static string DoSomething(string something)
        {
            if (string.IsNullOrEmpty(something))
                throw new Exception("You need to specify something!");

            return "Result from doing: " + something;
        }
        public static int GetTheAnswerToLifeTheUniverseAndEverything()
        {
            return 42;
        }
    }
}
