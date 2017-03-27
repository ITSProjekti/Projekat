using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITS_Pravi_Projekat.Models;

namespace ITS_Pravi_Projekat.ViewModels
{
    public class RandomOsobaViewModel
    {
        public List<Osoba> Osoba { get; set; }
        public Mesto Mesto { get; set; }
        public Pol Pol { get; set; }

    }
}