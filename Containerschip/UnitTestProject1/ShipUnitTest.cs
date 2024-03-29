﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objects.Objects.Container;
using Objects.Objects.Ship;

namespace UnitTestProject1
{
    [TestClass]
    public class ShipUnitTest
    {
        [TestMethod]
        public void KanErEenSchipGemaaktWorden()
        {
            List<int> powerStackRows = new List<int> {0};
            Ship ship = new Ship(4, 5, 2000000, 120000, powerStackRows);

            int x = ship.GetList().Count;
            int y = ship.GetList()[0].Count;

            Assert.AreEqual(4, ship.WidthX);
            Assert.AreEqual(5, ship.LengthY);
            Assert.AreEqual(4, x);
            Assert.AreEqual(5, y);
        }

        [TestMethod]
        public void KloptHetGewicht()
        {
            List<int> powerStackRows = new List<int> { 0 };
            Ship ship = new Ship(4, 5, 2000000, 120000, powerStackRows);

            ship.AddContainer(0, 1, new Container(5500, false, false));
            ship.AddContainer(3, 1, new Container(4500, false, false));

            Assert.AreEqual(10000, ship.Weight);
        }

        [TestMethod]
        public void KloptHetGewichtLinksRechts()
        {
            List<int> powerStackRows = new List<int> {0};
            Ship ship = new Ship(4, 5, 2000000, 120000, powerStackRows);

            ship.AddContainer(0,1, new Container(5500, false, false));
            ship.AddContainer(3,1, new Container(4500, false, false));

            Assert.AreEqual(5500, ship.GewichtLinks());
            Assert.AreEqual(4500, ship.GewichtRechts());
        }
        [TestMethod]
        public void KloptHetMaxGewicht()
        {
            List<int> powerStackRows = new List<int> { 0 };
            Ship ship = new Ship(2, 2, 2000000, 120000, powerStackRows);

            Assert.AreEqual((4* 2000000) ,ship.MaxWeight);
        }
    }
}
