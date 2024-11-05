using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9
{
    public class Kniha
    {
        public string Nazev;
        public string Autor;
        public DateTime DatumVydani;
        public string Zanr;
        public int PocetStran;

        public Kniha(string nazev, string autor, DateTime datumVydani, string zanr, int pocetStran)
        {
            Nazev = nazev;
            Autor = autor;
            DatumVydani = datumVydani;
            Zanr = zanr;
            PocetStran = pocetStran;
        }

        public string ConvertBookToString()
        {
            return Nazev+";" +Autor + ";" + DatumVydani + ";" + Zanr + ";" + PocetStran;
        }
    }
}
