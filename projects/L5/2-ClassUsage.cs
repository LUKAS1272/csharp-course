namespace Lekce5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postava hrac = new Postava();
            hrac.jmeno = "Rytíř";
            hrac.zivoty = 100;
            hrac.sila = 15;

            Postava nepritel = new Postava();
            nepritel.jmeno = "Skřet";
            nepritel.zivoty = 50;
            nepritel.sila = 10;

            hrac.PredstavSe();
            nepritel.PredstavSe();

            hrac.Utoc(nepritel);
        }
    }
}