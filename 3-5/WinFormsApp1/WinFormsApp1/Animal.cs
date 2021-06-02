using System;
using System.Xml.Serialization;
using WinFormsApp1.Animals;

namespace WinFormsApp1
{
    [XmlInclude(typeof(WarmC))]
    [XmlInclude(typeof(ColdC))]
    [Serializable]
    public class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Age.Age Age { get; set; }

        public Animal() {}
        public Animal(int distance_traveled, string name)
        {
            Weight = distance_traveled;
            Name = name;
        }
        public void ptrintT(Adapter adpter)
        {
            adpter.printMsg();
        }
    }
}
