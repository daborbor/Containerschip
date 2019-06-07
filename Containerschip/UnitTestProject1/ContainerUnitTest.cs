﻿using System;
using Algoritme.Interfaces.ObjectInterfaces;
using Algoritme.Objects;

namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    namespace UnitTestProject1
    {
        [TestClass]
        public class ContainerUnitTest
        {
            [TestMethod]
            public void KloptHetGewicht()
            {
                int weight = 100;
                IContainer container = new Container(100);
                Assert.AreEqual(100, container.Weight);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void MagGewichtKleinDan1Zijn()
            {
                IContainer container = new Container(0);
            }
        }
    }
}
