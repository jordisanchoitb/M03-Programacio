/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Repta Sierpiński triangle
 */

using System;
using System.Drawing;

namespace Program
{
    public class Program
    {
        private static readonly Point P1 = new Point(Console.WindowWidth / 2, 1);
        private static readonly Point P2 = new Point(1, Console.WindowHeight);
        private static readonly Point P3 = new Point(Console.WindowWidth, Console.WindowHeight);
        public static void Main()
        {
            DrawSierpinskiTriangle(10000);
            Console.ReadKey();
        }

        static void DrawSierpinskiTriangle(int interaciones)
        {
            var currentPoint = GetAleatoriPoint();
            drawpoint(currentPoint);

            for (int i = 0; i < interaciones; i++)
            {
                Point miidlePoint = CalculateMiddlePoint(currentPoint, GetAleatoriPoint());
                drawpoint(miidlePoint);
                currentPoint = miidlePoint;
            }

        }
        static void drawpoint(Point p)
        {
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write("*");
        }

        public static Point CalculateMiddlePoint(Point p1, Point p2)
        {
            int x = (p1.X + p2.X) / 2;
            int y = (p1.Y + p2.Y) / 2;

            return new Point(x, y);
        }
        public static Point GetAleatoriPoint()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 4);

            if (num == 1)
            {
                return P1;
            }
            else if (num == 2)
            {
                return P2;
            }
            else
            {
                return P3;
            }
        }
    }
}