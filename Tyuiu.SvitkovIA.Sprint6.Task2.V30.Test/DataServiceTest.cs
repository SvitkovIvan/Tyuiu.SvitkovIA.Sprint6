using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SvitkovIA.Sprint6.Task2.V30.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task2.V30.Test
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
            wait[0] = -15.40;
            wait[1] = -13.31;
            wait[2] = -11.36;
            wait[3] = -8.00;
            wait[4] = -2.62;
            wait[5] = 1.83;
            wait[6] = 4.49;
            wait[7] = 6.78;
            wait[8] = 10.58;
            wait[9] = 17.38;
            wait[10] = 23.76;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
        }
    }
}