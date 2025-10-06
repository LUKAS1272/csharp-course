# 🎨 Barvy textu a pozadí v konzoli

## `Console.ForegroundColor` a `Console.BackgroundColor`

---

## ✨ K čemu to je:

Pomocí těchto příkazů můžeš **obarvit text nebo pozadí**.
Je to zábavné a dělá program přehlednější!

---

## 🧩 Příklad:

```csharp
Console.ForegroundColor = ConsoleColor.Yellow; // text žlutě
Console.BackgroundColor = ConsoleColor.Blue; // pozadí modře
Console.WriteLine("Barevný text!");
Console.ResetColor(); // vrátí barvy zpět
```

🖥️ Výsledek: žlutý text na modrém pozadí 🎨

---

## 🎨 Barvy, které můžeš použít:

```
ConsoleColor.Black
ConsoleColor.Blue
ConsoleColor.Red
ConsoleColor.Green
ConsoleColor.Yellow
ConsoleColor.White
ConsoleColor.Magenta
ConsoleColor.Cyan
```

---

## ⚠️ Důležité:

Tyto příkazy **nevoláme** (nemají závorky `()`), ale **přiřazujeme jim hodnotu pomocí `=`**.

- ❌ `Console.ForegroundColor(ConsoleColor.Red);`
- ✅ `Console.ForegroundColor = ConsoleColor.Red;`

🧠 "Přiřazujeme barvu", ne "voláme funkci".