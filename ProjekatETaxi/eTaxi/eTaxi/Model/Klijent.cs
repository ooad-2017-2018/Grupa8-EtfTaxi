using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTaxi.Model
{
    public class Klijent : Osoba
    {
        Spol Spol { get; set; }
        DateTime DatumRodjenja { get; set; }
        bool Stalni { get; set; }
        int Id { get; set; }

        static int globalID = 1;

        public Klijent() : base(null, null, null, null, null)
        {
            Id = globalID;
            globalID += 1;
        }
    }
}
