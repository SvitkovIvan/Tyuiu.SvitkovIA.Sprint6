using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -32.26;
            valueWaitArray[1] = -27.50;
            valueWaitArray[2] = -22.80;
            valueWaitArray[3] = -17.95;
            valueWaitArray[4] = -12.97;
            valueWaitArray[5] = -9.00;
            valueWaitArray[6] = -0.31;
            valueWaitArray[7] = 3.77;
            valueWaitArray[8] = 8.57;
            valueWaitArray[9] = 13.42;
            valueWaitArray[10] = 18.28;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
