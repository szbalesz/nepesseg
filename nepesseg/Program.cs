using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            List<Orszag> orszagok = new List<Orszag>();
            sr.ReadLine(); // fejléc átugrása
            while (!sr.EndOfStream) 
            {
                orszagok.Add(new Orszag(sr.ReadLine()));
            }
            Console.WriteLine("4. feladat");
            Console.WriteLine($"A beolvasott országok száma: {orszagok.Count}.");
            Console.WriteLine();
            Console.WriteLine("5. feladat");
            foreach (var o in orszagok)
            {
                if (o.Orszagnev == "Kína")
                {
                    Console.WriteLine($"Kína népsűrűsége: {o.Nepsuruseg()} fő/km^2.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("6. feladat");
            int kinaL = 0;
            int indiaL = 0;
            foreach (var o in orszagok)
            {
                if (o.Orszagnev == "Kína")
                {
                    kinaL = o.Nepesseg;
                }
                if(o.Orszagnev == "India")
                {
                    indiaL = o.Nepesseg;
                }
            }
            Console.WriteLine($"Kinában a lakosság {kinaL-indiaL} fővel volt több.");
            Console.WriteLine();
            Console.WriteLine("7. feladat");
            int harmadikIndex = 0;
            for (int i = 0; i < orszagok.Count; i++)
            {
                if (orszagok[i].Orszagnev != "Kína" && orszagok[i].Orszagnev != "India" && orszagok[i].Nepesseg > orszagok[harmadikIndex].Nepesseg)
                {
                    harmadikIndex = i;
                }
            }
            Console.WriteLine($"A harmadik legnépesebb ország: {orszagok[harmadikIndex].Orszagnev}, a lakosság {orszagok[harmadikIndex].Nepesseg} fő.");
            Console.WriteLine("8. feladat - A következő országok lakosságának több mint 30%-a a fővárosban lakik:");
            foreach (var o in orszagok)
            {
                if (o.Meghaladja())
                {
                    Console.WriteLine($"\t{o.Orszagnev} ({o.Fovaros})");
                }
            }
            Console.ReadKey();
        }
    }
}
