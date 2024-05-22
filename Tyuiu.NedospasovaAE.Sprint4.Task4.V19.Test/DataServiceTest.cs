using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint4.Task4.V19.Lib;

namespace Tyuiu.NedospasovaAE.Sprint4.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int[,] arrayNums = new int [5,5] { { 6, 7, 3, 5, 1 },
                                               { 6, 5, 2, 2, 7 },
                                               { 2, 6, 4, 6, 6 },
                                               { 7, 5, 5, 2, 6 },
                                               { 3, 1, 5, 7, 7 } };
            int wait = ds.Calculate(arrayNums);
            int res = 68;
            Assert.AreEqual(wait, res);
        }
    }
}
