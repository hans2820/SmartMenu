using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class Bindings
    {
        public string call(int number)
        {
            switch (number)
            {
                case 1:
                    return Functions.DoThat();
                    
                case 2:
                    return Functions.DoThis();
                    
                case 3:
                    return Functions.DoSomething(Console.ReadLine());
                    
                case 4:
                   return Functions.GetTheAnswerToLifeTheUniverseAndEverything().ToString();                    
            }
            return "Du kan kun vælge tal der er vist i menuen";
        }
        public void exit()
        {
            Environment.Exit(0);
        }
    }
}
