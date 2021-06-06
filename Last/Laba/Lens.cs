using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    [Serializable]
    public class Lens : Galaxy
    {
        public Lens() { }
        public Lens(string name, int count) : base(name, count) { }
    }
}
