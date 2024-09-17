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
            string[] adatok = sor.Split(';');
            Orszagnev = adatok[0];
            Terulet = int.Parse(adatok[1]);
            if (adatok[2].Contains("g"))
            {
                string ideiglenes = adatok[2];
                Nepesseg = int.Parse(ideiglenes.Substring(0, ideiglenes.Length - 1))*10000;
            }
            else
            {
                Nepesseg = int.Parse(adatok[2]);
            }
            Fovaros = adatok[3];
            FovarosNepesseg = int.Parse(adatok[4])*1000;
        }
        
        public int Nepsuruseg()
        {
            int ns;
            ns = Nepesseg / Terulet;

            return ns;
        }
        public bool Meghaladja()
        {
            if(Nepesseg*0.3 <= FovarosNepesseg)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    }
