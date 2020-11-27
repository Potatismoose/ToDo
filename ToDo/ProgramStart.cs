using System;
using System.IO;
using System.Threading;

namespace ToDo
{
    //Klassen som kör igång hela programmet och kontrollerar om filerna som behövs redan existerar
    class ProgramStart
    {
        //Deklarerar och tilldelar nödvändiga variabler dess värden
        static bool noLoop = default(bool);
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ToDo\";
        static string filename = "info.txt";
        static string logo = "logo.txt";






        //Metod för att kontrollera om nödvändiga filerna finns
        public static void CheckFiles()
        {
            do
            {
                //Om inte filerna finns så körs catch och mappstrukturen skapas
                try
                {
                    if (File.Exists(path + filename) == true && File.Exists(path + logo) == true)
                    {
                        //Om filerna finns finns ingen anledning att fortsätta loopen och vi hoppar ur den med en break.
                        break;
                    }
                    else
                    {
                        //Skapar filerna som behövs och lägger dessa i Mina Dokument under mappen ToDo
                        using (FileStream fs = File.Create($"{path}{filename}")) ;
                        using (FileStream fs = File.Create($"{path}{logo}")) ;

                        //SträngArray som skrivs till logo.txt
                        string[] logoPrint = {
                            "   _____        ___      ",
                            "  /__   \\___   /   \\___  ",
                            "    / /\\/ _ \\ / /\\ / _ \\ ",
                            "   / / | (_) / /_// (_) |",
                            "   \\/   \\___/___,' \\___/ "
                        };
                        //Skriver loggan till Documents\ToDo\logo.txt
                        using (StreamWriter file =
                        new StreamWriter($"{path}{logo}"))
                        {
                            foreach (string line in logoPrint)
                            {
                                file.WriteLine(line);
                            }
                        }
                        Console.WriteLine("Programmet körs för första gången, och det skapas nödvändiga filer.");
                        Console.WriteLine("Du hittar dina listor under Mina Dokument\\Todo\\Listor\\");
                        Thread.Sleep(5000);
                    }
                    noLoop = true;
                }
                //Om inte mappen ToDo hittas under mina dokument så skapas den här och loopen körs igen
                catch
                {
                    Directory.CreateDirectory(path);
                }
            } while (!noLoop);
            Menus.StartMenu();

        }
    }
}
