using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Berek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sorok = File.ReadAllLines("berek2020.txt").Skip(1).ToList();

            // File soraiból objektumok listája:
            List<Ber> berek = new List<Ber>();
            foreach (string sor in sorok)
            {
                berek.Add(new Ber(sor));
            }

            // Ua, mint a fenti, csak egy sorba:
            List<Ber> berek2 = sorok.Select(x => new Ber(x)).ToList();

            List<Ber> berLista = File.ReadAllLines("berek2020.txt").Skip(1).Select(x => new Ber(x)).ToList();


            // 6.feladat bool-nel  --> férfi vagy nő:

            string keresettReszleg = "beszerzés";

            if (berLista.Any(x => x.Reszleg == keresettReszleg))

            {
                Ber maxFizu = berLista.Where(x => x.Reszleg == keresettReszleg).MaxBy(x => x.DolgozoBer);

                Console.WriteLine($"\tNév: {maxFizu.Nev}\n\t Neme:{(maxFizu.Nem ? "nő" : "férfi")}" +
                    $"\n\t Belépés: {maxFizu.Belepes} \n\tBér:{maxFizu.DolgozoBer:n3} Forint");
            }
            else
            {
                Console.WriteLine("Nincs ilyen részleg!");
            }
           

        }
    }
}
