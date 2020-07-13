using System;
using System.Collections.Generic;

namespace LinkInBio.Host.Models.Data
{
    public class BioLanding
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public IList<Tile> Tiles { get; set; }
    }
}