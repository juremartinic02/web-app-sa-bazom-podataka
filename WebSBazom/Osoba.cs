using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSBazom
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? Godiste { get; set; }
        public decimal? Tezina { get; set; }
        public int? Visina { get; set; }
    }
}
