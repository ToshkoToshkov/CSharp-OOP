namespace ManufacturingPhones
{
    internal class StationaryPhone : ICallable
    {
        private List<string> phoneNumbers;
        public StationaryPhone()
        {
            this.phoneNumbers = new List<string>();
        }

        public void CallOtherPhones(List<string> phoneNumbers)
        {
            foreach (var phone in phoneNumbers)
            {
                Console.WriteLine($"Dialing... {phone}");
            }
        }
    }
}
