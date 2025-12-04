# 📘 Shrnutí čtvrté lekce

| Téma                       | Příklad                                           | Poznámka                                                                  |
| -------------------------- | ------------------------------------------------- | ------------------------------------------------------------------------- |
| Náhodná čísla (`Random`)   | `Random gen = new Random();`<br>`gen.Next(1, 7);` | Generátor náhody, metoda `Next()` vrací celé náhodné číslo                |
| Náhodné double             | `gen.NextDouble();`                               | Vrací číslo `double` v intervalu `0.0` až `< 1.0`                         |
| Objekty a tečka            | `text.ToUpper();`<br>`cisla.Length`               | Objekty mají **metody** a **vlastnosti**, ke kterým se dostaneme přes `.` |
| Řetězce (`string`)         | `text.Length`, `text.ToLower()`                   | `string` je objekt – umí různé operace s textem                           |
| Pole (`int[]`, `string[]`) | `int[] cisla = new int[3];`<br>`cisla.Length`     | Pole má vlastnost `Length` – počet prvků                                  |

---

## 🎲 Random – základní použití

```csharp
// 1) Vytvořím JEDEN generátor náhody
Random generator = new Random();

// 2) Vygeneruju náhodné číslo 1–6 (hod kostkou)
int hod = generator.Next(1, 7);
Console.WriteLine("Padlo: " + hod);
```
