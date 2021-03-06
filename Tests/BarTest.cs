using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FooBar.Bar;

namespace FooBar.Bar.Test
{
    [TestClass]
    public class BarTest
    {
        private Bar barTestInstance; 

        [TestInitialize]
        public void TestInitialize()
        {
            var myInt = new Mock<INumber>();
            barTestInstance = new Bar(myInt.Object);
        }

        [TestMethod]
        public void GetInterfaceTest()
        {
            INumber actual = barTestInstance.GetInterface(); 

            var expected = new Mock<INumber>();
            Assert.AreEqual(expected.Object, actual);
            Assert.Fail("autogenerated");
        }

        [TestMethod]
        public void SetInterfaceTest()
        {
            var myBoolean = new Mock<INumber>(); 

            Assert.Fail("autogenerated");
        }
    }
}