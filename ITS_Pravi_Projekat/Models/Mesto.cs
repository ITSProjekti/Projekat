using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITS_Pravi_Projekat.Models
{
    public class Mesto
    {
        [Key]
        public int ID { get; set; }
        public string NazivMesta { get; set; }
        public int PostanskiBroj { get; set; }
    }
}