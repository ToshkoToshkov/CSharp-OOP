namespace _03.PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();

            SoulMaster soulMaster = new SoulMaster("Ico", 45);

            DarkKnight darkKnight = new DarkKnight("Bocko", 34);

            MuseElf museElf = new MuseElf("Bici", 2);

            heroes.Add(soulMaster);
            heroes.Add(darkKnight);
            heroes.Add(museElf);

            foreach (var item in heroes)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
