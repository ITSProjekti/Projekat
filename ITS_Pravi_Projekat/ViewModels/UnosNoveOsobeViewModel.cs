using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITS_Pravi_Projekat.Models;
namespace ITS_Pravi_Projekat.ViewModels
{
    public class UnosNoveOsobeViewModel
    {
        public Osoba Osoba { get; set; }
        public Mesto Mesto { get; set; }
        //public Opstina Opstina { get; set; }
        //public PostanskaAdresa PostanskaAdresa { get; set; }
        //public Mejl Mejl { get; set; }
        //public KontaktTelefon KontaktTelefon { get; set; }
        public IEnumerable<Pol> Polovi { get; set; }
        public Pol Pol { get; set; }
        public IEnumerable<Mesto> Mesta { get; set; }
        //public IEnumerable<Opstina> Opstine { get; set; }
        //public IEnumerable<KontaktTelefon> KontaktTelefoni { get; set; }
        //public IEnumerable<Mejl> Mejlovi { get; set; }
        //public IEnumerable<TipKontaktTelefon> TipoviKontaktTelefona { get; set; }
        //public IEnumerable<TipPostanskaAdresa> TipoviPostanskeAdrese { get; set; }
        //public IEnumerable<TipMejlAdresa> TipoviMejlAdrese { get; set; }
    }
} 