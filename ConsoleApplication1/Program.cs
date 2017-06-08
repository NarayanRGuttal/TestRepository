using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomationElement automationElement = null;

            automationElement = AutomationElement.RootElement;

            Condition condition = Condition.TrueCondition;

            String s = "test";

        }
    }
}
