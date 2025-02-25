namespace VideotekaOOP;

internal class Videoteka

{
    public List<Film> Filmek { get; private set; }
    public List<Felhasznalo> Felhasznalok { get; private set; }

    public Videoteka()
    {
        Filmek = new List<Film>();
        Felhasznalok = new List<Felhasznalo>();
    }

    public void FilmHozzaadas(Film film)
    {
        Filmek.Add(film);
    }

    public void FelhasznaloHozzadas(Felhasznalo felhasznalo)
    {
        Felhasznalok.Add(felhasznalo);
    }

    public Film KeresFilm(string cim)
    {
        foreach (var film in Filmek)
        {
            if (film.Cim == cim)
            {
                return film;
            }
        }
        return null;
    }

    public Felhasznalo KeresFelhasznalo(string nev)
    {
        foreach (var felhasznalo in Felhasznalok)
        {
            if (felhasznalo.Nev == nev)
            {
                return felhasznalo;
            }
        }
        return null;
    }
}