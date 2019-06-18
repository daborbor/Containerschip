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
            Ship ship = new Ship(4, 5);

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
            Ship ship = new Ship(4, 5);

            ship.AddContainer(0,1, new Container(5500, false, false));
            ship.AddContainer(3,1, new Container(4500, false, false));

            Assert.AreEqual(5500, ship.GewichtLinks());
            Assert.AreEqual(4500, ship.GewichtRechts());
        }
    }
}
