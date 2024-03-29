﻿using OnlineShop.Models.Products;
using System;

namespace OnlineShop.Models
{
    public abstract class Product : IProduct
    {
        private int id;
        private string manufacturer;
        private string model;
        private decimal price;
        private double overallPerformance;

        public Product(int id, string manufacturer, string model, decimal price, double overallPerformance)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            OverallPerformance = overallPerformance;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Id can not be less or equal than 0.");

                }

                this.id = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Manufacturer can not be empty.");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Model can not be empty.");
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Price can not be less or equal than 0.");

                }

                this.price = value;
            }
        }

        public double OverallPerformance
        {
            get
            {
                return this.overallPerformance;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Overall Performance can not be less or equal than 0.");

                }

                this.overallPerformance = value;
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {overallPerformance}. Price: {price} - {this.GetType().Name}: {manufacturer} {model} (Id: {id})";
        }
    }
}
