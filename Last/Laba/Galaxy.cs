using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Laba.GalaxyTypes;

namespace Laba
{
    [XmlInclude(typeof(EllipticClass))]
    [XmlInclude(typeof(LensClass))]
    [XmlInclude(typeof(SpiralClass))]
    [XmlInclude(typeof(UncorrectClass))]
    [Serializable]
    public class Galaxy
    {
        public String Name { get; set; }
        public int Count { get; set; }

        public Galaxy() {}

        public Galaxy(String name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
