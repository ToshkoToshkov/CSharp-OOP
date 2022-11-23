using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models
{
    public abstract class Computer : Product, IComputer
    {
        private IReadOnlyCollection<IComponent> components;
        private IReadOnlyCollection<IPeripheral> peripherals;


        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {

        }

        public IReadOnlyCollection<IComponent> Components { get; private set; }

        public IReadOnlyCollection<IPeripheral> Peripherals { get; private set; }

        public void AddComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new NotImplementedException();
        }

        public IComponent RemoveComponent(string componentType)
        {
            throw new NotImplementedException();
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id})");

            result.AppendLine($" Components ({components.Count}):");

            foreach (var item in components)
            {
                result.AppendLine($"{item.ToString()}");
            }

            result.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({this.OverallPerformance}):");

            return result.ToString();
        }
    }
}
