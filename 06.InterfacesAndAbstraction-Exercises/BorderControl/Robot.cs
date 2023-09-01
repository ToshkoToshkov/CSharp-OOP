namespace BorderControl
{
    internal class Robot : IRobot
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; set; }

        public string Id { get; set; }

        private int TakeLastThreeDigits(string id)
        {
            var substring = id.Substring(id.Length - 3);

            int subsConverted = int.Parse(substring);

            return subsConverted;
        }

        public bool CompareDigits(string id, int digitsToCompare)
        {
            int lastThreeDigits = TakeLastThreeDigits(id);

            if (lastThreeDigits == digitsToCompare)
            {
                return false;
            }

            return true;
        }
    }
}
