using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ToDo
{
    class Menus
    {
        //Skriver ut Loggan från en textfil
        public static void LogoPrint() 
        {
            string[] lines = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ToDo\logo.txt");

            foreach (string line in lines)
            {
                Console.WriteLine(line);

            }
        }
        public static void StartMenu()
        {

            LogoPrint();
            Console.WriteLine("  ----------------------");
            Console.WriteLine("Hantera dina ToDolistor på ett smidigt sätt med ToDO");
        }
    }
}
