namespace _01.Cars
{
    public interface Icar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public string Start();

        public string Stop();
    }
}
