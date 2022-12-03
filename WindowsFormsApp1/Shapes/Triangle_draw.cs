using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace WindowsFormsApp1
{
    class Triangle_draw
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public Point Location { get; set; }
        public void Paint(Graphics graphics)
        {
            using (var pen = new Pen(Color.Blue, 2))
            {
                graphics.DrawLine(pen, Location.X, Location.Y, Location.X + C / 2, Location.Y + A);
                graphics.DrawLine(pen, Location.X + C / 2, Location.Y + A, Location.X - C / 2, Location.Y + A);
                graphics.DrawLine(pen, Location.X - C / 2, Location.Y + A, Location.X, Location.Y);
            }

        }
        public bool Contains(Point point)
        {
            return
                Location.X - C / 2 < point.X && point.X < (Location.X - C / 2) + C &&
                Location.Y < point.Y && point.Y < Location.Y + A;
        }
    }
}
