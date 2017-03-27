using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITS_Pravi_Projekat.Models
{
    public class Osoba
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Polje Ime je obavezno") ]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Polje prezime je obavezno")]
        public string Prezime { get; set; }

        public Mesto MestoRodjenja { get; set; }
        [Display(Name = "Mesto rodjenja")]
        public int MestoId { get; set; }

        public Pol Pol { get; set; }
        [Display(Name = "Pol")]
        public int PolId { get; set; }


    }
}