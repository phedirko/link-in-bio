using LinkInBio.Host.Extensions;
using LinkInBio.Host.Models.Api;
using LinkInBio.Host.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LinkInBio.Host.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class TilesController : ControllerBase
    {
        private readonly TilesRepo repo;

        public TilesController(TilesRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(typeof(TileViewModel[]), 200)]
        public async Task<IActionResult> Get()
        {
            return Ok((await repo.GetAll()).ToViewModel().ToList());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TileViewModel), 200)]
        public async Task<IActionResult> Get([FromRoute]Guid id)
        {
            return Ok((await repo.Get(id)).ToViewModel());
        }


        [HttpGet("bioId/{bioId}")]
        [ProducesResponseType(typeof(TileViewModel[]), 200)]
        public async Task<IActionResult> GetByBioId([FromRoute]Guid bioId)
        {
            return Ok((await repo.GetByLinkId(bioId)).ToViewModel());
        }

        [HttpPost("bioId/{bioId}")]
        [ProducesResponseType(typeof(TileViewModel), 200)]
        public async Task<IActionResult> Post([FromRoute] Guid bioId, [FromBody]TileCreateModel model)
        {
            var dbModel = model.ToModel();
            dbModel.Id = Guid.NewGuid();
            dbModel.BioLandingId = bioId;
            return Ok((await repo.Insert(dbModel)).ToViewModel());
        }
    }
}
