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
            var Osoba = _context.Osobe.Include(c => c.MestoRodjenja).ToList();
            return View(Osoba);
        }

        public ActionResult Osoba_prikaz()
        {
            var osoba = _context.Osobe.Include(c=> c.MestoRodjenja).ToList();
            
            return View(osoba);
        }

        public ActionResult Detaljno (int id)
        {
            var osoba = _context.Osobe.Include(c => c.MestoRodjenja).Include(c => c.Pol).SingleOrDefault(c => c.ID == id);

            return View(osoba);
        }

      public ActionResult Novo()
        {
           var pol = _context.Pol.ToList();
           var mesto = _context.Mesto.ToList();


            var ViewModel = new UnosNoveOsobeViewModel
            {
                Pol = pol,
                Mesto = mesto

                
            };
           

            return View("Novo",ViewModel);
           
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Osoba osoba)
        {

/*
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Osoba_prikaz", "Osobe");
            }
            */
        
                if (osoba.ID == 0)
                    _context.Osobe.Add(osoba);

                else
                {
                    var osobaInDB = _context.Osobe.Single(c => c.ID == osoba.ID);

                    osobaInDB.Ime = osoba.Ime;
                    osobaInDB.Prezime = osoba.Prezime;
                    osobaInDB.MestoId = osoba.MestoId;
                    osobaInDB.PolId = osoba.PolId;

                }

                _context.SaveChanges();

                return RedirectToAction("Osoba_prikaz", "Osobe");
           
        }


        public ActionResult Izmeni(int Id)
        {

            var osoba = _context.Osobe.SingleOrDefault(c => c.ID == Id);

            if (osoba == null)
                return HttpNotFound();

            var viewModel = new UnosNoveOsobeViewModel
            {
                Osoba = osoba,
                Mesto = _context.Mesto.ToList(),
                Pol = _context.Pol.ToList()
            };

            return View("Novo", viewModel);
        
        }

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