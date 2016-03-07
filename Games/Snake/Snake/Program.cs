using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Game
    {
        static void Main(string[] args)
        {
            snake s = new snake(0, 0);
            ConsoleKeyInfo keyinfo;
            while (true)
            {
                keyinfo=Console.ReadKey();
               if (keyinfo.Key==ConsoleKey.Escape)
               {
                   break;
               }

               if (keyinfo.Key == ConsoleKey.UpArrow)
               {
                   s.moveUp(); 
               }

               if (keyinfo.Key == ConsoleKey.DownArrow)
               {
                   s.moveDawn();
               }

               if (keyinfo.Key == ConsoleKey.LeftArrow)
               {
                   s.moveLeft();
               }

               if (keyinfo.Key == ConsoleKey.RightArrow)
               {
                   s.moveRight();
               }

               Draw.draw(s);

            }

        }

       
    }

    struct snake
    {
        public int x;
        public int y;
        public snake(int x, int y)
        {
            this.x=x;
            this.y=y;
        }


        public void moveLeft()
        {
            this.x -= 5;
        }

        public void moveRight()
        {
            this.x += 5;
        }

        public void moveUp()
        {
            this.y += 5;
        }

        public void moveDawn()
        {
            this.y -= 5;
        }
    }

}
