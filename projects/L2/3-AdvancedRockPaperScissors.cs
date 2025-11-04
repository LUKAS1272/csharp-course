int skorePocitac = 0;
int skoreUzivatel = 0;

while (true)
{
    Console.WriteLine("Vyberte (kámen, nůžky, papír):");
    string uzivatelVyber = Console.ReadLine();
    string pocitacVyber = "kámen";  // Zde se nevyužívá náhodný výběr, počítač vždy zvolí "kámen"

    if (uzivatelVyber == pocitacVyber)
    {
        Console.WriteLine("Remíza! Oba jsme zvolili " + pocitacVyber + ".");
    }
    else if (uzivatelVyber == "kámen")
    {
        if (pocitacVyber == "papír")
        {
            Console.WriteLine("Prohráli jste! Počítač zvolil " + pocitacVyber + ".");
            skorePocitac++;
        }
        else
        {
            Console.WriteLine("Vyhráli jste!");
            skoreUzivatel++;
        }
    }
    else if (uzivatelVyber == "nůžky")
    {
        if (pocitacVyber == "kámen")
        {
            Console.WriteLine("Prohráli jste! Počítač zvolil " + pocitacVyber + ".");
            skorePocitac++;
        }
        else
        {
            Console.WriteLine("Vyhráli jste!");
            skoreUzivatel++;
        }
    }
    else if (uzivatelVyber == "papír")
    {
        if (pocitacVyber == "nůžky")
        {
            Console.WriteLine("Prohráli jste! Počítač zvolil " + pocitacVyber + ".");
            skorePocitac++;
        }
        else
        {
            Console.WriteLine("Vyhráli jste!");
            skoreUzivatel++;
        }
    }
    else
    {
        Console.WriteLine("Tuto možnost neznám, zkus to znova.");
    }

    Console.WriteLine("Počítač: " + skorePocitac ", Uživatel: " + skoreUzivatel);
}