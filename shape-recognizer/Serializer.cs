using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace shape_recognizer
{
    class Serializer
    {
        public static void SerializeList(List<Point> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Point>));
            using(var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }
    }
}
