using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number from 0-3 th choose the following menu:");
            Console.WriteLine("[0]Show all recent files");
            Console.WriteLine("[1]Open new file");
            Console.WriteLine("[2]Open recent file");
            Console.WriteLine ("[3]Exit");
            
            Console.Write("Your select : ");
            string menu = Console.ReadLine();

            StreamWriter file = null;
            file = null;
            string filename = @"textfile.tet";
            string line = null;

            Console.Write("enter your message :: ");
            line = Console.ReadLine();
            file.WriteLine(line);

            try
            {
                if (menu == "0")
                {
                    file = new StreamWriter(filename);

                }
                else if (menu == "1")
                {
                    file = File.AppendText(filename);
                }

                else if (menu == "2")
                {
                    file = File.CreateText(filename);
                }
                else if (menu == "3")
                {
                    file.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("No recent file.");
            }
            finally
            {
                if(file != null)
                {
                    file.Close();
                }
            }

            file.Close();

      

        }
    }
}
