
# Čtení vstupu uživatele

## `Console.ReadLine()`

Metoda `Console.ReadLine()` umožňuje číst **vstup od uživatele** z konzole. Uživatel zadá text a tento text bude vrácen jako **řetězec (string)**.

---

## 💡 Použití `Console.ReadLine()`:

Tato metoda je běžně používaná pro získání vstupu od uživatele ve formě textu. 

```csharp
Console.WriteLine("Zadejte své jméno:");
string jmeno = Console.ReadLine(); // Uživatelský vstup
Console.WriteLine("Ahoj, " + jmeno + "!");
```

🖥️ Výstup (pokud uživatel zadá `Jan`):

```
Zadejte své jméno:
Jan
Ahoj, Jan!
```

---

## ⚠️ Uložení hodnoty

`Console.ReadLine()` funguje jako proměnná. Když ho umístím samotný na řádek, ale jeho hodnotu **nikde nepoužiju**, kód se pouze pozastaví. Uživatelův vstup se ale **nikam neuloží**.

```csharp
Console.ReadLine(); // Příklad špatného použití. Hodnotu nikam neukládám.
```

---

## ⚙️ Důležité:

* `Console.ReadLine()` **vrací** vždy **řetězec** (string).
* Kód bude pozastavený, dokud uživatel nepotvrdí hodnotu.
* Pokud uživatel nezadá nic a stiskne **Enter**, metoda vrátí **prázdný řetězec**.

---

## ⚠️ Pozor na časté chyby:

| **Špatně**                                            | **Co je špatně**                                                              | **Správně**                           |
| ----------------------------------------------------- | -------------------------------------------------------------------------     | ------------------------------------- |
| `Console.ReadLine();`                                 | Hodnotu nikam neukládám, jen se pozastaví program, než uživatel zadá vstup    | `string jmeno = Console.ReadLine();`  |
| `int vek = Console.ReadLine();`                       | ReadLine() vždy vrací řetězec. Jeho výsup nelze uložit do číselné proměnné.   | `string jmeno = Console.ReadLine();`  |
| `string jmeno = ReadLine();`                          | Nekompletní příkaz, zapomenutí "Console"                                      | `string jmeno = Console.ReadLine();`  |