string[] jidla = new string[3];

for (int i = 0; i < jidla.Length; i++)
{
    Console.WriteLine("Zadej oblíbené jídlo:");
    jidla[i] = Console.ReadLine();
}

Console.WriteLine("Tvoje oblíbená jídla:");
for (int i = 0; i < jidla.Length; i++)
{
    Console.WriteLine("- " + jidla[i]);
}