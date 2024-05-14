using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebSBazom.Pages.Osobe
{
    public class UpdateModel : PageModel
    {
        private MojaPrvaBazaDbContext db;

        public UpdateModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        [BindProperty]
        public Osoba Osoba { get; set; }

        public List<Zivotinja> Zivotinje { get; set; }

        public void OnGet(int id)
        {
            this.Osoba = db.Osobe.Find(id);

            this.Zivotinje = db.OsobeZivotinje
                .Include(x => x.Zivotinja)
                .Where(x => x.OsobaId == id)
                .Select(x => x.Zivotinja)
                .ToList();
        }

            public IActionResult OnPost()
        {
            var dbOsoba = db.Osobe.Find(this.Osoba.Id);

            dbOsoba.Ime = this.Osoba.Ime;
            dbOsoba.Prezime = this.Osoba.Prezime;
            dbOsoba.Godiste = this.Osoba.Godiste;
            dbOsoba.Tezina = this.Osoba.Tezina;
            dbOsoba.Visina = this.Osoba.Visina;

            db.SaveChanges();

            return RedirectToPage("/Osobe/Index");
        }
    }
}