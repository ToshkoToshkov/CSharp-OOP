namespace _02.Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Bear bear = new Bear("Pesho");
            Snake snake = new Snake("Gogi");

            List<Animal> animals = new List<Animal>();

            animals.Add(bear);
            animals.Add(snake);

            foreach (var item in animals)
            {
                Console.WriteLine($"Animal {item.Name} is in the zoo");
            }

        }
    }
}
