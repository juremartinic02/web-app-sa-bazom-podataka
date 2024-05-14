using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSBazom.Pages.Osobe
{
    public class IndexModel : PageModel
    {
        private MojaPrvaBazaDbContext db;

        public IndexModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        public List<Osoba> Osobe { get; set; }

        public void OnGet()
        {
            Osobe = db.Osobe.ToList();
        }

        public IActionResult OnGetDelete(int id)
        {
            var o = db.Osobe.Find(id);

            db.Osobe.Remove(o);

            db.SaveChanges();

            return RedirectToPage("/Osobe/Index");
        }

        public IActionResult OnPostDelete(int id)
        {
            var o = db.Osobe.Find(id);

            db.Osobe.Remove(o);

            db.SaveChanges();

            return RedirectToPage("/Osobe/Index");
        }
    }
}