using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.karimov.sprint0.task2.V0.Lib;

namespace Tyuiu.karimov.sprint0.task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Карим";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет Карим", res);
        }
    }
}
