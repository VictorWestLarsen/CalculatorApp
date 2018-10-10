using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using SmartMenuLibrary;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bindings bindings = new Bindings();
            bindings.Bind("add", MenuPoints.Add);
            bindings.Bind("sub", MenuPoints.Subtract);
            bindings.Bind("multi", MenuPoints.Multiply);
            bindings.Bind("div", MenuPoints.Divide);
            bindings.Bind("sum", MenuPoints.Sum);
            bindings.Bind("min", MenuPoints.Minimum);
            bindings.Bind("max", MenuPoints.Maximum);
            SmartMenu smartMenu = new SmartMenu(bindings);
            smartMenu.LoadMenu("MenuSpec.txt");
            smartMenu.Activate();
        }
    }
}
