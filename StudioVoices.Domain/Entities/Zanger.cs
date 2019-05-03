using System.Collections.Generic;
using StudioVoices.Domain.Enums;

namespace StudioVoices.Domain.Entities
{
    public class Zanger : Persoon
    {
        public ICollection<Stemgroep> Stemgroepen { get; set; }
    }
}
