using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint4.Task6.V12.Lib;

namespace Tyuiu.NedospasovaAE.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var array = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] wait = {"Украина","Молдова","Эстония"};
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
