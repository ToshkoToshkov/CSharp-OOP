namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private int initialSize = 5;

        public SaltwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
        }

        public override void Eat()
        {
            initialSize += 2;
        }
    }
}
