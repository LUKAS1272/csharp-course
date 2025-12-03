Random generator = new Random();

for (int i = 0; i < 5; i++)
{
    int hod = generator.Next(1, 7); // 1–6
    Console.WriteLine("Hod č. " + (i + 1) + ": " + hod);
}