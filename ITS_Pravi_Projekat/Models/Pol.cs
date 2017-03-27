using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITS_Pravi_Projekat.Models
{
    public class Pol
    {
        [Key]
        public int Id { get; set; }
        public string NazivPola { get; set; }
    }
}