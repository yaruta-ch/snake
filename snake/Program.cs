using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            //отрисовка рамки
            HorizontalLine upline = new HorizontalLine(1, 78, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(1, 78, 24, '+');
            downline.Drow();

            VerticalLine Rline = new VerticalLine(0, 24, 1, '+');
            Rline.Drow();
            VerticalLine Lline = new VerticalLine(0, 24, 78, '+');
            Lline.Drow();

            //отрисовка точек
           
            point p = new point(5,5,'*');
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Drow();
            for (int a=0; a< 25; a++) { 
            snake.Move();
            Thread.Sleep(300);
            }



            Console.ReadLine();
        }
        
    }
}
