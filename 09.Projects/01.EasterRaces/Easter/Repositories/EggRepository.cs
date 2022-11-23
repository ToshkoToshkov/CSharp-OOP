using Easter.Models.Eggs.Contracts;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Repositories
{
    public class EggRepository : IRepository<IEgg>
    {
        private readonly IDictionary<string, IEgg> models;

        public EggRepository()
        {
            models = new Dictionary<string, IEgg>();
        }

        public IReadOnlyCollection<IEgg> Models { get; private set; }

        public void Add(IEgg model)
        {
            this.models.Add(model.Name, model);
        }

        public IEgg FindByName(string name)
        {
            IEgg egg = null;

            if (this.models.ContainsKey(name))
            {
                egg = this.models[name];
            }

            return egg;
        }

        public bool Remove(IEgg model)
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
