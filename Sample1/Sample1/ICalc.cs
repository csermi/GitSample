using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    interface ICalc
    {
        double Add(double x, double y);

        double Div(double x, double y);

        double DivD(double x, double y);

        void Mult();
    }
}
