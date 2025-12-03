Random generator = new Random();

string[] jidla = { "Pizza", "Sushi", "Řízek", "Špagety", "Salát" };

for (int i = 0; i < 5; i++)
{
    int index = generator.Next(0, jidla.Length); // 0 až Length-1
    string vybraneJidlo = jidla[index];

    Console.WriteLine("Dnes bys mohl jíst: " + vybraneJidlo);
}