# Třídy v C#

## 1. Co je třída?

**Třída** = šablona/návod, jak má objekt vypadat  
**Objekt** = konkrétní věc vytvořená podle třídy

### Příklad
- Třída `Auto` → objekty: červené auto, modré auto
- Třída `Postava` → objekty: hráč, nepřítel

---

## 2. Vytvoření třídy

### Ve Visual Studiu:
1. Pravé tlačítko na projekt → **Add → Class**
2. Pojmenuj (např. `Postava.cs`)

### Základní struktura:

```csharp
class Postava
{
    // Vlastnosti (data)
    public string jmeno;
    public int zivoty;
    public int sila;
}
```

> **Důležité:** Vlastnosti musí být `public`, jinak k nim nelze přistoupit mimo třídu.

---

## 3. Metody ve třídě

```csharp
class Postava
{
    public string jmeno;
    public int zivoty;
    
    // Metoda bez parametrů
    public void PredstavSe()
    {
        Console.WriteLine("Jsem " + jmeno + " a mám " + zivoty + " životů.");
    }
    
    // Metoda s parametrem
    public void Utoc(Postava cil)
    {
        Console.WriteLine(jmeno + " útočí na " + cil.jmeno + "!");
        cil.zivoty = cil.zivoty - 10;
    }
}
```

---

## 4. Použití třídy

```csharp
static void Main(string[] args)
{
    // Vytvoření objektu
    Postava hrac = new Postava();
    
    // Nastavení vlastností
    hrac.jmeno = "Rytíř";
    hrac.zivoty = 100;
    hrac.sila = 15;
    
    // Volání metody
    hrac.PredstavSe();
}
```

---

## 5. Klíčové slovo `this`

`this` = odkaz na **aktuální objekt**

```csharp
public void Utoc(Postava cil)
{
    // this.sila = síla TOHOTO objektu (útočníka)
    // cil.zivoty = životy JINÉHO objektu (cíle)
    cil.zivoty = cil.zivoty - this.sila;
}
```

---

## ⚠️ Časté chyby

| Špatně                  | Problém                        | Správně                         |
| ----------------------- | ------------------------------ | ------------------------------- |
| `Postava hrac;`         | Objekt nebyl vytvořen          | `Postava hrac = new Postava();` |
| `class postava`         | Malé písmeno                   | `class Postava`                 |
| `string jmeno;`         | Bez `public`                   | `public string jmeno;`          |
| `new Postava;`          | Chybí závorky                  | `new Postava();`                |
