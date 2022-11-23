namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private int initialSize = 3;

        public FreshwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
        }

        public override void Eat()
        {
            initialSize += 3;
        }
    }
}
