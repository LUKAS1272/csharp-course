# Konstruktor

## 1. Co je konstruktor?

Konstruktor = **speciální metoda** pro vytvoření objektu

* Jmenuje se **stejně jako třída**
* **Nemá návratový typ** (ani `void`)
* Volá se automaticky při vytváření instance pomocí `new`

---

## 2. Třída bez konstruktoru

```csharp
class Zvire
{
    public string jmeno;
    public int vek;
}

// Použití - musíme nastavit každou vlastnost zvlášť
Zvire pes = new Zvire();
pes.jmeno = "Rex";
pes.vek = 3;
```

---

## 3. Třída s konstruktorem

```csharp
class Zvire
{
    public string jmeno;
    public int vek;
    
    // Konstruktor
    public Zvire(string jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
    }
}

// Použití - všechny vlastnosti najednou
Zvire pes = new Zvire("Rex", 3);
```

---

## 4. Proč `this.jmeno = jmeno;`?

Když mají **parametr** a **vlastnost** stejné jméno:

```csharp
public Zvire(string jmeno, int vek)
{
    this.jmeno = jmeno;  // this.jmeno = vlastnost objektu
                         // jmeno = parametr konstruktoru
    this.vek = vek;
}
```

---

## 5. Výhody konstruktoru

✅ Jednodušší vytváření objektů
✅ Nemůžeme zapomenout nastavit vlastnost
✅ Přehlednější kód

```csharp
// Bez konstruktoru - 4 řádky
Zvire pes = new Zvire();
pes.jmeno = "Rex";
pes.vek = 3;
pes.druh = "pes";

// S konstruktorem - 1 řádek
Zvire pes = new Zvire("Rex", 3, "pes");
```

---

## ⚠️ Časté chyby

| Špatně                               | Problém                 | Správně                          |
| ------------------------------------ | ----------------------- | -------------------------------- |
| `public void Zvire(...)`             | Má návratový typ        | `public Zvire(...)`              |
| `public zvire(...)`                  | Malé písmeno            | `public Zvire(...)`              |
| `jmeno = jmeno;`                     | Nejasné, co je co       | `this.jmeno = jmeno;`            |
