namespace _05.Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine)
            : base(name, 3.5M, 50)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
