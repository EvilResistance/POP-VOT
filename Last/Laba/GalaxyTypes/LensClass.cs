using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba.GalaxyTypes
{
    [Serializable]
    public class LensClass : Lens
    {
        public LensClass() { }
        public String LensType { get; set; }
        public LensClass(String name, int count, String lensClass) : base(name, count)
        {
            LensType = lensClass;
        }
    }
}
