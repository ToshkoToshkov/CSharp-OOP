namespace _03.Shapes
{
    public class Rectangle : Shape
    {

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }


        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
    }
}
