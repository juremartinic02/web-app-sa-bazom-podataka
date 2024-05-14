using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSBazom.Pages.Zivotinje
{
    public class DeleteModel : PageModel
    {
        private MojaPrvaBazaDbContext db;

        public DeleteModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        [BindProperty]
        public Zivotinja Zivotinja { get; set; }

        public void OnGet(int id)
        {
            this.Zivotinja = db.Zivotinje.Find(id);
        }

        public IActionResult OnPost()
        {
            var o = db.Zivotinje.Find(this.Zivotinja.Id);

            db.Remove(o);

            db.SaveChanges();

            return RedirectToPage("/Zivotinje/Index");
        }
    }
}