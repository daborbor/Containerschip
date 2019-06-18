using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objects.Interfaces.ObjectInterfaces;
using Objects.Objects.Container;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class ContainerUnitTest
    {
        [TestMethod]
        public void KloptHetGewicht()
        {
            IContainer container = new Container(100, false, false);
            Assert.AreEqual(100, container.Weight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MagGewichtKleinDan1Zijn()
        {
            IContainer container = new Container(0, false, false);
        }

        [TestMethod]
        public void CheckElectricityProp()
        {
            IContainer containerE = new Container(1, true, false);
            IContainer containerNonE = new Container(1, false, false);
            Assert.IsTrue(containerE.Electricity);
            Assert.IsFalse(containerNonE.Electricity);
        }

        [TestMethod]
        public void CheckValuableProp()
        {
            IContainer containerV = new Container(1, false, true);
            IContainer containerNonV = new Container(1, false, false);
            Assert.IsTrue(containerV.Valuable);
            Assert.IsFalse(containerNonV.Valuable);
        }
    }
}
