using LinkInBio.Host.Models.Api;
using LinkInBio.Host.Models.Data;
using System.Collections.Generic;
using System.Linq;

namespace LinkInBio.Host.Extensions
{
    public static class TilesExtensions
    {
        public static TileViewModel ToViewModel(this Tile tile)
        {
            return new TileViewModel
            {
                Id = tile.Id,
                Title = tile.Title,
                Color = tile.Color,
                Uri = tile.Uri,
                BioId = tile.BioLandingId
            };
        }

        public static IEnumerable<TileViewModel> ToViewModel(this IEnumerable<Tile> tile)
        {
            return tile.Select(ToViewModel);
        }

        public static Tile ToModel(this TileCreateModel createModel)
        {
            return new Tile
            {
                Title = createModel.Title,
                Color = createModel.Color,
                Uri = createModel.Uri
            };
        }
    }
}
