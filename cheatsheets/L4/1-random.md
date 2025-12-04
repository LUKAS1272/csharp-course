# Náhoda v C#

## 1. Vytvoření generátoru náhody

```csharp
Random generator = new Random();
```

> **Důležité:** Vytvoř **jeden** objekt `Random` a ten používej v celém programu.
> Nevytvářej `new Random()` v každém cyklu.

---

## 2. Metody třídy `Random`

| Příkaz                    | Co dělá                                                     |
| ------------------------- | ----------------------------------------------------------- |
| `generator.Next(10)`      | Náhodné **int** od `0` do `9` (max je vždy bez)             |
| `generator.Next(1, 7)`    | Náhodné **int** od `1` do `6` (dolní mez včetně, horní bez) |
| `generator.Next(50, 101)` | Náhodné **int** od `50` do `100`                            |
| `generator.NextDouble()`  | Náhodné **double** `0.0` až `< 1.0`                         |

## Příklad – několik hodů kostkou

```csharp
Random generator = new Random();

for (int i = 0; i < 5; i++)
{
    int hod = generator.Next(1, 7); // 1–6
    Console.WriteLine("Hod č. " + (i + 1) + ": " + hod);
}
```

---

## ⚙️ Tipy

* Kostka `1–6` → **vždy** `Next(1, 7)`
* Náhodné číslo do 100 včetně → `Next(0, 101)`
* Náhodný index do pole → `Next(0, pole.Length)`

---

## ⚠️ Časté chyby s `Random`

| Špatně                               | Problém                                     | Správně                          |
| ------------------------------------ | ------------------------------------------- | -------------------------------- |
| `Random gen = new Random();` v cyklu | Příliš mnoho generátorů, často stejná čísla | Vytvořit `Random` **jen jednou** |
| `generator.Next(1, 6)` pro kostku    | Nikdy nepadne `6`                           | `generator.Next(1, 7)`           |
| `Next(0, 10)` na pole s 5 prvky      | Index může být `5–9` → chyba                | `Next(0, pole.Length)`           |
| `generator Next(1, 7);`              | Chybí tečka                                 | `generator.Next(1, 7);`          |
| `generator.Next;`                    | Chybí závorky (metoda bez volání)           | `generator.Next(1, 7);`          |
