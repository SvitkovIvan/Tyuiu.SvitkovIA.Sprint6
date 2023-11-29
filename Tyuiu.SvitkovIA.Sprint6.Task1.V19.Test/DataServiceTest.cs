using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SvitkovIA.Sprint6.Task1.V19.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = 15.19;
            wait[1] = 11.67;
            wait[2] = 9.00;
            wait[3] = 0.0;
            wait[4] = 4.08;
            wait[5] = 1.50;
            wait[6] = -2.28;
            wait[7] = -6.52;
            wait[8] = -9.61;
            wait[9] = -12.76;
            wait[10] = -14.68;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
        }
    }
}


