using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly IList<IDecoration> models;

        public DecorationRepository()
        {
            models = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models { get; private set; }

        public void Add(IDecoration model)
        {
            models.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            IDecoration dec = models.FirstOrDefault(d => d.GetType().Name == type);

            if (dec == null)
            {
                return null;
            }

            return dec;
        }

        public bool Remove(IDecoration model)
        {
            if (!models.Contains(model))
            {
                return false;
            }

            models.Remove(model);
            return true;
        }
    }
}
