using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace nepesseg
{
    internal class Program
    {
        static List<Orszag> orszagok = new List<Orszag>();
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            sr.ReadLine(); // fejléc átugrása
            while (!sr.EndOfStream)
            {
                orszagok.Add(new Orszag(sr.ReadLine()));
            }
            Console.WriteLine($"A beolvasott országok száma: {orszagok.Count}.");
            sr.Close();
        }
        static void KinaNepsurusege()
        {
            foreach (var o in orszagok)
            {
                if (o.Orszagnev == "Kína")
                {
                    Console.WriteLine($"Kína népsűrűsége: {o.Nepsuruseg()} fő/km^2.");
                }
            }
        }
        static void KinaEsIndia()
        {
            int kinaL = 0;
            int indiaL = 0;
            foreach (var o in orszagok)
            {
                if (o.Orszagnev == "Kína")
                {
                    kinaL = o.Nepesseg;
                }
                if (o.Orszagnev == "India")
                {
                    indiaL = o.Nepesseg;
                }
            }
            Console.WriteLine($"Kinában a lakosság {kinaL - indiaL} fővel volt több.");
        }
        static void HarmadikLegnepszerubb()
        {
            int harmadikIndex = 0;
            for (int i = 0; i < orszagok.Count; i++)
            {
                if (orszagok[i].Orszagnev != "Kína" && orszagok[i].Orszagnev != "India" && orszagok[i].Nepesseg > orszagok[harmadikIndex].Nepesseg)
                {
                    harmadikIndex = i;
                }
            }
            Console.WriteLine($"A harmadik legnépesebb ország: {orszagok[harmadikIndex].Orszagnev}, a lakosság {orszagok[harmadikIndex].Nepesseg} fő.");
        }
        static void Meghaladja()
        {
            foreach (var o in orszagok)
            {
                if (o.Meghaladja())
                {
                    Console.WriteLine($"\t{o.Orszagnev} ({o.Fovaros})");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("4. feladat");
            Beolvasas();
            Console.WriteLine();

            Console.WriteLine("5. feladat");
            KinaNepsurusege();
            Console.WriteLine();

            Console.WriteLine("6. feladat");
            KinaEsIndia();
            Console.WriteLine();

            Console.WriteLine("7. feladat");
            HarmadikLegnepszerubb();
            Console.WriteLine();

            Console.WriteLine("8. feladat - A következő országok lakosságának több mint 30%-a a fővárosban lakik:");
            Meghaladja();

            Console.ReadKey();
        }
    }
}
