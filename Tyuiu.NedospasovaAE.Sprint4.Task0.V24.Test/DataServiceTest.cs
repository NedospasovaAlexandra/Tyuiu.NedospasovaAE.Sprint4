﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint4.Task0.V24.Lib;

namespace Tyuiu.NedospasovaAE.Sprint4.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = {9, 5, 7, 4, 5, 3, 7, 8, 9, 1};
            int res = ds.GetMultEvenArrEl(numsArray);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
