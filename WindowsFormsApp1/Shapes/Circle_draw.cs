using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Circle_draw
    {
        public float R { get; set; }
        public Point Location { get; set; }
        public void Paint(Graphics graphics)
        {
            using (var pen = new Pen(Color.Blue, 2))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y, R,R);
            }
        }
        public bool Contains(Point point)
        {
            return
                Location.X < point.X && point.X < Location.X + R &&
                Location.Y < point.X && point.Y < Location.Y + R;
        }
    }
}
