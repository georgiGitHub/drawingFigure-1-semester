using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Circle : Shape
    {
        public override double CircleArea()
        {
            return Math.PI * R * R;
        }
    }
}
