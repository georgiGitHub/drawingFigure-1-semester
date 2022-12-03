using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Square_draw
    {
        public float A { get; set; }
        public Point Location { get; set; }
        public void Paint(Graphics graphics)
        {
            using (var pen = new Pen(Color.Blue, 2))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, A, A);
                graphics.DrawLine(pen, Location.X, Location.Y, Location.X + A, Location.Y + A);
            }
        }
        public bool Contains(Point point)
        {
            return
                Location.X < point.X && point.X < Location.X + A;
        }
    }
}
