namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Bag bag;
        private Present present;
        private List<Present> list;

        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
            present = new Present("Pesho", 2);
            list = new List<Present>();
        }

        [Test]
        public void TryCreateWhenPresentIsNUll()
        {
            Assert.Throws<ArgumentNullException>(() => this.bag.Create(null));
        }

        [Test]
        public void TryCreateWhenAlreadyExist()
        {
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => this.bag.Create(present));
        }

        [Test]
        public void TryRemovePresent()
        {
            list.Add(present);
            list.Remove(present);
            Assert.That(list.Count, Is.Zero);
        }

        [Test]
        public void IncreaseWhenAddPresent()
        {
            this.list.Add(present);
            Assert.That(list.Count, Is.EqualTo(1));
        }

        [Test]
        public void getPresent()
        {
            Present pres = new Present("Ico", 5);
            bag.Create(pres);
            var something = bag.GetPresentWithLeastMagic();

            Assert.That(something, Is.EqualTo(pres));
        }
    }
}
