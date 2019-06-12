using System;
using System.Collections.Generic;
using System.Text;
using Algoritme.Objects;
using Algoritme.Objects.Ship;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    class ShipUnitTest
    {
        [TestMethod]
        public void KanErEenSchipGemaaktWorden()
        {
            Ship ship = new Ship(4,4);
        }

        [TestMethod]
        public void KloptHetGewicht()
        {

        }

        [TestMethod]
        public void KloptHetEvenwicht()
        {

        }
    }
}
