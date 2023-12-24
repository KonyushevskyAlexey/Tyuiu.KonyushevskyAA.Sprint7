using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\Base.csv";
            string[,] res = ds.GetBase(pathSaveFile);
            string[,] wait = { { "value1", "value2" }, { "value3", "value4" } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
