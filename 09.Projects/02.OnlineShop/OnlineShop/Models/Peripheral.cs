﻿using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models
{
    public abstract class Peripheral : Product, IPeripheral
    {
        public Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            ConnectionType = connectionType;
        }

        public string ConnectionType { get; private set; }

        public override string ToString()
        {
            return $"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id}) Connection Type: {this.ConnectionType}";
        }
    }
}
