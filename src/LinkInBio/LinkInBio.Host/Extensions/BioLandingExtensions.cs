using LinkInBio.Host.Models.Api;
using LinkInBio.Host.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkInBio.Host.Extensions
{
    public static class BioLandingExtensions
    {
        public static BioLandingViewModel ToViewModel(this BioLanding bioLanding)
        {
            return new BioLandingViewModel
            {
                Id = bioLanding.Id,
                Name = bioLanding.Name,
                Title = bioLanding.Title
            };
        }

        public static BioLanding ToModel(this BioLandingCreateModel createModel)
        {
            return new BioLanding
            {
                Id = Guid.NewGuid(),
                Name = createModel.Name,
                Title = createModel.Title
            };
        }
    }
}
