namespace _03.Shapes
{
    public abstract class Shape : IShape
    {

        public double Width { get; set; }

        public double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
