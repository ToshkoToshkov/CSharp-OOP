namespace ManufacturingPhones
{
    internal class SmartPhone : ICallable, IWebBrowsing
    {
        private List<string> phoneNumbers;
        private List<string> webs;

        public SmartPhone()
        {
            this.phoneNumbers = new List<string>();
            this.webs = new List<string>();
        }

        public void BrowseInWeb(List<string> webs)
        {
            foreach (var web in webs) 
            {
                Console.WriteLine($"Browsing: {web}");
            }
            
        }

        public void CallOtherPhones(List<string> phoneNumbers)
        {
            foreach (var phone in phoneNumbers)
            {
                Console.WriteLine($"Calling... {phone}");
            }
            
        }
    }
}
