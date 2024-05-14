using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSBazom.Pages.Zivotinje
{
    public class UpdateModel : PageModel
    {
        private readonly MojaPrvaBazaDbContext db;

        public UpdateModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        [BindProperty]
        public Zivotinja Zivotinja { get; set; }

        public List<SelectListItem> Osobe { get; set; }

        public void OnGet(int id)
        {
            this.Zivotinja = db.Zivotinje.Find(id);

            this.Osobe = db.Osobe
                .ToList()
                .Select(x => new SelectListItem($"{x.Ime} {x.Prezime}", $"{x.Id}"))
                .ToList();
        }

        public IActionResult OnPost()
        {
            var dbZivotinja = db.Zivotinje.Find(this.Zivotinja.Id);

            dbZivotinja.Ime = this.Zivotinja.Ime;
            dbZivotinja.Vrsta = this.Zivotinja.Vrsta;
            dbZivotinja.Pasmina = this.Zivotinja.Pasmina;
            dbZivotinja.Tezina = this.Zivotinja.Tezina;

            db.SaveChanges();

            return RedirectToPage("/Zivotinje/Index");
        }
    }
}