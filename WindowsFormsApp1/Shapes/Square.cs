using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class Square : Shape
    {

        public override double SquareArea()
        {
            return A * A;
        }
        public override double SquarePerimeter()
        {
            return 4*A;
        }
        public override double SquareDiagonal()
        {
            return Math.Sqrt(A*A+A*A);
        }
    }
}
