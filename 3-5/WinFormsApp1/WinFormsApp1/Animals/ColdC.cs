using System;

namespace WinFormsApp1.Animals
{
    [Serializable]
    public class ColdC : Coldblooded
    {
        public String TypeC { get; set; }
        public ColdC()
        { }
        public ColdC(
           int weight, string name, int age, String cold_class
            ) : base(weight, name, age)
        {
            TypeC = cold_class;
        }
    }
}
