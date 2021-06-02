using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    [Serializable]
    public class Coldblooded : Animal, Adapter
    {
        public Coldblooded()
        { }
        public Coldblooded(
            int weight, string name, int age
            ) : base(weight, name)
        {
            Age = new Age.Age(age);
        }
        public void printMsg()
        {
            MessageBox.Show(@"Coldblooded");
        }
    }
}
