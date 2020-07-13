using System;

namespace LinkInBio.Host.Models.Api
{
    public class TileViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Uri { get; set; }

        public string Color { get; set; }

        public Guid BioId { get; set; }
    }
}
