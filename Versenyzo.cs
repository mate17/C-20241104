using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_20241104
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int Szulev { get; set; }
        public int Rajtszam { get; set; }
        public bool Nem { get; set; }
        public string Kategoria { get; set; }
        public Dictionary<string, TimeSpan> Idok { get; set; }

        public override string ToString()
        {
            return $"[{Rajtszam}] {Nev} ({Kategoria})";
        }

        public int Osszido => (int)Idok.Values.Sum(x => x.TotalSeconds);

        public Versenyzo(string sor)
        {
            string[] s = sor.Split(";");
            Nev = s[0];
            Szulev = int.Parse(s[1]);
            Rajtszam = int.Parse(s[2]);
            if (s[3] == "f")
            {
                Nem = true;
            }
            else
            {
                Nem = false;
            }
            Kategoria = s[4];
            Idok = new()
            {
                {"uszas", TimeSpan.Parse(s[5])},
                {"I depo", TimeSpan.Parse(s[6])},
                {"kerekparozas", TimeSpan.Parse(s[7])},
                {"II depo", TimeSpan.Parse(s[8])},
                {"futas", TimeSpan.Parse(s[9])}
            };
        }
    }
}
