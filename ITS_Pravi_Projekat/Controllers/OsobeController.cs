using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITS_Pravi_Projekat.Models;
using ITS_Pravi_Projekat.ViewModels;
using System.Data.Entity;
using ITS_Pravi_Projekat.Migrations;

namespace ITS_Pravi_Projekat.Controllers
{
    public class OsobeController : Controller
    {
        public ApplicationDbContext _context;
        public OsobeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Osobe
        public ActionResult Index()
        {
            var Osoba = _context.Osobe.ToList();

            return View(Osoba);
        }


        public ActionResult Osoba_prikaz()
        {
            var osoba = _context.Osobe.ToList();
            if (User.IsInRole(ImeUloge.MenjaDodajeStampaOsobuRegistrujeKorisnike))
                return View("Osoba_prikaz", osoba);
            else if (User.IsInRole(ImeUloge.PrikazujeStampaIDodajeOsobu))
                return View("PrikazCitanjeDodaj", osoba);

            return View("PrikazCitanje", osoba);
        }

        [AllowAnonymous]
        [Authorize(Roles = ImeUloge.MenjaDodajeStampaOsobuRegistrujeKorisnike)]
        public ActionResult Detaljno(int id)
        {
            var osoba = _context.Osobe.Include(o => o.Pol).SingleOrDefault(o => o.ID == id);
            if (osoba == null)
            {
                return HttpNotFound();
            }

            var viewModel = new UnosNoveOsobeViewModel()
            {
                Osoba = osoba
            };

            return View(viewModel);
        }

        [Authorize(Roles = ImeUloge.MenjaDodajeStampaOsobuRegistrujeKorisnike +","+ ImeUloge.PrikazujeStampaIDodajeOsobu)]
        public ActionResult Novo() //prikaz forme za kreiranje novog korisnika
        {
            var polovi = _context.Pol.ToList();
            var mesta = _context.Mesto.ToList();

            var ViewModel = new UnosNoveOsobeViewModel
            {
                Polovi = polovi
            };  

            return View("Novo",ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = ImeUloge.MenjaDodajeStampaOsobuRegistrujeKorisnike + " , " + ImeUloge.PrikazujeStampaIDodajeOsobu)]
        public ActionResult Create( Osoba osoba/*, Mejl mejl, KontaktTelefon kontaktTelefon,TipKontaktTelefon tipTelefon, TipMejlAdresa tipMejla */)
        {
            //edit akcija
/*
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Osoba_prikaz", "Osobe"); ne radi iz nekog razloga
            }
            */
        
                if (osoba.ID == 0)
                {
                    _context.Osobe.Add(osoba);
                }

                //ovo sluzi samo za edit
                else
                {
                   var osobaInDB = _context.Osobe.Single(o => o.ID == osoba.ID);

                    osobaInDB.Ime = osoba.Ime;
                    osobaInDB.Prezime = osoba.Prezime;
                    osobaInDB.DatumRodjenja = osoba.DatumRodjenja;
                    osobaInDB.JMBG = osoba.JMBG;
                    osobaInDB.ImeRoditelja = osoba.ImeRoditelja;
                    osobaInDB.BrojLicneKarte = osoba.BrojLicneKarte;
                    osobaInDB.Beleska = osoba.Beleska;
                    osobaInDB.PolId = osoba.PolId;
                }

            _context.SaveChanges();

                return RedirectToAction("Osoba_prikaz", "Osobe");
           
        }

        [Authorize(Roles = ImeUloge.MenjaDodajeStampaOsobuRegistrujeKorisnike)]
        public ActionResult Izmeni(int Id)
        {                        
            var osoba = _context.Osobe.SingleOrDefault(o => o.ID == Id);
            var polovi = _context.Pol.ToList();

            if (osoba == null)
                return HttpNotFound();

            var viewModel = new UnosNoveOsobeViewModel
            {
                Polovi = polovi,
                Osoba = osoba
            };
            return View("Novo", viewModel);
        }
        [Authorize(Roles = ImeUloge.MenjaDodajeStampaOsobuRegistrujeKorisnike)]
        public ActionResult ObrisiOsobu(int id)
        {
            var osobaInDb = _context.Osobe.SingleOrDefault(o => o.ID == id);
            if (osobaInDb == null)
                return HttpNotFound();

            _context.Osobe.Remove(osobaInDb);
            _context.SaveChanges();

            return RedirectToAction("Osoba_prikaz", "Osobe");
        }

    }
}