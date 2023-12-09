using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generici1
{
    internal class BodoviFilma : IProsjek
    {
        int g = 1, r = 1, s = 1;
        public BodoviFilma() { }
        public BodoviFilma(int g, int r = 1, int s = 1)
        {
            this.g = g;
            this.r = r;
            this.s = s;
        }

        public double Prosjek()
            => (g + r + s) / 3;

        public override string ToString()
            => $"Gluma: {g}, rezija: {r}, scenarij: {s}";
    }
    internal class Film
    {
        public string naziv;
        public int godina;
        public Film(string naziv, int godina)
        {
            this.naziv = naziv;
            this.godina = godina;
        }
        public override string ToString()
            => naziv + " (" + godina + ")";
    }
}
