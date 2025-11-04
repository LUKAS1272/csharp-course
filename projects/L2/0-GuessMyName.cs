string jmeno = "Lukáš";

Console.WriteLine("Uhodni mé jméno:");
string vstup = Console.ReadLine(); // Čte vstup jako text

if (vstup == jmeno)
{
    Console.WriteLine("Správně!");
}
else
{
    Console.WriteLine("To není mé jméno...");
}