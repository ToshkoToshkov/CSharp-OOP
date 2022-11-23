using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private int healt = 5;
    private int experience = 10;
    private Dummy dummy;
    private Dummy deadDummy;

    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(healt, experience);
        deadDummy = new Dummy(-5, experience);
    }

    [Test]
    public void When_HealtAndIsProvidet_SHouldToSetCourectly()
    {
        Assert.AreEqual(healt, dummy.Health);
    }

    [Test]
    public void When_Attack_ShouldLooseHealt()
    {
        int attackPoints = 2;
        dummy.TakeAttack(attackPoints);

        Assert.That(dummy.Health, Is.EqualTo(healt - attackPoints));
    }

    [Test]
    public void When_DummyIsDead_ShouldThrowInvalidOperationExeption()
    {
        Assert.That(() =>
        {
            deadDummy.TakeAttack(3);
        }, Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void When_HealtIsPositive_ShouldBeAlive()
    {
        Assert.That(dummy.IsDead, Is.EqualTo(false));
    }

    [Test]
    public void When_HealtIsZero_ShouldBeDead()
    {
        dummy = new Dummy(0, experience);
        Assert.That(dummy.IsDead, Is.EqualTo(true));
    }

    [Test]
    public void When_HealtIsNegative_ShouldBeDead()
    {
        Assert.That(deadDummy.IsDead, Is.EqualTo(true));
    }

    [Test]
    public void When_Dead_ShouldGiveExperience()
    {
        Assert.That(deadDummy.GiveExperience(), Is.EqualTo(experience));
    }

    [Test]
    public void When_AliveGetExperience_ShouldThrowInvalidOperationExeption()
    {
        Assert.That(() =>
        {
            dummy.GiveExperience();
        }, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
