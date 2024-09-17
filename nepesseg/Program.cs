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
            Console.ReadKey();
        }
    }
}
