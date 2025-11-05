string[] ukoly = new string[5];

void ZobrazUkoly(string[] seznam)
{
    Console.WriteLine("Tvůj seznam úkolů:");
    for (int i = 0; i < seznam.Length; i++)
    {
        Console.WriteLine((i + 1) + ". " + seznam[i]);
    }
}

for (int i = 0; i < ukoly.Length; i++)
{
    Console.WriteLine("Zadej úkol č. " + (i + 1) + ":");
    ukoly[i] = Console.ReadLine();
}

ZobrazUkoly(ukoly);