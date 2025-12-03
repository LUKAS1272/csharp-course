Random generator = new Random();
int tajneCislo = generator.Next(1, 21); // 1–20

Console.WriteLine("Myslím si číslo od 1 do 20. Zkus ho uhodnout!");

int pokus = 0;

while (pokus != tajneCislo)
{
    Console.Write("Tvůj tip: ");
    string vstup = Console.ReadLine();
    pokus = int.Parse(vstup);

    if (pokus < tajneCislo)
    {
        Console.WriteLine("Moc malé!");
    }
    else if (pokus > tajneCislo)
    {
        Console.WriteLine("Moc velké!");
    }
    else
    {
        Console.WriteLine("Správně! Uhodl jsi číslo.");
    }
}