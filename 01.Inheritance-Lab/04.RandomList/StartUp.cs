namespace _04.CustomRandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("pesho");
            list.Add("gogi");
            list.Add("gigi");
            list.Add("mishi");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
