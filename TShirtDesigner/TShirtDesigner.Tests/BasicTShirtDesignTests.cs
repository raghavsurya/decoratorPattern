using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TShirtDesigner.Tests
{
    [TestClass]
    public class BasicTShirtDesignTests
    {
        private  ITShirtDesign _tshirtDesign;
        [TestInitialize]
        public void Init()
        {
            
            _tshirtDesign = new BasicTShirtDesign("Raghav Surya", 2, 100);
        }
        [TestMethod]
        public void ValueForTheDay_For2Days_ShouldReturn_80()
        {
            decimal value = _tshirtDesign.ValueForTheDay(2);
            Assert.AreEqual(80, value);
        }

        [TestMethod]
        public void ValueForTheDay_For1Days_ShouldReturn_100()
        {
            decimal value = _tshirtDesign.ValueForTheDay(1);
            Assert.AreEqual(100, value);
        }
        [TestMethod]
        public void ValueForTheDay_For3Days_ShouldReturn_64()
        {
            decimal value = _tshirtDesign.ValueForTheDay(3);
            Assert.AreEqual(64, value);
        }

    }
}
