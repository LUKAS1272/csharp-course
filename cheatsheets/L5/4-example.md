# Kompletní příklad - Třída Zvire

## Soubor: Zvire.cs

```csharp
class Zvire
{
    // Vlastnosti
    public string jmeno;
    public int vek;
    public string druh;
    
    // Konstruktor
    public Zvire(string jmeno, int vek, string druh)
    {
        this.jmeno = jmeno;
        this.vek = vek;
        this.druh = druh;
    }
    
    // Metody
    public void PredstavSe()
    {
        Console.WriteLine("Jsem " + jmeno + ", je mi " + vek + " let a jsem " + druh + ".");
    }
    
    public void OslavNarozeniny()
    {
        vek++;
        Console.WriteLine(jmeno + " má narozeniny! Nyní je mu " + vek + " let.");
    }
    
    public void Zvuk(string zvuk)
    {
        Console.WriteLine(jmeno + " dělá: " + zvuk);
    }
}
```

---

## Soubor: Program.cs

```csharp
namespace Lekce5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření objektů
            Zvire pes = new Zvire("Rex", 3, "pes");
            Zvire kocka = new Zvire("Mičinka", 5, "kočka");
            
            // Volání metod
            pes.PredstavSe();
            kocka.PredstavSe();
            
            Console.WriteLine();
            
            pes.OslavNarozeniny();
            
            Console.WriteLine();
            
            pes.Zvuk("Haf haf!");
            kocka.Zvuk("Mňau!");
        }
    }
}
```

---

## Výstup:

```
Jsem Rex, je mi 3 let a jsem pes.
Jsem Mičinka, je mi 5 let a jsem kočka.

Rex má narozeniny! Nyní je mu 4 let.

Rex dělá: Haf haf!
Mičinka dělá: Mňau!
```

---

## Kombinace s polem

```csharp
static void Main(string[] args)
{
    // Pole objektů
    Zvire[] zvirata = new Zvire[3];
    
    zvirata[0] = new Zvire("Rex", 3, "pes");
    zvirata[1] = new Zvire("Mičinka", 5, "kočka");
    zvirata[2] = new Zvire("Petr", 15, "papoušek");
    
    // Procházení cyklem
    for (int i = 0; i < zvirata.Length; i++)
    {
        zvirata[i].PredstavSe();
    }
}
```

---

## Kombinace s náhodou

```csharp
static void Main(string[] args)
{
    Random generator = new Random();
    
    Zvire pes = new Zvire("Rex", 3, "pes");
    
    // Náhodný počet narozenin
    int pocet = generator.Next(1, 4); // 1-3
    
    for (int i = 0; i < pocet; i++)
    {
        pes.OslavNarozeniny();
    }
}
```
