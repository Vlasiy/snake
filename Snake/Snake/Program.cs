using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '+');
            p1.Draw();

            Point p2 = new Point(4, 5, '-');
            p2.Draw();

            Point p3 = new Point(6, 7, '$');
            p3.Draw();

            Point p4 = new Point(2, 8, '#');
            p4.Draw();

            List<char> numList = new List<char>();
            numList.Add('-');
            numList.Add('+');
            numList.Add('#');

            char x = numList[0];
            char y = numList[1];
            char z = numList[2];

            foreach (char i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(2);

            List<Point> plist = new List<Point>();

            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);

            Console.ReadLine();
        }
    }
}
