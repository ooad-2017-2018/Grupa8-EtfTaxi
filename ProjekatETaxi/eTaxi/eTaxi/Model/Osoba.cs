using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace eTaxi.Model
{
    abstract public class Osoba
    {
        String Ime { get; set; }
        String Prezime { get; set; }
        String EMail { get; set; }
        String Lozinka { get; set; }
        Image Slika { get; set; }

        public Osoba(string ime, string prezime, string eMail, string lozinka, Image slika)
        {
            Ime = ime;
            Prezime = prezime;
            EMail = eMail;
            Lozinka = lozinka;
            Slika = slika;
        }
    }
}
