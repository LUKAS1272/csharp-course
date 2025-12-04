# Objekty, vlastnosti a metody

## 1. Co je objekt (v zjednodušené verzi)

Objekt = **něco v programu**, co:

* **uchovává data** (např. text, čísla, prvky pole),
* má **metody** (umí činnost) a **vlastnosti** (popisuje se).

Používáme **tečku**:

```csharp
jmenoMetodyObjektu.JmenoVlastnosti
```

---

## 2. `Random` jako objekt

```csharp
Random generator = new Random();
int cislo = generator.Next(1, 11);  // metoda Next()
```

* `generator` = objekt
* `Next(...)` = metoda objektu `Random`

---

## 3. `string` jako objekt

```csharp
string text = "Ahoj svete";

Console.WriteLine(text.Length);     // vlastnost – počet znaků
Console.WriteLine(text.ToUpper());  // metoda – nový text VELKÝMI PÍSMENY
Console.WriteLine(text.ToLower());  // metoda – nový text malými písmeny
```

---

## 4. Pole jako objekt

```csharp
int[] cisla = new int[3];
cisla[0] = 10;
cisla[1] = 20;

Console.WriteLine(cisla.Length); // Vypíše velikost (délku) pole = 3
```

* `cisla` je **objekt pole**
* `Length` je **vlastnost** → počet prvků (3)
