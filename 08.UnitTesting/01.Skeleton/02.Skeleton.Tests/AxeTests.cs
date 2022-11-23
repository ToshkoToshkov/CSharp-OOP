using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private int attack = 5;
    private int durability = 6;
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attack, durability);
        dummy = new Dummy(5, 6);
    }


    [Test]
    public void WHen_DurabilityPointsAndAttackPointsAreProvidet_ShouldSetCorrectly()
    {
        Assert.AreEqual(axe.DurabilityPoints, durability);
        Assert.AreEqual(axe.AttackPoints, attack);
    }

    [Test]
    public void When_AxeAttack_ShouldLooseDurabilityPoints()
    {
        axe.Attack(dummy);

        Assert.AreEqual(durability - 1, axe.DurabilityPoints);
    }

    [Test]
    public void When_AxeDurabilityPointsAreEqualOrLessThanZero_ShouldToThrowExeption()
    {
        dummy = new Dummy(5000, 5000);

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
        {
            for (int i = 0; i < 7; i++)
            {
                axe.Attack(dummy);
            }
        });

        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }

    [Test]
    public void When_AttackIsCalledWithNullDummy_ShouldThrowNullRefEx()
    {
        Assert.Throws<NullReferenceException>(() =>
        {
            axe.Attack(null);
        });
    }
}