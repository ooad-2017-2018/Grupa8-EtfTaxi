using eTaxi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTaxi.ModelView
{
    public class Registracija
    {

    // Osnovni podaci (klijent)
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String EMail { get; set; }
        public String Lozinka { get; set; }
        public String PotvrdaLozinke { get; set; }
        public DateTime DatumRodenja { get; set; }
        public Spol Spol { get; set; }

    // Dodatni podaci
        public String JMBG { get; set; }
        public String BrojTelefona { get; set; }
        public String AdresaStanovanja { get; set; }
        public String BrojKartice { get; set; }
        public Region Region { get; set; }

    // Podaci o zaposlenju
        public String ModelAutomobila { get; set; }
        public int BrojSjedista { get; set; }
        public String RadnoIskustvo { get; set; }

        //private bool validacijaRegistracije()
        //public void DodajRegistriranog (Osoba osoba)

    }
}
