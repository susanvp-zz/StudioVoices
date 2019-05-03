using System.Collections.Generic;
using StudioVoices.Domain.Enums;

namespace StudioVoices.Domain.Entities
{
    public class Persoon : BaseEntity
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Telefoon { get; set; }
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public string Toevoeging { get; set; }
        public string Postcode { get; set; }
        public string Stad { get; set; }
        public Functie Functie { get; set; }

        public virtual ICollection<Commissie> Commissies { get; set; }
    }
}
