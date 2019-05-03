using System.Collections.Generic;

namespace StudioVoices.Domain.Entities
{
    public class Commissie : BaseEntity
    {
        public string Naam { get; set; }
        public string Omschrijving { get; set; }

        public virtual ICollection<Persoon> Commissieleden { get; set; }
    }
}
