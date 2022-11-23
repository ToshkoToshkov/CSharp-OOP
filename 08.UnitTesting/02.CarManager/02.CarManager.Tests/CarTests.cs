using _02.CarManager;
using CarManager;
using NUnit.Framework;
using System;

namespace _02.CarManager.Tests
{
    public class CarTests
    {
        [Test]
        public void When_CarSpecificationAreProvided_ShouldBeSetCorrectly()
        {
            Car car = new Car("Make", "Model", 10, 100);
            Assert.That(car.Make, Is.EqualTo("Make"));
            Assert.That(car.Model, Is.EqualTo("Model"));
            Assert.That(car.FuelConsumption, Is.EqualTo(10));
            Assert.That(car.FuelCapacity, Is.EqualTo(100));
        }

        [Test]
        [TestCase("", "Model", 10, 100)]
        [TestCase(null, "Model", 10, 100)]
        [TestCase("Make", "", 10, 100)]
        [TestCase("Make", null, 10, 100)]
        [TestCase("Make", "Model", 0, 100)]
        [TestCase("Make", "Model", -10, 100)]
        [TestCase("Make", "Model", 10, 0)]
        [TestCase("Make", "Model", 10, -50)]
        public void Ctor_ThrowException_WhenDataIsInvalid(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));

        }
    }
}