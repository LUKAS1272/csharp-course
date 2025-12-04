# Pole (`array`) v C#

## 1. Proč pole?

Bez pole:

```csharp
int cislo1 = 5;
int cislo2 = 10;
int cislo3 = 15;
// Co kdybychom měli 100 čísel?
```

S polem:

```csharp
int[] cisla = { 5, 10, 15 };
```

> Pole = **jedna proměnná**, která v sobě drží **víc hodnot stejného typu**.

---

## 2. Vytvoření pole

### a) Pole s hodnotami hned při vytvoření

```csharp
int[] cisla = { 5, 10, 15, 20 };
string[] jmena = { "Anna", "Petr", "Ema" };
```

### b) Pole s danou velikostí (vytvoří se prázdný array - hodnoty se doplní později)

```csharp
string[] jidla = new string[3]; // 3 prvky: jidla[0], jidla[1], jidla[2]

jidla[0] = "Pizza";
jidla[1] = "Sushi";
jidla[2] = "Salát";
```

---

## 3. Indexy a přístup k prvkům

```csharp
int[] cisla = { 5, 10, 15 };
Console.WriteLine(cisla[0]); // 5
Console.WriteLine(cisla[1]); // 10
Console.WriteLine(cisla[2]); // 15
```

| Prvek | Hodnota | Index |
| ----- | ------- | ----- |
| 1.    | 5       | 0     |
| 2.    | 10      | 1     |
| 3.    | 15      | 2     |

> **Pozor:** První platný index je **0**. Poslední platný index je **`Length - 1`** (v tomto případě **2**).

---

## 4. Délka pole – `Length`

```csharp
int[] cisla = { 5, 10, 15, 20 };
Console.WriteLine("Délka pole: " + cisla.Length); // 4
```

Použití v cyklu:

```csharp
int i = 0;

while (i < cisla.Length)
{
    Console.WriteLine("Prvek " + i + ": " + cisla[i]);
    i++; // Zvýšení hodnoty proměnné 'i' o 1
}
```

---

## ⚠️ Typické chyby u polí

| Špatně                                    | Problém                                             | Správně                           |
| ----------------------------------------- | --------------------------------------------------- | --------------------------------- |
| `string[] jidla = string[3];`             | Chybí `new`                                         | `string[] jidla = new string[3];` |
| `jidla[3] = "Pizza";`                     | Index `3` neexistuje (pro velikost 3 jsou 0–2)      | Poslední prvek je `jidla[2];`     |
| `Console.WriteLine(jidla);`               | Vypíše jen typ (`System.String[]`)                  | Vypisovat prvky v cyklu           |
| `while (i <= cisla.Length)` | O jeden prvek navíc, poslední index je `Length - 1` | `i < jidla.Length`                |
