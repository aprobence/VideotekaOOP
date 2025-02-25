namespace VideotekaOOP;

internal class Film

{
    public string Cim {get; private set;} 
    public string Kategoria {get; private set;}
    public int KiadasiEv {get; private set;}
    public bool Kolcsonozve {get; private set;}

    public Film(string cim, string kategoria, int kiadasiEv)
    {
        Cim = cim;
        Kategoria = kategoria;
        KiadasiEv = kiadasiEv;
        Kolcsonozve = false;
    }

    public void Kolcsonzes()
    {
        Kolcsonozve = true;
        Console.WriteLine("A film ki lett kölcsönözve.");
    }

    public void Visszavetel()
    {
        Kolcsonozve = false;
        Console.WriteLine("A film visszavéve.");
    }
}