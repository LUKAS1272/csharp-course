# Struktura programu bez top-level statements

## 1. Co se změnilo?

V lekcích 1-4 jsme používali **top-level statements**:

```csharp
// Kód přímo bez Main
Console.WriteLine("Ahoj");
int cislo = 5;
```

Od lekce 5 používáme **klasickou strukturu**:

```csharp
namespace Lekce5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Všechen kód musí být ZDE
            Console.WriteLine("Ahoj");
            int cislo = 5;
        }
    }
}
```

---

## 2. Proč tato změna?

Při práci s vlastními třídami potřebujeme:
* Vidět strukturu programu
* Rozlišit, co je třída a co je spustitelný kód
* Všechen spustitelný kód musí být **uvnitř metody `Main()`**

---

## 3. Jak vytvořit projekt bez top-level statements?

Při vytváření nového projektu:

1. **Create a new project**
2. Vybrat **Console App (C#)**
3. Pojmenovat projekt
4. **DŮLEŽITÉ:** **Odškrtnout** možnost **"Do not use top-level statements"**

---

## 4. Kam patří kód?

```csharp
namespace Lekce5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ✅ Spustitelný kód patří SEM
            Postava hrac = new Postava();
            hrac.jmeno = "Rytíř";
            Console.WriteLine(hrac.jmeno);
        }
        
        // ❌ Sem NEPATŘÍ spustitelný kód
        // Postava hrac = new Postava(); // CHYBA!
    }
    
    // ✅ Vlastní třídy patří mimo Main (nebo do samostatného souboru)
}
```

---

## 5. Struktura projektu s třídami

```
📁 Projekt
├── Program.cs          // Obsahuje Main, spustitelný kód
├── Postava.cs          // Obsahuje třídu Postava
└── Zvire.cs            // Obsahuje třídu Zvire
```

**Program.cs:**
```csharp
namespace Lekce5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postava hrac = new Postava("Rytíř", 100);
            hrac.PredstavSe();
        }
    }
}
```

**Postava.cs:**
```csharp
class Postava
{
    public string jmeno;
    public int zivoty;
    
    public Postava(string jmeno, int zivoty)
    {
        this.jmeno = jmeno;
        this.zivoty = zivoty;
    }
    
    public void PredstavSe()
    {
        Console.WriteLine("Jsem " + jmeno);
    }
}
```

---

## ⚠️ Časté chyby

| Chyba                                    | Problém                          | Řešení                                     |
| ---------------------------------------- | -------------------------------- | ------------------------------------------ |
| Kód mimo `Main()`                        | Program se nespustí              | Přesuň kód dovnitř `Main`                  |
| Zaškrtnuté top-level statements          | Chybí metoda `Main`              | Odškrtni při vytváření projektu            |
| `The name 'Main' does not exist`         | Top-level statements zapnuté     | Vytvoř nový projekt s odškrtnutou možností |
