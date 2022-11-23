namespace _06.ConstructorInheritance
{
    class Employee
    {

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
            Console.WriteLine("In Employee");
        }

        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
