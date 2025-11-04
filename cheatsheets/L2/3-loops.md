# Cykly – `for`, `while`

## Co jsou cykly?

Cykly umožňují opakovat část kódu **tolikrát**, dokud je **splněna podmínka**. Používají se k efektivnímu provádění opakovaných úkolů.

---

## 💡 Cykly `while`:

* **`while` = dokud**
* Dokud je **podmínka pravdivá**, cyklus se **opakovaně vykonává**.

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine("Opakuji se!");
    i++; // Inkrementace (zvýší o 1 hodnotu i)
}
```

🖥️ Výstup:

```
Opakuji se!
Opakuji se!
Opakuji se!
Opakuji se!
Opakuji se!
```

## 💡 Cykly `for`:

Cykly `for` mají **3 části**:

1. **Inicializace** – vytvoření proměnné (počáteční hodnota).
2. **Podmínka** – cyklus pokračuje, dokud je podmínka **pravdivá**.
3. **Inkrementace** – zvýšení (nebo změna) hodnoty proměnné po každé iteraci.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Opakuji se!");
}
```

🖥️ Výstup:

```
Opakuji se!
Opakuji se!
Opakuji se!
Opakuji se!
Opakuji se!
```

---

## ⚙️ Důležité:

* Za cykly **nepíšeme středníky**, protože nejsou příkazy.
* Každý cyklus musí mít **podmínkový blok** v () a **kódový blok** v {}
* **Cykly `for`** jsou ideální, pokud víme, **kolikrát se má kód opakovat** (např. 5krát).
* **Cykly `while`** se hodí, pokud **nevíme** přesně počet opakování a chceme cyklus opakovat **dokud** není splněna podmínka.

---

## ⚠️ Pozor na časté chyby:

| **Špatně**                        | **Co je špatně**                                                     | **Správně**                             |
| --------------------------------- | -------------------------------------------------------------------- | --------------------------------------- |
| `while (i = 5)`                   | Použití přiřazení místo porovnání                                    | `while (i == 5)`                        |
| `for (int i = 0 i < 5 i++)`       | Chybí středníky mezi částmi podmínkového bloku                       | `for (int i = 0; i < 5; i++)`           |
| `while (true); { ... }`           | Středník se za cykly nepíše                                          | `while (true) { ... }`                  |
| `for (int i = 0; i < 5) { ... }`  | Zapomenutá inkrementace `i++`                                        | `for (int i = 0; i < 5; i++) { ... }`   |
| `for (int i = 0; i++) { ... }`    | Chybějící podmínka                                                   | `for (int i = 0; i < 5; i++) { ... }`   |
