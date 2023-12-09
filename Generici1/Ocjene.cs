using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generici1
{
    internal class Ocjene<T>
    {
        public Ocjene<T> Kopiraj()
        {
            Ocjene<T> kopija = new(id);
            foreach (var ocjena in ocjene)
            {
                kopija.ocjene.Add(ocjena);
            }
            return kopija;
        }
        string id;
        List<T> ocjene = [];
        public Ocjene(string id)
            => this.id = id;
        public void Dodaj(T ocjena)
            => ocjene.Add(ocjena);
        public override string ToString()
        {
            string poruka = id + ":";
            foreach (var ocjena in ocjene)
                poruka += " " + ocjena?.ToString();
            return poruka;
        }
    }
    internal class CjelobrojneOcjene : Ocjene<int>
    {
        public CjelobrojneOcjene(string id) : base(id) { }
    }
    internal interface IProsjek
    {
        double Prosjek();
    }
    internal class Ocjene<TObjekt, TOcjene> : IComparable<Ocjene<TObjekt, TOcjene>>
        where TObjekt : class
        where TOcjene : IProsjek, new()
    {
        public static int Brojac;
        TObjekt objekt;
        List<TOcjene> ocjene;
        public void DodajDummy()
            => ocjene.Add(new());
        public Ocjene(TObjekt objekt)
        {
            Brojac++;
            this.objekt = objekt;
            ocjene = [];
        }
        public void Dodaj(TOcjene ocjena)
            => ocjene.Add(ocjena);
        public override string ToString()
        {
            string poruka = "Objekt: " + objekt?.ToString();
            foreach (var ocjena in ocjene)
                poruka += "\n\t" + ocjena?.ToString();
            return poruka;
        }

        public int CompareTo(Ocjene<TObjekt, TOcjene>? other)
            => (other == null) ? -1 :
            Prosjek.CompareTo(other.Prosjek);

        public double Prosjek
            => (ocjene is null) ? -1 :
                    ocjene.ConvertAll(x => x.Prosjek()).Average();
    }
    /* internal class CjelobrojneOcjene<T> : Ocjene<T, int>
    {
        public CjelobrojneOcjene(T objekt) : base(objekt) { }
    } */
}
