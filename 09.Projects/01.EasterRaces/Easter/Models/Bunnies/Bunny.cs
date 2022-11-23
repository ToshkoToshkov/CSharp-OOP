using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private string name;
        private int energy;
        private ICollection<IDye> dyes;
        private IBunny bunny;

        public Bunny(string name, int energy)
        {
            Name = name;
            Energy = energy;
            dyes = new Collection<IDye>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Bunny name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Energy
        {
            get => this.energy;
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.energy = value;
            }
        }

        public ICollection<IDye> Dyes { get; private set; }

        public void AddDye(IDye dye)
        {
            dyes.Add(dye);
        }

        public void Work()
        {
            if (bunny.GetType().Name == "SleepyBunny")
            {
                this.Energy -= 15;

                if (this.Energy < 0)
                {
                    this.Energy = 0;
                }
            }

            this.Energy -= 10;

            if (this.Energy < 0)
            {
                this.Energy = 0;
            }
        }
    }
}
