using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int comfort;
        private ICollection<IDecoration> decorations;
        private List<IAquarium> aquarium;
        private ICollection<IFish> fishes;

        public Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            aquarium = new List<IAquarium>();
            fishes = new Collection<IFish>();
            decorations = new Collection<IDecoration>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Aquarium name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort
        {
            get
            {
                int sum = 0;

                foreach (var item in decorations)
                {
                    sum += item.Comfort;
                }

                return sum;
            }
        }

        public ICollection<IDecoration> Decorations { get; private set; }

        public ICollection<IFish> Fish { get; private set; }

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (aquarium.Count < Capacity)
            {
                fishes.Add(fish);
            }
            else
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
        }

        public void Feed()
        {
            foreach (var item in fishes)
            {
                item.Eat();
            }
        }

        public string GetInfo()
        {
            string result = "";

            result += $"{this.Name} ({aquarium.GetType().Name}):\r\n";

            if (fishes.Count == 0)
            {
                result += $"Fish: none\r\n";
            }
            else
            {
                result += $"Fish: {string.Join(", ", fishes)}\r\n";
            }

            result += $"Decorations: {decorations.Count}\r\n";
            result += $"Comfort: {this.Comfort}";

            return result;
        }

        public bool RemoveFish(IFish fish)
        {
            if (fishes.Contains(fish))
            {
                fishes.Remove(fish);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
