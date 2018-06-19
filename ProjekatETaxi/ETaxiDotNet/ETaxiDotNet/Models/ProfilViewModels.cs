using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ETaxiDotNet.Models
{
    public class ProfilViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Ime { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Prezime { get; set; }

        [Required]
        [Display(Name = "Region")]
        public string Region { get; set; }

        [Required]
        [Display(Name = "Deliveries made")]
        public int BrojVoznji { get; set; }

        [Required]
        [Display(Name = "Rating")]
        public int Ocjena { get; set; }

        [Required]
        [Display(Name = "Car model")]
        public string ModelAuta { get; set; }

        [Required]
        [Display(Name = "Car link")]
        public string LinkAuta { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string StanjeVozaca { get; set; }


    }
}