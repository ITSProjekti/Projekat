using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITS_Pravi_Projekat.Models
{
    public class Osoba
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Polje ime je obavezno.")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Polje prezime je obavezno.")]
        public string Prezime { get; set; }

        //public Opstina Opstina { get; set; }

        //[Display(Name = "Opstina rodjenja")]
        //public int OpstinaID { get; set; }

        public Pol Pol { get; set; }

        [Display(Name = "Pol")]
        [Required(ErrorMessage = "Morate odabrati pol")]
        public int PolId { get; set; }

        [Required(ErrorMessage = "Polje ime roditelja je obavezno.")]
        [Display(Name ="Ime roditelja")]
        [StringLength(50)]
        public string ImeRoditelja { get; set; }

        [Required(ErrorMessage = "Polje jmbg je obavezno.")]
        [Display(Name = "Jmbg")]
        public Int64 JMBG { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Datum rodjenja")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Polje datum je obavezno.")]
        public DateTime? DatumRodjenja { get; set; }

        [Display(Name ="Broj licne karte")]
        [Required(ErrorMessage = "Polje broj licne karte je obavezno.")]
        public Int64 BrojLicneKarte{ get; set; }

        [Display(Name = "Beleska")]
        public string Beleska { get; set; }

        //[Display(Name = "Postanska Adresa")]
        //[ForeignKey("PostanskaAdresa")]
        //public int PostanskaAdresaID { get; set; }

        //public PostanskaAdresa PostanskaAdresa { get; set; }
    }
}