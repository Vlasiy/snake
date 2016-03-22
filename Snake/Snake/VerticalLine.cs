using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point pl = new Point(x, y, sym);
                pList.Add(pl);
            }
        }

        public void Drow()
        {
            foreach (Point pl in pList)
            {
                pl.Draw();
            }
        }
    }
}