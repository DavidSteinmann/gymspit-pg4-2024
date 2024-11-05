using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9
{
    internal class Knihovna
    {
        List<Kniha> list;

        public Knihovna()
        {
            this.list = new List<Kniha>();
        }

        void Add(Kniha kniha)
        {
            list.Add(kniha);
        }

        public void Remove(Kniha kniha)
        {
            list.Remove(kniha);
        }

        Kniha GetBookByName(string name)
        {
            //bool Comparison(Kniha kniha)
            //{
            //    return kniha.Nazev == name;
            //}
            //return list.Find(Comparison);

            //return list.Find(book =>
            //{
            //    return book.Nazev == name;
            //});

            return list.Find(x => x.Nazev == name);
        }

        Kniha? GetBookByZanr(string zanr)
        {
            return list.Find(x => x.Zanr == zanr);
        }

        Kniha? GetBookByPocetStran(int pocetStran)
        {
            return list.Find(x => x.PocetStran == pocetStran);
        }

        Kniha? GetBookByAutor(string autor)
        {
            return list.Find(x => x.Autor == autor);
        }

        IEnumerable<Kniha> GetBooksByNameAlphabetically()
        {
            return list.OrderBy(x => x.Nazev);
        }

        void SaveToFile(string fileName)
        {
            File.WriteAllLines(fileName,
                list.Select(x => x.ConvertBookToString()));
        }

        int amountOfBooks()
        {
            return list.Count();
        }

        int pageAvg()
        {
            int totalPages=0;
           foreach(Kniha k in list)
            {
                totalPages += k.PocetStran; 
            }
            return totalPages / list.Count(); 
        }

        Kniha oldestBook()
        {
            return list.OrderBy(x => x.DatumVydani).First();
        }

        Kniha newestBook()
        {
            return list.OrderBy(x => x.DatumVydani).Last();
        }

        int booksInGenre(string genreName)
        {
            return list.Where(x => x.Zanr == genreName).Count();
        }
    }
}
