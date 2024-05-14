using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSBazom
{
    public class OsobaZivotinja
    {
        public int OsobaId { get; set; }
        public virtual Osoba Osoba { get; set; }

        public int ZivotinjaId { get; set; }
        public virtual Zivotinja Zivotinja { get; set; }
    }
}
