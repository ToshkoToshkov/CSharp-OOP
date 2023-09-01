using BorderControl;

string input = Console.ReadLine();

List<string> detainedIds = new List<string>();
List<Citizen> citizens = new List<Citizen>();
List<Robot> robots = new List<Robot>();

while (input != "End")
{
    string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string name;
    int age;
    string model;
    string id;

    if (data.Length == 3)
    {
        name = data[0];
        age = int.Parse(data[1]);
        id = data[2];

        Citizen citizen = new Citizen(name, age, id);

        citizens.Add(citizen);
    }
    else if (data.Length == 2)
    {
        model = data[0];
        id = data[1];

        Robot robot = new Robot(model, id);

        robots.Add(robot);
    }

    input = Console.ReadLine();
}

int deniedDigits = int.Parse(Console.ReadLine());

foreach (var citizen in citizens)
{
    if (citizen.CompareDigits(citizen.Id, deniedDigits) == false)
    {
        detainedIds.Add(citizen.Id);
    }
}

foreach (var robot in robots)
{
    if (robot.CompareDigits(robot.Id, deniedDigits) == false)
    {
        detainedIds.Add(robot.Id);
    }
}

foreach (var id in detainedIds)
{
    Console.WriteLine(id);
}

