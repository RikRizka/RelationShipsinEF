﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using OneToManyDemo.Data;
using OneToManyDemo.Models;
using OneToManyDemo.Models.ViewModels;
using OneToManyDemoMVC.Models.ViewModels;



namespace OneToManyDemo.Controllers
{
    public class BoekenController : Controller
    {
        readonly BoekenDbContext _context;
        public BoekenController(BoekenDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var boekAuteurViewModel = _context.Boeks
                .Include(b => b.Auteur)
                .Select(b => new BoekAuteurViewModel
                {
                    BoekId = b.BoekId,
                    Titel = b.Titel,
                    AuteurNaam = b.Auteur.Naam
                });

            return View(boekAuteurViewModel);
        }

        public async Task<IActionResult> Filters(int? GeselecteerdeAuteurId)
        {
            var auteurs = await _context.Auteurs.ToListAsync();

            IQueryable<Boek> boekenQuery = _context.Boeks.Include(b => b.Auteur);

            if (GeselecteerdeAuteurId.HasValue)
            {
                boekenQuery = boekenQuery.Where(b => b.AuteurId == GeselecteerdeAuteurId);
            }

            var boeken = await boekenQuery.ToListAsync();

            var boekenViewModel = boeken.Select(b => new BoekAuteurViewModel
            {
                BoekId = b.BoekId,
                Titel = b.Titel,
                AuteurNaam = b.Auteur.Naam
            }).ToList();

            var filtersViewModel = new BoekenViewModel
            {
                Auteurs = auteurs,
                Boeken = boekenViewModel,
                GeselecteerdeAuteurId = GeselecteerdeAuteurId ?? 0
            };
            return View(filtersViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var auteurs = await _context.Auteurs.ToListAsync();
            var viewModel = new CreateBoekViewModel
            {
                Auteurs = auteurs
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBoekViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Auteurs = await _context.Auteurs.ToListAsync();
                return View(viewModel);

            }
            var newBoek = new Boek
            {
                Titel = viewModel.Title,
                AuteurId = viewModel.AuteurId

            };
            _context.Boeks.Add(newBoek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Filters));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var boek = await _context.Boeks
                .Include(b => b.Auteur)
                .FirstOrDefaultAsync(b => b.BoekId == id);

            if (boek == null)
            {
                return NotFound();
            }
            return View(boek);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var boek = await _context.Boeks
            .Include(b => b.Auteur)
            .FirstOrDefaultAsync(b => b.BoekId == id);

            if (boek == null)
            {
                return NotFound();
            }

            var auteurs = await _context.Auteurs.ToListAsync();
            var viewModel = new EditBoekViewModel
            {
                BoekId = boek.BoekId,
                Title = boek.Titel,
                AuteurId = boek.AuteurId,
                Auteurs = auteurs

            };
            return View(viewModel);
            //var beoken = await _context.Boeks.FindAsync(id);
            //return View(beoken);
        }
        public async Task<IActionResult> Edit(EditBoekViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Auteurs = await _context.Auteurs.ToListAsync();


                return NotFound();
            }
            var boek = await _context.Boeks
          .FindAsync(viewModel.BoekId);
            if (boek == null)
            {
                return NotFound();
            }

            boek.Titel = viewModel.Title;
            boek.AuteurId = viewModel.AuteurId;
            _context.Update(boek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Filters));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            var boek = await _context.Boeks.FirstOrDefaultAsync(m => m.BoekId == id);
            return View(boek);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boekToDelete = await _context.Boeks.FindAsync(id);


            _ = _context.Boeks.Remove(boekToDelete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Filters));
        }
    }
}
