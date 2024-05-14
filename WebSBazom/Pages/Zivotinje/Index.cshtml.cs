using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebSBazom.Pages.Zivotinje
{
    public class IndexModel : PageModel
    {
        private readonly MojaPrvaBazaDbContext db;

        public IndexModel(MojaPrvaBazaDbContext dbContext)
        {
            this.db = dbContext;
        }

        public List<Zivotinja> Zivotinje { get; set; }

        public void OnGet()
        {
            this.Zivotinje = db.Zivotinje
                .ToList();
        }
    }
}