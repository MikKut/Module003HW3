using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Class2
    {
        private double _calcRes;
        public double CalcRes { get => _calcRes; private set => _calcRes = value; }
        public Predicate<double> Calc(Func<double, double, double> del, double x, double y)
        {
            CalcRes = del(x, y);
            return Result;
        }

        public bool Result(double x)
            => CalcRes % x == 0;
    }
}
