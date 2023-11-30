﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SvitkovIA.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double y;
            int len = (stopValue - startValue) + 1;
            double[] func = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((5*x+2.5)/(Math.Sin(x) + 3)) + 2*x + Math.Cos(x), 2);
                func[count] = y;
                count++;
            }
            return func;
        }
    }
}
