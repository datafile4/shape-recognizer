using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_recognizer
{
    class Database
    {
        public List<Polygon2D> Shapes { get; private set; }
        public List<string> Classes { get; private set; }

        public Database()
        {
            Classes = new List<string>();
            Shapes = new List<Polygon2D>();
        }
    }
}
