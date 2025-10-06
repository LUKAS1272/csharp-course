# 🧩 Proměnné a datové typy

## 🧠 Co je proměnná:

Proměnná je jako **krabička s názvem**, do které si program uloží nějakou hodnotu (např. číslo, text nebo pravda/nepravda).
Když potřebuje hodnotu použít, "otevře krabičku".

---

## 🧩 Příklad:

```csharp
int vek = 13;
string jmeno = "Tereza";
bool maRadProgramovani = true;

Console.WriteLine("Ahoj, " + jmeno + "!");
Console.WriteLine("Je ti " + vek + " let.");
```

🖥️ Výstup:

```
Ahoj, Tereza!
Je ti 13 let.
```

---

## 🧮 Základní typy proměnných:

| Typ      | Příklad          | Co znamená        | Poznámka                                               |
| -------- | ---------------- | ----------------- | ------------------------------------------------------ |
| `int`    | `12`             | celé číslo        |                                                        |
| `double` | `3.14`           | desetinné číslo   | místo desetinné čarky - "desetinná tečka"              |
| `string` | `"Ahoj"`         | text              | používáme dvojité uvozovky                             |
| `bool`   | `true` / `false` | pravda / nepravda | true, false se píšou bez uvozovek                      |
| `char`   | `'A'`            | jeden znak        | používáme jednoduché uvozovky                          |

---

## ✍️ Jak proměnnou vytvořit:

```
typ jméno = hodnota;
```

📘 Příklady:

```csharp
int pocetZivotu = 5;
string pozdrav = "Ahoj!";
bool konecHry = false;
```

---

## 💡 Tipy:

* Proměnné pojmenovávej **srozumitelně**:
  ✅ `pocetZivotu`
  ❌ `pzl`
* Do jména **nepatří mezery**! Místo mezer použij **velké písmeno**:
  ✅ `mojeSkore`
* Hodnotu můžeš kdykoli změnit:

```csharp
pocetZivotu = 3;
```