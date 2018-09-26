using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path) //We can write to the console from here
        {
            string file = File.ReadAllText(@"D:\datamatiker\SmartMenu\SmartMenuLibrary\" + path);           
                        
            string[] MenuSpecsArray = file.Split(';');
            string clean = "";
            for (int i = 0; i < MenuSpecsArray.Length; i++)
            {
                clean = Regex.Replace(MenuSpecsArray[i], "[^A-Z a-z 0-9 ]", "");
                Console.WriteLine(clean);
            }
            Console.ReadKey();
            
        }
        public void Activate() //We can write to the console from here
        {
            
        }
    }
}
