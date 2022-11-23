using Easter.Core.Contracts;
using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Repositories;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IBunny> bunnies;
        private readonly IRepository<IEgg> eggs;

        public Controller()
        {
            bunnies = new BunnyRepository();
            eggs = new EggRepository();
        }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType != "HappyBunny" && bunnyType != "SleepyBunny")
            {
                throw new InvalidOperationException("Invalid bunny type.");
            }

            if (bunnyType == "HappyBunny")
            {
                IBunny happyBunny = new HappyBunny(bunnyName);
                bunnies.Add(happyBunny);
            }
            else if (bunnyType == "SleepyBunny")
            {
                IBunny sleepyBunny = new SleepyBunny(bunnyName);
                bunnies.Add(sleepyBunny);
            }

            return $"Successfully added {bunnyType} named {bunnyName}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IDye dye = new Dye(power);
            IBunny bunny = bunnies.FindByName(bunnyName);

            if (bunny == null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }

            bunny.AddDye(dye);

            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            IEgg egg = new Egg(eggName, energyRequired);

            eggs.Add(egg);

            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            IEgg egg = this.eggs.FindByName(eggName);
            List<IBunny> sortedBunnyes = this.bunnies.Models.OrderByDescending(b => b.Energy >= 50).ToList();

            if (sortedBunnyes.Count == 0)
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }

            while (sortedBunnyes.Count != 0)
            {
                IBunny bunny = sortedBunnyes.FirstOrDefault();

                bunny.Work();

                if (bunny.Energy <= 0)
                {
                    sortedBunnyes.Remove(bunny);
                }
            }

            return $"Egg {eggName} is {egg.IsDone()}.";
            
        }

        public string Report()
        {
            string result = "";

            result += $"{eggs.Models.Count}eggs are done!\r\n" +
                      $"Bunnies info:";

            foreach (var bunny in bunnies.Models)
            {
                result += $"Name: {bunny.Name}\r\n" +
                          $"Energy: {bunny.Energy}\r\n" +
                          $"Dyes: {bunny.Dyes.Count} not finished";
            }

            return result;
        }
    }
}
