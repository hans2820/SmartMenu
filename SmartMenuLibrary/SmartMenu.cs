using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path) //vi kan skrive i consolen herfra
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\datamatiker\SmartMenu\SmartMenuLibrary\" + path); 
            Console.WriteLine("Hello world");
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
