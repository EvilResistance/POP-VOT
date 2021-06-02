using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Association: Component
    {
        private List<Component> components = new List<Component>();

        public Association(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Print()
        {
            MessageBox.Show("Узел " + name);
            MessageBox.Show("Подузлы:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }
}
