using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Rectangle : Shape
    { 

        public override double RectangleArea()
        {
            return A * B;
        }
        public override double RectanglePerimeter()
        {
            return 2*A + 2*B;
        }
        public override double RectangleDiagonal()
        {
            return Math.Sqrt((A*A)+(B*B));
        }
    }
}
