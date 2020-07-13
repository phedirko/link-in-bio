using System;

namespace LinkInBio.Host.Models.Data
{
    public class Tile
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Uri { get; set; }

        public string Color { get; set; }

        public Guid BioLandingId { get; set; }
    }
}
