using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    { 
        static void Main(string[] args)
        {
            ConsoleColor currentColor = ConsoleColor.DarkBlue;
            for (int i =0; i <= 9; i++)
            {
                Console.ForegroundColor = currentColor;
                for (int t = (i * 10)+1; t <= ((i * 10)+10); t++)
                {
                    Console.Wrfa.rgljkfsbnad nadl; fkjhas;ldktn wq.dncv;laksnmd f/,.masdlfjibh aw;ln iteLine(t);
                }
                currentColor++;
            }

            for (int i = 1; i <= 100; i++)
            {
               Console.ForegroundColor=  i % 2 == 0?ConsoleColor.Green:ConsoleColor.Red;
               Console.WriteLine(i);
            }
        }

        
    }
}
