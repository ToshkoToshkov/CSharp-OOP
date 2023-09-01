namespace BorderControl
{
    internal interface IRobot
    {
        public string Model { get; set; }

        public string Id { get; set; }

        public bool CompareDigits(string id, int digitsToCompare);

    }
}
