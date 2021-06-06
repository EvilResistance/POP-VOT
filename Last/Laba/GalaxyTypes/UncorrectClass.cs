using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba.GalaxyTypes
{
    [Serializable]
    public class UncorrectClass : Uncorrect
    {
        public UncorrectClass() { }
        public String UncorrectType { get; set; }
        public UncorrectClass(String name, int count, String uncorrectClass) : base(name, count)
        {
            UncorrectType = uncorrectClass;
        }
    }
}
