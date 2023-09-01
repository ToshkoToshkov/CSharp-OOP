using ManufacturingPhones;

var phones = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
var webs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

SmartPhone smart = new SmartPhone();
StationaryPhone stationary = new StationaryPhone();


List<string> smartphonePhoneNumbers = new List<string>();
List<string> stationaryPhoneNubmers = new List<string>();
List<string> verifiedWebs = new List<string>();


foreach (var phone in phones)
{
    if (phone.Length == 10)
    {
        smartphonePhoneNumbers.Add(phone);
    }
    else if (phone.Length == 7) 
    {
        stationaryPhoneNubmers.Add(phone);
    }
}



smart.CallOtherPhones(smartphonePhoneNumbers);
stationary.CallOtherPhones(stationaryPhoneNubmers);

foreach (var web in webs)
{
    if (!web.Contains('0') &&
        !web.Contains('1') &&
        !web.Contains('2') &&
        !web.Contains('3') &&
        !web.Contains('4') &&
        !web.Contains('5') &&
        !web.Contains('6') &&
        !web.Contains('7') &&
        !web.Contains('8') &&
        !web.Contains('9'))
    {
        verifiedWebs.Add(web);
    }
}

smart.BrowseInWeb(verifiedWebs);

foreach (var web in webs)
{
    if (web.Contains('0') ||
        web.Contains('1') ||
        web.Contains('2') ||
        web.Contains('3') ||
        web.Contains('4') ||
        web.Contains('5') ||
        web.Contains('6') ||
        web.Contains('7') ||
        web.Contains('8') ||
        web.Contains('9'))
    {
        Console.WriteLine("Invalid URL!");
    }
    
}


