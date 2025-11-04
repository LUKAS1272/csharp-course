# Instalace Visual Studio Community 2022

Visual Studio Community 2022 je bezplatné vývojové prostředí od společnosti **Microsoft**, určené pro jednotlivce, studenty a malé týmy. Nabízí kompletní sadu nástrojů pro vývoj aplikací v jazycích jako **C#, C++, Python, .NET, JavaScript** a mnoho dalších. My ho využijeme pro tvorbu jednoduchých konzolových aplikací v jazyce C#.

---

## 1. Stažení instalátoru

1. Otevřete oficiální stránku: [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)
2. Klikněte na tlačítko **"Free download"** u edice *Visual Studio Community 2022*.

![Stažení instalátoru Visual Studio 2022](../resources/image-assets/vs-download.png)

### Pozor
**Je důležité si nesplést VisualStudio 2022 a Visual Studio Code. Pro instalaci VSC je potřeba jiný postup, na který se tento manuál nesoustředí a tato metodika.**

---

## 2. Spuštění instalátoru

Po stažení souboru `VisualStudioSetup.exe` jej spusťte.
Instalátor nejprve stáhne potřebné součásti.

![Instalátor Visual Studio](../resources/image-assets/installing.png)

---

## 3. Výběr Workloads

1. Zobrazí se nabídka modulů - pro toto školení je třeba nainstalovat *.NET desktop development*.

![Výběr Workloads](../resources/image-assets/modules.png)

2. V záložce *Language packs* vyberte požadované jazyky vývojového prostředí. Tato metodika využívá anglické (English) prostředí pro výuku.

![Výběr Workloads](../resources/image-assets/languages.png)

---

## 4. Instalace

1. Klikněte na **"Install"**, případně *"Modify"*.
    - Instalace může trvat několik minut podle zvolených komponent a rychlosti internetu.

![Instalace probíhá](../resources/image-assets/modules-installing.png)

2. Pokud nechcete, aby se Visual Studio spustilo ihned po instalaci, nechte zatržítko **"Start after installation"** nazaškrtnuté

---

## 5. První spuštění

1. Po dokončení instalace spusťte Visual Studio. (případně se spustí automaticky)
2. Můžete přihlásit pomocí účtu Microsoft a zvolit barevné téma.
    - Přihlášení není pro toto školení nutné, lze pokračovat bez přihlášení -> klikněte na **"Skip and add accounts later."**

![První spuštění Visual Studio 2022](../resources/image-assets/first-launch.png)

![Výběr barevného téma](../resources/image-assets/choose-theme.png)

---

## 6. Vytvoření nového projektu

1. Klikněte na **"Create a new project"**

![Vytvoření prvního projektu](../resources/image-assets/get-started.png)

2. Vyberte šablonu **Console App (C#)**.

![Vytvoření prvního projektu](../resources/image-assets/choose-template.png)

3. Projekt pojmenujete
4. Vyberte verzi frameworku (ideálně nejnovější LTS, tato metodika pracuje s **.NET 8.0 LTS**)
5. Vyberte, zda chcete použít "top-level statements"
    - Top-level statements jsou ideální pro jednoduché programy, kde se nevyužívají metody, nebo třídy
    - V prvních 2 lekcích se pracuje s touto možností

![Vyplnění dodatečných informací](../resources/image-assets/additional-information.png)

### Top-level statements kód
```csharp
Console.WriteLine("Hello World!");
```

### Low-level statements kód
```csharp
namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```