# Metody (vlastní funkce)

## 1. Co je metoda?

Metoda = pojmenovaný blok kódu, který:

* můžeme **znovu použít**,
* může mít **parametry** (vstupy),
* může (ale nemusí) vracet hodnotu.

> V této lekci používáme hlavně metody typu `void` – **nic nevrací**, něco prostě udělají.

---

## 2. Metoda bez parametru

```csharp
void Pozdrav()
{
    Console.WriteLine("Ahoj programátore!");
}

// Volání:
Pozdrav();
Pozdrav();
```

---

## 3. Metoda s parametrem

```csharp
void PozdravJmenem(string jmeno)
{
    Console.WriteLine("Ahoj, " + jmeno + "!");
}

// Volání:
PozdravJmenem("Eliška");
PozdravJmenem("Adam");
```

* Parametr = **proměnná**, která se nastaví při volání metody.

---

## 4. Metoda, která pracuje s polem

```csharp
void VypisPole(string[] pole)
{
    int i = 0;

    while (i < pole.Length)
    {
        Console.WriteLine("- " + pole[i]);
        i++;
    }
}

// Použití:
string[] jidla = { "Pizza", "Sushi", "Salát" };
VypisPole(jidla);
```

> Metodě předáme **odkaz na pole** a ona s ním pracuje (vypisuje, počítá, ...).

---

## 5. Struktura metody

```csharp
<typ_návratu> <NázevMetody>(<parametry>)
{
    // tělo metody – co se stane při volání
}
```

---

## ⚠️ Typické chyby u metod

| Špatně                                                                    | Problém                                 | Správně                                        |
| ------------------------------------------------------------------------- | --------------------------------------- | ---------------------------------------------- |
| `void Pozdrav;`                                                           | Chybí závorky → není to definice metody | `void Pozdrav()`                               |
| `Pozdrav;`                                                                | Metoda se **nezavolá**, jen je napsaná  | `Pozdrav();`                                   |
| `void Vypis(string text)`<br>`{ Console.WriteLine(text); }`<br>`Vypis();` | Při volání chybí **parametr**           | `Vypis("Ahoj");`                               |
| Dvě metody se stejným jménem                                              | Kolize, kompilátor neví, kterou použít  | Pro každou metodu mít unikátní jméno |
