using Algoritme.Algoritme;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objects.Interfaces.ObjectInterfaces;
using Objects.Objects.Container;
using Objects.Objects.Ship;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class AlgorithmTest
    {
        [TestMethod]
        public void PlaatsContainers()
        {
            List<int> powerStackRows = new List<int> { 0 };
            Ship ship = new Ship(2, 3, 2000000, 120000, powerStackRows);
            List<IContainer> containerList = new List<IContainer>
            {
                new Container(5000, false, false),
                new Container(5000, false, false),
                new Container(5000, false, false),
                new Container(5000, false, false),
                new Container(5000, false, true),
                new Container(5000, false, true),
                new Container(5000, false, true),
                new Container(5000, true, true),
                new Container(5000, true, true),
                new Container(5000, true, false)
            };
            AlgoritmeVerloop algoritme = new AlgoritmeVerloop();

            List<IContainer> restContainers = algoritme.PlaatsContainers(ship, containerList);
            //valuable check
            Assert.AreEqual(true, ship.GetList()[0][0].HasValuable);
            Assert.AreEqual(true, ship.GetList()[0][1].HasValuable);
            Assert.AreEqual(false, ship.GetList()[0][2].HasValuable);
            Assert.AreEqual(true, ship.GetList()[1][0].HasValuable);
            Assert.AreEqual(true, ship.GetList()[1][1].HasValuable);
            Assert.AreEqual(true, ship.GetList()[1][2].HasValuable);

            //stack height check
            Assert.AreEqual(2, ship.GetList()[0][0].Height);
            Assert.AreEqual(2, ship.GetList()[0][1].Height);
            Assert.AreEqual(1, ship.GetList()[0][2].Height);
            Assert.AreEqual(2, ship.GetList()[1][0].Height);
            Assert.AreEqual(2, ship.GetList()[1][1].Height);
            Assert.AreEqual(1, ship.GetList()[1][2].Height);

            //weight check
            Assert.AreEqual(10000, ship.GetList()[0][0].Weight);
            Assert.AreEqual(10000, ship.GetList()[0][1].Weight);
            Assert.AreEqual(5000, ship.GetList()[0][2].Weight);
            Assert.AreEqual(10000, ship.GetList()[1][0].Weight);
            Assert.AreEqual(10000, ship.GetList()[1][1].Weight);
            Assert.AreEqual(5000, ship.GetList()[1][2].Weight);

            //electricity check
            Assert.AreEqual(true, ship.GetList()[0][0].Electricity);
            Assert.AreEqual(false, ship.GetList()[0][1].Electricity);
            Assert.AreEqual(false, ship.GetList()[0][2].Electricity);
            Assert.AreEqual(true, ship.GetList()[1][0].Electricity);
            Assert.AreEqual(false, ship.GetList()[1][1].Electricity);
            Assert.AreEqual(false, ship.GetList()[1][2].Electricity);
        }
    }
}