using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace eTaxi.Model
{
    public class Vozac : Osoba
    {
        Region Region { get; set; } 
        String JMBG { get; set; }
        String BrojTelefona { get; set; }
        String BrojKartice { get; set; }
        String RadnoIskustvo { get; set; }
        StatusVoznje StatusVoznje { get; set; }
        StatusZaposlenja StatusZaposlenja { get; set; }
        Auto Auto { get; set; }
        double Ocjena { get; set; }
        List<String> Komentari { get; set; }
        int BrojVoznji { get; set; }
        int Id { get; set; }

        static int globalID = 1;             // autoinkrement ID

        public Vozac(string ime, string prezime, string eMail, string lozinka, string slika) 
            : base(ime, prezime, eMail, lozinka, slika)
        {
            Id = globalID;
            globalID += 1;
            Komentari = new List<String>();
        }

        public Vozac() : base (null, null, null, null, null){
            Id = globalID;
            globalID += 1;
            Komentari = new List<String>();
        }


    }
}
