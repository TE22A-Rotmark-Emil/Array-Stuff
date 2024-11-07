Console.WriteLine("Write city names. Anything goes, as long as it does not include a number.");
Console.WriteLine("When you feel satisfied that you have written LITERALLY EVERY SINGLE city name ever you can type \"exit\"");
char[] numbers = "1234567890".ToCharArray();
List<string> cities = new();
bool knowsMoreCities = true;
bool isValid = true;
do{
    Console.WriteLine("write a city name thx");
    string cityName = Console.ReadLine();
    foreach (char number in numbers){
        if (cityName.Contains(number)){
            isValid = false;
            break;
        }
        else{
            isValid = true;
        }
    }
    if (isValid){
        Console.WriteLine($"{cityName} has been added to your list of city names");
    }
    else{
        Console.WriteLine("say a REAL PLACE with REAL PEOPLE");
    }
    Console.WriteLine(cities.Count());
} while (cities.Count() < 10 && knowsMoreCities);

if (cities.Count >= 10){
    Console.WriteLine("Haha I lied I only accept 10 cities because I'm literally evil");
}

if (cities.Count > 0){
    Console.WriteLine("name of your precious cities:");
    foreach (string city in cities){
        Console.WriteLine(city);
    }
}
else{
    Console.WriteLine("WHAT?? ARE you STUPID?? 0 CITIES? new york city stockholm ANYTHING PLEASE");
    Console.ReadLine();
    Console.WriteLine("I don't like you");
    Console.ReadLine();
}