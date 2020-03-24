using System;
using System.Collections.Generic;

namespace Test_path_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример ввода

            var start = new IntPoint() { X = 0, Y = 0};
            var end = new IntPoint() { X = 113000, Y = 85000 };

            var p1 = new IntPoint() { X = 37000, Y = 27000};
            var p2 = new IntPoint() { X = 37000, Y = 67000 };
            var p3 = new IntPoint() { X = 95000, Y = 67000 };
            var p4 = new IntPoint() { X = 95000, Y = 27000 };

            var rect = new List<IntPoint> {p1, p2, p3, p4};


            //Результат записать в path
            var path = new List<Segment>();

        }
    }
}
