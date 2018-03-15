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
            var names = new List<Human>
            {
                new Human(){Name = "Markus"},
                new Human(){Name = "Grete"},
                new Human(){Name = "Juhan"},
                new Human(){Name = "Sam"},
                new Human(){Name = "Stiven"},
                new Human(){Name = "Tanel"},
                new Human(){Name = "Kevin"},
                new Human(){Name = "Saskia"},
                new Human(){Name = "Kristi"}
            };

            #region Pikkuse järgi grupeerimine
            var nimed = (from x in names
                         group x by x.Name.Length into NewGroup
                         select NewGroup);

            Console.WriteLine("Nime pikkus: \n");
            foreach (var grupp in nimed)
            {
                foreach (var item in grupp)
                {
                    Console.WriteLine(item.Name + " - " +  item.Name.Length);
                }
            }


            #endregion



            Console.ReadLine();
        }
    }
}
