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
            Console.SetBufferSize(80, 25);

            
            
            //отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            // отрисовка точек
           // Point p1 = new Point(1, 3, '*');
           // p1.Draw();

            Point p = new Point(4, 5, '*');
            // p.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
            Console.ReadLine();
        }

        
    }
}
