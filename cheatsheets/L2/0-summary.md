# 📘 Shrnutí druhé lekce

| Téma                             | Příklad                                 | Poznámka                                                                     |
| -------------------------------- | --------------------------------------- | ---------------------------------------------------------------------------- |
| Uživatelský vstup                | `Console.ReadLine();`                   | Počká na vstup od uživatele a vrátí vepsanou hodnotu (funguje jako proměnná) |
| Podmínky (`if`, `else`)          | `if (vek >= 18) { ... }`                | Rozhodnutí na základě podmínky                                               |
| Cykly (`for`, `while`)           | `for (int i = 0; i < 5; i++) { ... }`   | Opakování kódu na základě podmínky                                           |
| Syntaxe                          | `;` se za podmínkami a cykly **nepíše** |                                                                              |

## Podmínky

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

## Cyklus for

```csharp
// V podmínkovém bloku - inicializace (vytvoření proměnné), podmínka, inkrementace (zvýšení hodnoty)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Opakuji se!");
}
```

## Cyklus while

```csharp
int i = 0;

// V podmínkovém bloku jen podmínka
while (i < 5)
{
    Console.WriteLine("Opakuji se!");
    i++; // Inkrementace (zvýší o 1 hodnotu i)
}
```