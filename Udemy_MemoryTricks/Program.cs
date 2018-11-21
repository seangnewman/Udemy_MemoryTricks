using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_MemoryTricks
{
    class Program
    {

        public class Line
        {
            public int X1;
            public int X2;
            public int Y1;
            public int Y2;

            public Line(int x1, int y1, int x2, int y2)
            {
                this.X1 = x1;
                this.Y1 = y1;
                this.X2 = x2;
                this.Y2 = y2;
            }
        }
        private static void DrawLine(int x1, int y1, int x2, int y2)
        {
            // TODO put line drawing code here
        }
        private static void DrawSquare(int x, int y, int w, int h)
        {
            int xw = x + w;
            int yh = y + h;

            DrawLine(x, y, xw, y);
            DrawLine(x, y, xw, y);
            DrawLine(x, y, xw, y);
            DrawLine(x, y, xw, y);
        }
    

        public class MainClass
        {
            private static void DrawPolygon(Line[] lines)
            {
                // TODO : polygon drawing code
            }

            private static void DrawSquare(int x, int y, int w, int h)
            {
                int xw = x + w;
                int yh = y + h;

                Line[] lines = new Line[4];

                lines[0] = new Line(x, y, xw, y);
                lines[1] = new Line(xw, y, xw, yh);
                lines[2] = new Line(xw, yh, x, yh);
                lines[3] = new Line(x, yh, x, y);

                DrawPolygon(lines);
                
            }
        }
    

    
        static void Main(string[] args)
        {
            //ReferenceAndValueTypes();

            //BoxingAndUnboxing();

            //FinalizerDemo();

            DisposePattern.Demo();
        }

        private static void FinalizerDemo()
        {
            int count = 0;

            while (!Console.KeyAvailable)
            {
                new MyObject(count++);
            }
            Console.WriteLine("Terminating process");
        }

        private static void BoxingAndUnboxing()
        {
            int a = 1234;
            object b = a;
            int c = (int)b;

            Console.WriteLine(c);
        }

        private static void ReferenceAndValueTypes()
        {
            Console.WriteLine("Going to draw a square...");
            DrawSquare(100, 100, 50, 50);
            Console.WriteLine("All done!");
        }
    }
}
