using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operation2();
            result += this._subsystem2.operation2();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operation3();
            result += this._subsystem2.operation3();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationN();
            return result;
        }
    }

    public class Subsystem1
    {
        public string operation1() { return "Subsystem1: E5\n"; }
        public string operation2() { return "Subsystem1: SB0\n"; }
        public string operation3() { return "Subsystem1: Sc\n"; }
        public string operationN() { return "Subsystem1: SBb\n"; }
    }

    public class Subsystem2
    {
        public string operation1() { return "Subsystem2: Elliptic\n"; }
        public string operation2() { return "Subsystem2: Lens\n"; }
        public string operation3() { return "Subsystem2: Spiral\n"; }
        public string operationN() { return "Subsystem2: Uncorrect\n"; }
    }


    class Client
    {
        public static void ClientCode(Facade facade)
        {
            MessageBox.Show(facade.Operation());
        }
    }
}
