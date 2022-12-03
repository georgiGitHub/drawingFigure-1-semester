using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Shapes
{
    class Scene
    {
        private List<Shape> _shapes = new List<Shape>();
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }
    }
}
