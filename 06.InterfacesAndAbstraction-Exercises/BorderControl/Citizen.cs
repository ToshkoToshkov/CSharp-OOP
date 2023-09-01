namespace BorderControl
{
    internal class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

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
