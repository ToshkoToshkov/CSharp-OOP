namespace _02.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                this.ThrowIfInvalidSaid(value, nameof(Length));

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                this.ThrowIfInvalidSaid(value, nameof(Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                this.ThrowIfInvalidSaid(value, nameof(Height));

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }


        private void ThrowIfInvalidSaid(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
