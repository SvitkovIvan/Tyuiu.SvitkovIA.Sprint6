using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SvitkovIA.Sprint6.Task0.V22.Lib
{
    public class DataService : ISprint6Task0V22
    {
        public double Calculate(int x)
        {
            double res = ((double)0.7 * x * x * x + ((double)1.52 * x * x));
            return Math.Round(res, 3);
        }
    }
}
