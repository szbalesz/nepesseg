using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }

        public Orszag(string sor)
        {
            Orszagnev = sor.Split(';')[0];
            Terulet = int.Parse(sor.Split(';')[1]);
            Nepesseg = int.Parse(sor.Split(';')[2]);
            Fovaros = sor.Split(';')[3];
            FovarosNepesseg = int.Parse(sor.Split(';')[4]);
        }
        
        public int Nepsuruseg()
        {
            int ns;
            ns = Nepesseg / Terulet;

            return ns;
        }
    }

    }
