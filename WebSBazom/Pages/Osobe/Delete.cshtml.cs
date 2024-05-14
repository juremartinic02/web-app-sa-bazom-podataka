using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSBazom.Pages.Osobe
{
    public class DeleteModel : PageModel
    {
        private MojaPrvaBazaDbContext db;

        public DeleteModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        [BindProperty]
        public Osoba Osoba { get; set; }

        public void OnGet(int id)
        {
            this.Osoba = db.Osobe.Find(id);
        }

        public IActionResult OnPost()
        {
            var o = db.Osobe.Find(this.Osoba.Id);

            db.Remove(o);

            db.SaveChanges();

            return RedirectToPage("/Osobe/Index");
        }
    }
}