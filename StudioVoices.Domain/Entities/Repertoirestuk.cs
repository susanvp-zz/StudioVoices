using System.Collections.Generic;
using StudioVoices.Domain.Enums;

namespace StudioVoices.Domain.Entities
{
    public class Repertoirestuk : BaseEntity
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Arrangeur { get; set; }
        public string Stijl { get; set; }
        public string Origineel { get; set; }
        public string Opmerkingen { get; set; }
        public Toonsoort Toonsoort { get; set; }
    }
}
