using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba.GalaxyTypes
{
    [Serializable]
    public class EllipticClass : Elliptic
    {
        public String EllipticType { get; set; }
        public EllipticClass() { }
        public EllipticClass(String name, int count, String ellipticClass) : base(name, count)
        {
            EllipticType = ellipticClass;
        }
    }
}
