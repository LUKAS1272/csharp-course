## Podmínky – `if`, `else`

### Co jsou podmínky?

Podmínky umožňují programu **rozhodovat**, jak se má zachovat v různých situacích na základě daných kritérií (např. zda je věk větší než 18). Pokud je podmínka pravdivá, vykoná se určitý blok kódu, pokud ne, může být proveden jiný blok kódu pomocí `else`.

---

### 💡 Syntaxe:

```csharp
if (podmínka)
{
    // Kód, který se vykoná, pokud je podmínka pravdivá
}
else
{
    // Kód, který se vykoná, pokud je podmínka nepravdivá
}
```

---

### ✍️ Příklad:

```csharp
int vek = 20;

if (vek >= 18)
{
    Console.WriteLine("Jsi plnoletý.");
}
else
{
    Console.WriteLine("Jsi nezletilý.");
}
```

🖥️ Výstup:

```
Jsi plnoletý.
```

---

### 💡 Více možností – `else if`

Pokud máme více než jednu možnost, můžeme použít **`else if`**.

```csharp
int vek = 100;

if (vek < 18)
{
    Console.WriteLine("Jsi dítě.");
}
else if (vek <= 99)
{
    Console.WriteLine("Jsi dospělý.");
}
else
{
    Console.WriteLine("Nevalidní věk.");
}
```

🖥️ Výstup:

```
Nevalidní věk.
```

---

## ⚙️ Důležité:

* **Porovnání**:

    * Pro porovnání hodnot použijte **`==`** (např. `if (vek == 18)`).
    * **`!=`** znamená "nerovná se" (např. `if (vek != 18)`).
    * Pro porovnání velikosti použijte **`>`, `<`, `>=`, `<=`**.

* **Podmínky** jsou **case-sensitive** – `if (jmeno == "lukas")` není totéž jako `if (jmeno == "Lukas")`.
* Za podmínky **nepíšeme středníky**, protože nejsou příkazy.
* Každá podmínka musí mít **podmínkový blok** v () a **kódový blok** v {}
* `else if` nebo `else` nemůžou existovat bez přechozího `if`

---

## ⚠️ Pozor na časté chyby:

| **Špatně**                     | **Co je špatně**                           | **Správně**                           |
| ------------------------------ | ------------------------------------------ | ------------------------------------- |
| `if (vek = 18) { ... }`        | **Přiřazení** místo **porovnání**          | `if (vek == 18) { ... }`              |
| `if (vek == 18); { ... }`      | Zbytečný středník na konci podmínky        | `if (vek == 18) { ... }`              |
| `if (vek => 18)`               | **Chybný operátor** pro "větší nebo rovno" | `if (vek >= 18)`                      |
| `if (vek == 18) { ... } else;` | Chybí tělo pro `else`                      | `if (vek == 18) { ... } else { ... }` |
