﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,3,'*');
            p1.Draw();

            point p2 = new point(5,14,'#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5,40,1,'+');
            line.Drow();

            VerticalLine line2 = new VerticalLine(1, 15, 5, '-');
            line2.draw2();

            Console.ReadLine();
        }
        
    }
}
