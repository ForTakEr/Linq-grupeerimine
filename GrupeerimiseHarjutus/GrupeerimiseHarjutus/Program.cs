using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupeerimiseHarjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Markus",
                "Grete",
                "Juhan",
                "Sam",
                "Stiven",
                "Tanel",
                "Kevin",
                "Saskia",
                "Kristi"
            };

            #region Pikkuse järgi grupeerimine
            Console.WriteLine("1.Pikkused:\n");
            var Nimed = (from nimi in names
                         orderby nimi ascending
                         select nimi).ToList();

            foreach (var item in Nimed)
            {
                Console.WriteLine("Nimi: " + item + " | tähti: " + item.Count());
            }

            var pikkused = from nimi in Nimed
                           group nimi.Length by nimi.Length into x
                           select x;

            Console.WriteLine();

            foreach (var item in pikkused)
            {
                Console.WriteLine("{0} tähti = {1} nime", item.Key, item.Count());
            }

            #endregion

            Console.ReadLine();
        }
    }
}
