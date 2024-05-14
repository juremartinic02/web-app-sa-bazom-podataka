using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSBazom.Pages.Osobe
{
    public class AddModel : PageModel
    {
        private readonly MojaPrvaBazaDbContext db;

        public AddModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        [BindProperty]
        public Osoba Osoba { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            this.db.Osobe.Add(this.Osoba);
            db.SaveChanges();

            return RedirectToPage("/Osobe/Index");
        }
    }
}