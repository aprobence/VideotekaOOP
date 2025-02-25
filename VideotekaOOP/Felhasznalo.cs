namespace VideotekaOOP;

internal class Felhasznalo
{
    public string Nev { get; private set; }
    public List<Film> KikolcsonzottFilmek { get; private set; }

    public Felhasznalo(string nev)
    {
        Nev = nev;
        KikolcsonzottFilmek = new List<Film>();
    }

    public bool Kolcsonoz(Film film)
    {
        if (KikolcsonzottFilmek.Count == 3 || KikolcsonzottFilmek.Contains(film))
        {
            Console.WriteLine("Már háromnál több filmet kölcsönöztél ki, többet nem tudsz.");
            return false;
        }
        else
        {
            KikolcsonzottFilmek.Add(film);
            return true;
        }
    }

    public bool Visszaad(Film film)
    {
        if (KikolcsonzottFilmek.Contains(film))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}