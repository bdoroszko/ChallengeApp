string name = "Tomasz";
string gender = "mężczyzna";
var age = 40;
Console.WriteLine(name);
Console.WriteLine(gender);
Console.WriteLine(age);
if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("mężczyzna powyżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Jakiś facet nie w wieku 33 lat");
}
else
{
    Console.WriteLine("Ewa, lat 33");
}
if (age <= 18 && gender == "mężczyzna")
{
    Console.WriteLine("Pełnoletnia Kobieta");
}
else
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
if (name == "Ewa")
{
    Console.WriteLine("Pani Ewa");
}
else if (gender == "kobieta")
{
    Console.WriteLine("Pani Ewa jest kobietą");
}
else if (age != 40)
{
    Console.WriteLine("Pani Ewa jest kobietą i nie ma 40 lat");
}
else
{
    Console.WriteLine("Pan " + name + " to " + gender + " i ma " + age + " lat ");
}
Console.ReadKey();