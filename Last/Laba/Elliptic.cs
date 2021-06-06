using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    [Serializable]
    public class Elliptic : Galaxy
    {
        public Elliptic() { }
        public Elliptic( string name, int count) : base(name, count){}
    }
}
