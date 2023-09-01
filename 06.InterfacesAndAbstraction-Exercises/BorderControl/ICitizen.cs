namespace BorderControl
{
    internal interface ICitizen
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public bool CompareDigits(string id, int digitsToCompare);
    }
}
