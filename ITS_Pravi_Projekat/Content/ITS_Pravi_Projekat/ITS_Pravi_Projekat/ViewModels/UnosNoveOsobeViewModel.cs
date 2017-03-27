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
        public IEnumerable<Pol> Pol { get; set; }
        public IEnumerable<Mesto> Mesto { get; set; }
    }
} 