namespace _05.CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(new List<string>()
            {
                "123",
                "456",
                "789",
                "gogi"
            });

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
