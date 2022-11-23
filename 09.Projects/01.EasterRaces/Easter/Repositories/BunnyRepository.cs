using Easter.Models.Bunnies.Contracts;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories
{
    public class BunnyRepository : IRepository<IBunny>
    {
        private readonly IDictionary<string, IBunny> models;

        public BunnyRepository()
        {
            models = new Dictionary<string, IBunny>();
        }

        public IReadOnlyCollection<IBunny> Models { get; private set; }

        public void Add(IBunny model)
        {
            this.models.Add(model.Name, model);
        }

        public IBunny FindByName(string name)
        {
            IBunny bunny = null;

            if (this.models.ContainsKey(name))
            {
                bunny = this.models[name];
            }

            return bunny;
        }

        public bool Remove(IBunny model)
        {
            if (!this.models.ContainsKey(model.Name))
            {
                return false;
            }

            this.models.Remove(model.Name);
            return true;
        }
    }
}
