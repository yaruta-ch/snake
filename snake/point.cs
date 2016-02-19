﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;
        public point()
        {

        }
        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;

        }
        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                x = x + offset;
            }
            else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Up)
            {
                y = y - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;

        }
    }
}
