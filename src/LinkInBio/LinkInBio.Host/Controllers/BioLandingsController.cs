using LinkInBio.Host.Extensions;
using LinkInBio.Host.Models.Api;
using LinkInBio.Host.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace LinkInBio.Host.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class BioLandingsController : ControllerBase
    {
        private readonly BioLandingRepo repo;

        public BioLandingsController(BioLandingRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BioLandingViewModel[]), 200)]
        public async Task<IActionResult> Get()
        {
            return Ok((await repo.GetAll()).Select(x => x.ToViewModel()).ToList());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BioLandingViewModel), 200)]
        public async Task<IActionResult> Get([FromRoute]Guid id)
        {
            return Ok((await repo.Get(id)).ToViewModel());
        }

        [HttpPost]
        [ProducesResponseType(typeof(BioLandingViewModel), 200)]
        public async Task<IActionResult> Post([FromBody]BioLandingCreateModel model)
        {
            var dbModel = model.ToModel();
            dbModel.Id = Guid.NewGuid();
            return Ok((await repo.Insert(dbModel)).ToViewModel());
        }
    }
}
