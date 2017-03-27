using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ITS_Pravi_Projekat.Models;

namespace ITS_Pravi_Projekat.Controllers.Api
{
    public class OsobeController : ApiController
    {
        private ApplicationDbContext _context;
        public OsobeController()
        {
            _context = new ApplicationDbContext();
        }

        //GET/api/osobe
        [HttpGet]
        public IEnumerable<Osoba> UcitajOsobe()
        {
           return _context.Osobe.ToList();
        }

        //GET/api/osobe/{id}
        [HttpGet]
        public Osoba UcitajOsobu(int id)
        {
            var osoba = _context.Osobe.SingleOrDefault(o => o.ID == id);

            if (osoba == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return osoba;
        }
        //POST/api/osobe
        [HttpPost]
        public Osoba NapraviOsobu (Osoba licnost) // kad se isto zovu mapiranje ume da brlja
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException( HttpStatusCode.BadRequest);

            _context.Osobe.Add(licnost);
            _context.SaveChanges();

            return licnost;
        }

        //PUT/api/osobe/1
        [HttpPut]
        public void PromeniOsobu(int id, Osoba licnost)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var osobaInDb = _context.Osobe.SingleOrDefault(o => o.ID == id);

            if (osobaInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            osobaInDb.Ime = licnost.Ime;
            osobaInDb.Prezime = licnost.Prezime;
            osobaInDb.PolId = licnost.PolId;
            osobaInDb.MestoId = licnost.MestoId; 
            //bice potrebe dodavati jos u svakom slucaju




        }

        //DELETE/api/osobe
        [HttpDelete]
        public void ObrisiOsobu (int id)
        {
            var osobaInDb = _context.Osobe.SingleOrDefault(o => o.ID == id);

            if (osobaInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Osobe.Remove(osobaInDb);
            _context.SaveChanges();
        }

    }
}
