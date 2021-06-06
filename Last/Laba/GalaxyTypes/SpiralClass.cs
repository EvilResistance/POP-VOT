using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba.GalaxyTypes
{
    [Serializable]
    public class SpiralClass : Spiral
    {
        public SpiralClass() { }
        public String SpiralType { get; set; }
        public SpiralClass(String name, int count, String spiralClass) : base(name, count)
        {
            SpiralType = spiralClass;
        }
    }
}
