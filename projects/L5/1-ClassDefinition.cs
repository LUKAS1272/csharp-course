class Postava
{
    public string jmeno;
    public int zivoty;
    public int sila;

    public void PredstavSe()
    {
        Console.WriteLine("Jsem " + jmeno + " a mám " + zivoty + " životů.");
    }

    public void Utoc(Postava cil)
    {
        Console.WriteLine(jmeno + " útočí na " + cil.jmeno + "!");
        cil.zivoty = cil.zivoty - this.sila;
        Console.WriteLine(cil.jmeno + " má nyní " + cil.zivoty + " životů.");
    }
}