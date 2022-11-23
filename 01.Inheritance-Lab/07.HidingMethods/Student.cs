namespace _07.HidingMethods
{
    class Student : Person
    {
        public void Work()
        {
            base.Work();
            Console.WriteLine("Student doesn't work!");
        }
    }
}
