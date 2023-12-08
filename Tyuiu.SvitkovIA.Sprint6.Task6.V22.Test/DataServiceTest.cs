using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SvitkovIA.Sprint6.Task6.V22.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Ванюшка\Desktop\repos\Tyuiu.SvitkovIA.Sprint6\Tyuiu.SvitkovIA.Sprint6.Task6.V22\bin\Debug\InPutFileTask6V22.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = " MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf ";
            Assert.AreEqual(wait, res);
        }
    }
}
