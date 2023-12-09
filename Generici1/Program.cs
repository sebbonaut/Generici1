using Generici1;

Ocjene<int> Ann = new("Ann Doe");
Ann.Dodaj(4);
Ann.Dodaj(5);
Console.WriteLine(Ann);

Ocjene<string> John = new("John Doe");
John.Dodaj("vrlo dobar");
John.Dodaj("izvrstan");
Console.WriteLine(John);

Ocjene<string> Ivo = John.Kopiraj();
Ivo.Dodaj("dovoljan");
Console.WriteLine(John);


/*Ocjene<Film, double> JPark
    = new(new("Jurski Park", 1993));
JPark.Dodaj(4.25);
JPark.Dodaj(4.5);

Ocjene<Film, double> JPark2
    = new(new("Jurski Park 2", 1997));
JPark2.Dodaj(4);
JPark2.Dodaj(4);
JPark2.DodajDummy();
Console.WriteLine(JPark);
Console.WriteLine(JPark2); 


Console.WriteLine(Ocjene<Film, double>.Brojac); */

Ocjene<Film, BodoviFilma>[] f =
{
    new(new("Prvi",2000)),
    new(new("Drugi",2002)),
    new(new("Treci",2004))
};
f[0].Dodaj(new(1, 2, 3));
f[1].Dodaj(new(2, 4, 3));
f[1].Dodaj(new(3, 1, 4));
f[2].Dodaj(new(1, 2, 2));
foreach (var item in f)
{
    Console.WriteLine(item);
}
Sortiraj(f);
Console.WriteLine("Poslije sortiranja:");
foreach (var item in f)
{
    Console.WriteLine(item);
}
static void Sortiraj<T>(T[] niz) where T : IComparable<T>
{
    for(int i = 0; i < niz.Length - 1; i++)
        for(int j = i + 1; j < niz.Length; j++)
            if (niz[i].CompareTo(niz[j]) < 0)
                Zamijeni(ref niz[i], ref niz[j]);
}

static void Zamijeni<T>(ref T x, ref T y)
{
    T temp = x;
    x = y; 
    y = temp;
}
