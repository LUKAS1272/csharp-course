# 📘 Shrnutí třetí lekce

| Téma                      | Příklad                                         | Poznámka                                               |
| ------------------------- | ----------------------------------------------- | ------------------------------------------------------ |
| Pole (`array`)            | `int[] cisla = { 5, 10, 15 };`                  | Ukládá **víc hodnot stejného typu**                    |
| Vytvoření pole            | `string[] jidla = new string[3];`               | Vytvoří pole o dané velikosti (zatím prázdné) |
| Délka pole                | `cisla.Length`                                  | Vrací počet prvků v poli                               |
| Indexy                    | `cisla[0]`, `cisla[1]`                          | První prvek má **index 0**, poslední `cisla.Length - 1`      |
| Metoda bez parametru      | `void Pozdrav() { ... }`                        | Vlastní „funkce“, která jen něco udělá                 |
| Metoda s parametrem       | `void PozdravJmenem(string jmeno) { ... }`      | Metoda dostává **vstupní hodnotu** (parametr)          |
| Metoda pracující s polem  | `void VypisPole(string[] pole) { ... }`         | Metodě předáme pole a ona ho zpracuje / vypíše         |
