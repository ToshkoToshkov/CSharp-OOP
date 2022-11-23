using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> foodOrders;
        private List<IDrink> drinkOrders;
        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;
            foodOrders = new List<IBakedFood>();
            drinkOrders = new List<IDrink>();
        }

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }

                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.NumberOfPeople;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }

                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }

        public bool IsReserved { get; private set; }

        public decimal Price
        {
            get
            {
                return PricePerPerson * numberOfPeople;
            }
            private set
            {
            }
        }

        public void Clear()
        {
            foodOrders.Clear();
            drinkOrders.Clear();
            IsReserved = false;
            NumberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal bill = 0;

            foreach (var item in foodOrders)
            {
                bill += item.Price;
            }

            foreach (var item in drinkOrders)
            {
                bill += item.Price;
            }

            return bill;
        }

        public string GetFreeTableInfo()
        {
            return $"Table: {TableNumber}\r\n" +
                   $"Type: {this.GetType().Name}\r\n" +
                   $"Capacity: {capacity}\r\n" +
                   $"Price per Person: {this.PricePerPerson}";

        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            IsReserved = true;
            NumberOfPeople = numberOfPeople;
        }
    }
}
