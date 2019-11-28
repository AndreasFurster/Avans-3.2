using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AvansPeriode2Jaar3
{
    [TestFixture]
    class UnitTestProgram
    {
        private Program _sut;
        private double _shippingCosts = 0;

        [SetUp]
        public void Setup()
        {
            _sut = new Program();
            Assert.DoesNotThrow(() => Program.Main());
        }

        [TestCase(false, "", 0, 0)]
        [TestCase(true, "", 1501, 0)]
        [TestCase(true, "", 1500, 0)]
        [TestCase(true, "Ground", 1500, 100)]
        [TestCase(true, "InStore", 50, 50)]
        [TestCase(true, "NextDayAir", 250, 250)]
        [TestCase(true, "SecondDayAir", 150, 125)]
        [TestCase(true, null, 0, 0)]
        public void ShippingCosts_Calculate(bool calculateShippingCosts, string typeOfShippingCosts, int totalPrice, int expectedShippingCosts)
        {
            _shippingCosts = _sut.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);
            Assert.That(_shippingCosts == expectedShippingCosts,
                $"expected {expectedShippingCosts}, but was " + _shippingCosts);
        }
    }
}
