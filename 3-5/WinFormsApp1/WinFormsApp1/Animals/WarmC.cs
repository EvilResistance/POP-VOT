using System;

namespace WinFormsApp1.Animals
{
    [Serializable]
    public class WarmC : Warmblooded
    {
        public String TypeW { get; set; }

        public WarmC()
        { }
        public WarmC(
            int weight, string name, int age, string warm_class
            ) : base(weight, name, age)
        {
            TypeW = warm_class;
        }
    }
}
 