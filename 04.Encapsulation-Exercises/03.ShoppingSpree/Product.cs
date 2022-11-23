namespace _03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cost cannot be negative");
                }
                this.cost = value;
            }
        }
    }
}
