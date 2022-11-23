namespace _06.ConstructorInheritance
{
    class FrontEndProgrammer : Programmer
    {
        public FrontEndProgrammer(string name, int salary)
            : base(name, salary, new List<string> { "JavaScript", "React" })
        {
            Console.WriteLine("In FrontEnd");
        }
    }
}
