# Časté chyby při práci s třídami

## 1. Zapomenutí `new`

```csharp
// ❌ ŠPATNĚ
Postava hrac;
hrac.jmeno = "Rytíř";  // CHYBA - NullReferenceException

// ✅ SPRÁVNĚ
Postava hrac = new Postava();
hrac.jmeno = "Rytíř";
```

**Chyba:** Objekt nebyl vytvořen, proměnná je `null`

---

## 2. Zapomenutí `public`

```csharp
// ❌ ŠPATNĚ
class Postava
{
    string jmeno;  // Není přístupné mimo třídu
}

static void Main(string[] args)
{
    Postava hrac = new Postava();
    hrac.jmeno = "Rytíř";  // CHYBA - 'jmeno' is inaccessible
}

// ✅ SPRÁVNĚ
class Postava
{
    public string jmeno;
}
```

---

## 3. Název třídy malým písmenem

```csharp
// ❌ ŠPATNĚ
class postava { }

// ✅ SPRÁVNĚ
class Postava { }
```

**Konvence:** Třídy začínají velkým písmenem

---

## 4. Kód mimo metodu `Main`

```csharp
// ❌ ŠPATNĚ
namespace Lekce5
{
    internal class Program
    {
        Postava hrac = new Postava();  // CHYBA - mimo Main
        
        static void Main(string[] args)
        {
            
        }
    }
}

// ✅ SPRÁVNĚ
namespace Lekce5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postava hrac = new Postava();  // Kód uvnitř Main
        }
    }
}
```

---

## 5. Zapomenutí závorek u `new`

```csharp
// ❌ ŠPATNĚ
Postava hrac = new Postava;

// ✅ SPRÁVNĚ
Postava hrac = new Postava();
```

---

## 6. Chybějící modifikátor u metody

```csharp
// ❌ ŠPATNĚ
class Postava
{
    PredstavSe()  // Chybí public void
    {
        Console.WriteLine("Ahoj");
    }
}

// ✅ SPRÁVNĚ
class Postava
{
    public void PredstavSe()
    {
        Console.WriteLine("Ahoj");
    }
}
```

---

## 7. Volání metody bez závorek

```csharp
// ❌ ŠPATNĚ
hrac.PredstavSe;

// ✅ SPRÁVNĚ
hrac.PredstavSe();
```

---

## 8. Konstruktor s návratovým typem

```csharp
// ❌ ŠPATNĚ
class Zvire
{
    public void Zvire(string jmeno)  // Má návratový typ
    {
        this.jmeno = jmeno;
    }
}

// ✅ SPRÁVNĚ
class Zvire
{
    public Zvire(string jmeno)  // Bez návratového typu
    {
        this.jmeno = jmeno;
    }
}
```

---

## 📋 Kontrolní seznam

Před spuštěním programu zkontroluj:

- [ ] Vytvořil/a jsem třídu přes **Add → Class**?
- [ ] Mají vlastnosti `public`?
- [ ] Začíná název třídy velkým písmenem?
- [ ] Vytvořil/a jsem objekt pomocí `new` **se závorkami**?
- [ ] Je kód uvnitř metody `Main`?
- [ ] Mají metody `public void` (nebo jiný návratový typ)?
- [ ] Volám metody **se závorkami** `()`?
- [ ] Odškrtl/a jsem "Do not use top-level statements"?

---

## 🆘 Nejčastější chybové hlášky

| Chyba | Příčina | Řešení |
|-------|---------|--------|
| `NullReferenceException` | Objekt nebyl vytvořen | Přidej `new Trida()` |
| `'jmeno' is inaccessible` | Chybí `public` | Přidej `public` před vlastnost |
| `The name 'Main' does not exist` | Top-level statements zapnuté | Odškrtni při vytváření projektu |
