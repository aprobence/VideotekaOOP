namespace VideotekaOOP;

class Program
{
    static void Main(string[] args)
    {
        Videoteka videoteka = new Videoteka();

        videoteka.FilmHozzaadas(new Film("Titanic", "Dráma", 1997));
        videoteka.FilmHozzaadas(new Film("Inception", "Sci-Fi", 2010));
        videoteka.FilmHozzaadas(new Film("Interstellar", "Sci-Fi", 2014));
        videoteka.FilmHozzaadas(new Film("Joker", "Dráma", 2019));

        Felhasznalo anna = new Felhasznalo("Anna");;

        Film titanic = videoteka.KeresFilm("Titanic");
        if (titanic != null)
        {
            if (anna.Kolcsonoz(titanic))
            {
                titanic.Kolcsonzes();
                Console.WriteLine($"A(z) Titanic című filmet sikeresen kikölcsönözted.");
            }
        }

        Film interstellar = videoteka.KeresFilm("Interstellar");
        if (interstellar != null)
        {
            if (anna.Kolcsonoz(interstellar))
            {
                interstellar.Kolcsonzes();
                Console.WriteLine($"A(z) Interstellar című filmet sikeresen kikölcsönözted.");
            }
        }

        Film joker = videoteka.KeresFilm("Joker");
        if (joker != null)
        {
            if (anna.Kolcsonoz(joker))
            {
                joker.Kolcsonzes();
                Console.WriteLine($"A(z) Joker című filmet sikeresen kikölcsönözted.");
            }
        }

        Film inception = videoteka.KeresFilm("Inception");
        if (inception != null)
        {
            if (anna.Kolcsonoz(inception))
            {
                inception.Kolcsonzes();
                Console.WriteLine($"A(z) {inception.Cim} című filmet sikeresen kikölcsönözted.");
            }
            else
            {
                Console.WriteLine("Anna már 3 filmet kikölcsönzött, nem kérhet többet!");
            }
        }

        if (anna.Visszaad(titanic))
        {
            titanic.Visszavetel();
            Console.WriteLine($"A(z) {titanic.Cim} visszavétele sikeres.");
        }
    }
}