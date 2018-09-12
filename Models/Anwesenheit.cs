using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnwesenheitsListeErweiterung.Models
{
    public class Anwesenheit
    {
        public string MitarbeiterName { get; set; }
        public bool Eingestempelt { get; set; }
        public string Dauer { get; set; }
    }
}
