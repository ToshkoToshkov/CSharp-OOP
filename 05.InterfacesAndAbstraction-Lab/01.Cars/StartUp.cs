﻿namespace _01.Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Icar seat = new Seat("Leon", "Grey");
            Icar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

        }
    }
}
