using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITS_Pravi_Projekat.Models;
using System.ComponentModel.DataAnnotations;


namespace ITS_Pravi_Projekat.Dtos
{
    public class OsobaDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Polje Ime je obavezno")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Polje prezime je obavezno")]
        public string Prezime { get; set; }

       //moze se napraviti novi dto za  Mesto
        [Display(Name = "Mesto rodjenja")]
        public int MestoId { get; set; }
        //moze se napraviti novi dto za  Pol


        [Display(Name = "Pol")]
        public int PolId { get; set; }

    }
}