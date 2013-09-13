using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace HelloWorld
{

    public class Yoyo
    {
        int x = 5,
            y = 5,
            numTimes = 10,
            maxLength = 10,
            currentLength = 0;
        bool isGoingDown = true;
        public Yoyo(int xPos = 5, int yPos = 5, int numTimes = 1)
        {
            x = xPos;
            y = yPos;
            this.numTimes = numTimes;
        }

        public void Update()
        {
            if (isGoingDown)
            {
                currentLength++;
                if (currentLength == maxLength)
                {
                    isGoingDown = false;
                }
            }
            else
            {
                currentLength--;
                if (currentLength == 0)
                {
                    isGoingDown = true;
                }
            }
        }
        public void Draw()
        {

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 10;
            int maxLength = 5;
            for (int times = 0; times < 5; times++)
            {
                for (int i = 0; i < maxLength; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + i + 1);
                    Console.Write("0");
                    Thread.Sleep(100);
                }

                for (int i = maxLength; i >= 0; i--)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + i + 1);
                    Console.Write("0");
                    Console.SetCursorPosition(x, y + i + 2);
                    Console.Write(" ");
                    Thread.Sleep(100);
                }
                Thread.Sleep(300);
            }  
        }
    }
}
