using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Shape
    {
        public float A{ get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float R { get; set; }
        public virtual double RectanglePerimeter()
        {
            return A * 2 + B * 2;
        }

        public virtual double RectangleArea()
        {
            return A * B;
        }

        public virtual double SquarePerimeter()
        {
            return 4*A;
        }

        public virtual double SquareArea()
        {
            return A * A;
        }

        public virtual double TrianglePerimeter()
        {
            return 2 * A + C;
        }

        public virtual double TriangleArea()
        {
            return (2 * A + C) / 2;
        }
        public virtual double CircleArea()
        {
            return Math.PI * R * R;
        }
        public virtual double RectangleDiagonal()
        {
            return Math.Sqrt((A * A) + (B * B));
        }
        public virtual double SquareDiagonal()
        {
            return Math.Sqrt(A * A + A * A);
        }
        public virtual double sin_ACB()
        {
            double cos = ((C * C) - (B * B) - (A * A))/ - (2 * A * B);
            double sin = Math.Sqrt(1-(cos*cos));
            return sin;
        }
        public virtual double sin_ABC()
        {
            double cos = ((B * B) - (C * C) - (A * A)) / -(2 * A * C);
            double sin = Math.Sqrt(1 - (cos * cos));
            return sin;
        }
        public virtual double sin_BAC()
        {
            double cos = ((A * A) - (C * C) - (B * B)) / -(2 * B * C);
            double sin = Math.Sqrt(1 - (cos * cos));
            return sin;
        }
        public virtual double cos_ACB()
        {
            double cos = ((C * C) - (B * B) - (A * A)) / -(2 * A * B);
            return cos;
        }
        public virtual double cos_ABC()
        {
            double cos = ((B * B) - (C * C) - (A * A)) / -(2 * A * C);
            return cos;
        }
        public virtual double cos_BAC()
        {
            double cos = ((A * A) - (C * C) - (B * B)) / -(2 * B * C);
            return cos;
        }
    }
}
