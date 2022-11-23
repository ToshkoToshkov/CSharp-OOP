using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private List<IAquarium> aquariums;
        private IRepository<IDecoration> decorations;
       


        public Controller()
        {
            aquariums = new List<IAquarium>();
            
            decorations = new DecorationRepository();
            
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType != "FreshwaterAquarium" && aquariumType != "SaltwaterAquarium")
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            if (aquariumType == "FreshwaterAquarium")
            {
                aquariums.Add(new FreshwaterAquarium(aquariumName));
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquariums.Add(new SaltwaterAquarium(aquariumName));
            }

            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            if (decorationType == "Ornament")
            {
                decorations.Add(new Ornament());
            }
            else if (decorationType == "Plant")
            {
                decorations.Add(new Plant());
            }

            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            if (aquariumName == "Underworld")
            {
                if (fishType == "FreshwaterFish")
                {
                    return "Water not suitable.";
                }
                else if (fishType == "SaltwaterFish")
                {
                    aqua.AddFish(new SaltwaterFish(fishName, fishSpecies, price));
                }
            }
            else if (aquariumName == "RiverWorld")
            {
                if (fishType == "FreshwaterFish")
                {
                    aqua.AddFish(new FreshwaterFish(fishName, fishSpecies, price));
                }
                else if (fishType == "SaltwaterFish")
                {
                    return "Water not suitable.";
                }
            }

            return $"Successfully added {fishType} to {aquariumName}.";
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            return $"The value of Aquarium {aquariumName} is {aqua.Comfort:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            aqua.Feed();

            return $"Fish fed: {aqua.Fish.Count}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration dec = decorations.FindByType(decorationType);
            IAquarium aqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if (dec == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            aqua.AddDecoration(dec);
            decorations.Remove(dec);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            string result = "";
            foreach (var item in aquariums)
            {
                result += item.GetInfo();
            }

            return result;
        }
    }
}
