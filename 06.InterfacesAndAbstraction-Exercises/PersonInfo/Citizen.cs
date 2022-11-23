﻿namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
            Food = 0;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public string BirthDate { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
