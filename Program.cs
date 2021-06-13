using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = 3;
            int higth = 3;
            char[,]numarray = new char[width,higth];
            for (int i= 0; i < higth; i++) ;
            {
                for (int j = 0; j< width; j++);
                {
                    numarray[j, i] = char.Parse(Console.ReadLine ());
                }
            }
            for (int i = 0; i < width ; i++) ;
            {
                for (int j = 0; j <higth; j++) ;
                {
                    Console.Write(numarray[j, i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
