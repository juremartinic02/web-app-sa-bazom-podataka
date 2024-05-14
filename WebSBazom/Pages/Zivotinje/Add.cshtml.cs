using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSBazom.Pages.Zivotinje
{
    public class AddModel : PageModel
    {
        private readonly MojaPrvaBazaDbContext db;

        public AddModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        [BindProperty]
        public Zivotinja Zivotinja { get; set; }

        public List<SelectListItem> Osobe { get; set; }

        public void OnGet(int vlasnikId)
        {
            this.Osobe = db.Osobe
                .ToList()
                .Select(x => new SelectListItem($"{x.Ime} {x.Prezime}", $"{x.Id}"))
                .ToList();
        }

        public IActionResult OnPost()
        {
            db.Zivotinje.Add(this.Zivotinja);

            db.SaveChanges();

            return RedirectToPage("/Zivotinje/Index");
        }
    }
}