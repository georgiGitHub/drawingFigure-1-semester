using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Triangle : Shape 
    {
        
        public override double TriangleArea()
        {
            var p = (A + B + C)/2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override double TrianglePerimeter()
        {
            return  A+B+C;
        }
        public override double sin_ACB()
        {
            double cos = ((C * C) - (B * B) - (A * A)) / -(2 * A * B);
            double sin = Math.Sqrt(1 - (cos * cos));
            return sin;
        }
        public override double sin_ABC()
        {
            double cos = ((B * B) - (C * C) - (A * A)) / -(2 * A * C);
            double sin = Math.Sqrt(1 - (cos * cos));
            return sin;
        }
        public override double sin_BAC()
        {
            double cos = ((A * A) - (C * C) - (B * B)) / -(2 * B * C);
            double sin = Math.Sqrt(1 - (cos * cos));
            return sin;
        }
        public override double cos_ACB()
        {
            double cos = ((C * C) - (B * B) - (A * A)) / -(2 * A * B);
            return cos;
        }
        public override double cos_ABC()
        {
            double cos = ((B * B) - (C * C) - (A * A)) / -(2 * A * C);
            return cos;
        }
        public override double cos_BAC()
        {
            double cos = ((A * A) - (C * C) - (B * B)) / -(2 * B * C);
            return cos;
        }
    }
}
