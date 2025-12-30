# 📘 Shrnutí páté lekce

| Téma                     | Příklad                                                    | Poznámka                                                     |
| ------------------------ | ---------------------------------------------------------- | ------------------------------------------------------------ |
| Třída                    | `class Postava { }`                                        | Šablona/návod pro vytváření objektů                          |
| Vlastnosti třídy         | `public string jmeno;`<br>`public int zivoty;`             | Data, která objekt obsahuje (musí být `public`)              |
| Konstruktor              | `public Postava(string jmeno, int zivoty)`                 | Speciální metoda pro vytvoření objektu, jmenuje se jako třída |
| Metoda ve třídě          | `public void PredstavSe() { }`                             | Akce, kterou objekt umí provést                              |
| Vytvoření objektu        | `Postava hrac = new Postava();`                            | Vytvoření konkrétní instance třídy pomocí `new`              |
| Klíčové slovo `this`     | `this.jmeno = jmeno;`                                      | Odkaz na aktuální objekt (rozlišení vlastnosti a parametru)  |
| Struktura bez top-level  | `static void Main(string[] args) { }`                      | Všechen spustitelný kód musí být uvnitř metody `Main`        |

---

## 🏗️ Základní struktura třídy

```csharp
class Postava
{
    // Vlastnosti
    public string jmeno;
    public int zivoty;
    
    // Konstruktor
    public Postava(string jmeno, int zivoty)
    {
        this.jmeno = jmeno;
        this.zivoty = zivoty;
    }
    
    // Metoda
    public void PredstavSe()
    {
        Console.WriteLine("Jsem " + jmeno);
    }
}
```

---

## 📝 Použití třídy

```csharp
static void Main(string[] args)
{
    // Vytvoření objektu
    Postava hrac = new Postava("Rytíř", 100);
    
    // Přístup k vlastnostem
    Console.WriteLine(hrac.jmeno);
    
    // Volání metody
    hrac.PredstavSe();
}
```
