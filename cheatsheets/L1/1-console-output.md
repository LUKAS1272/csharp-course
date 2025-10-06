# 🖥️ Vypisování textu do konzole

## `Console.WriteLine()` a `Console.Write()`

### ✨ K čemu to je:

Aby náš program **něco napsal na obrazovku**.
"Konzole" = okno, kde program píše text - otevře se hned po spuštění.

---

## 💬 Dva způsoby, jak psát text:

```csharp
Console.WriteLine("Ahoj světe!");
Console.Write("Ahoj ");
Console.Write("světe!");
```

🖥️ Co uvidíš:

```
Ahoj světe!
Ahoj světe!
```

🧩 Rozdíl:

* 🟢 `Console.WriteLine()` → napíše text **a skočí na nový řádek**
* 🔵 `Console.Write()` → napíše text **a zůstane na stejném řádku**

---

## ⚙️ Důležité:

1. **C# rozlišuje velká a malá písmena**
   → `Console` není to samé jako `console`
2. **Každý příkaz musí končit středníkem `;`**
3. **Text musí být v uvozovkách `" "`.**

---

## ⚠️ Pozor na časté chyby:

| Špatně                       | Co je špatně           | Správně                      |
| ---------------------------- | ---------------------- | ---------------------------- |
| `console.writeline("ahoj")`  | špatná velikost písmen | `Console.WriteLine("ahoj");` |
| `Console.WriteLine("ahoj")`  | chybí `;`              | `Console.WriteLine("ahoj");` |
| `Console.WriteLine(ahoj);`   | chybí uvozovky         | `Console.WriteLine("ahoj");` |
| `Console.WriteLine('ahoj');` | špatný typ uvozovek    | `Console.WriteLine("ahoj");` |
