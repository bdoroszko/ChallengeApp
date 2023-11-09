string name = "Tomasz";
string gender = "male";
var age = 40;
if (gender == "female" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && gender == "male")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Żaden z 3 warunków nie jest spełniony");
}
Console.ReadKey();