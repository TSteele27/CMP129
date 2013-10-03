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
            currentNumTimes = 0;
        protected int maxLength = 10,
                      currentLength = 0;
        bool isGoingDown = true;
        ConsoleColor yoyoColor = ConsoleColor.Blue;
        

        public Yoyo(int xPos = 5, int yPos = 5, int numTimes = 1,int length =5, ConsoleColor color = ConsoleColor.Blue)
        {
            x = xPos;
            y = yPos;
            this.numTimes = numTimes;
            maxLength = length;
            yoyoColor = color;
        }

        public virtual void Update()
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
                    currentNumTimes++;
                    isGoingDown = true;
                }
            }
        }
        public void Draw()
        {
            Console.ForegroundColor = yoyoColor;
            for (int i = 0; i < currentLength; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");
            }
            Console.SetCursorPosition(x, y + currentLength);
            Console.Write("0");
            Console.SetCursorPosition(x, y + currentLength + 1);
            Console.Write(" ");


        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            Random ran =new Random();
            List<Yoyo> yoyos = new List<Yoyo>();
            //TrickYoyo tyoyo = new TrickYoyo(5, 20, 5, 10, 10, ConsoleColor.Green);
            for (int i = 0; i < 10; i++)
            {
                yoyos.Add(new Yoyo(5 + i, 5, ran.Next(3,15),ran.Next(3,15), (ConsoleColor)i));
            }

            //yoyos.Add(tyoyo);

            while (true)
            {
                bool finished = true;
                foreach (var yoyo in yoyos)
                {
                    yoyo.Update();
                    yoyo.Draw();

                }
                Thread.Sleep(100);
                if (finished) break;
            }
            
            Thread.Sleep(2000);

        }
    }
}
