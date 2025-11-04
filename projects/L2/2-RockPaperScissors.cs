string pocitacVyber = "kámen";  // Zde se nevyužívá náhodný výběr, počítač vždy zvolí "kámen"
Console.WriteLine("Vyberte (kámen, nůžky, papír):");
string uzivatelVyber = Console.ReadLine();

if (uzivatelVyber == pocitacVyber)
{
    Console.WriteLine("Remíza! Oba jsme zvolili " + pocitacVyber + ".");
}

if (uzivatelVyber == "kámen")
{
    if (pocitacVyber == "papír")
    {
        Console.WriteLine("Prohráli jste! Počítač zvolil " + pocitacVyber + ".");
    }
    else
    {
        Console.WriteLine("Vyhráli jste!");
    }
}

if (uzivatelVyber == "nůžky")
{
    if (pocitacVyber == "kámen")
    {
        Console.WriteLine("Prohráli jste! Počítač zvolil " + pocitacVyber + ".");
    }
    else
    {
        Console.WriteLine("Vyhráli jste!");
    }
}

if (uzivatelVyber == "papír")
{
    if (pocitacVyber == "nůžky")
    {
        Console.WriteLine("Prohráli jste! Počítač zvolil " + pocitacVyber + ".");
    }
    else
    {
        Console.WriteLine("Vyhráli jste!");
    }
}