using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTaxi.Model
{
    public class Auto
    {
    
        int BrojSjedista { get; set; }
        String Model { get; set; }
        String Link { get; set; }

        public Auto(int brojSjedista, string model, string link)
        {
            BrojSjedista = brojSjedista;
            Model = model;
            Link = link;
        }

    }
}
