int pocetSestek = 0;

for (int i = 0; i < 20; i++)
{
    int hod = generator.Next(1, 7);
    Console.WriteLine("Hod: " + hod);

    if (hod == 6)
    {
        pocetSestek++;
    }
}

Console.WriteLine("Počet šestek: " + pocetSestek);
