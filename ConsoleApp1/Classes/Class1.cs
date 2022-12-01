using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Class1
    {
        public Class1()
        {
            Del += Program.Show;
        }

        public delegate void ShowDelegate(bool a);
        public ShowDelegate Del { get; private init; }
        public double Pow(double number, double power)
            => Math.Pow(number, power);
    }
}
