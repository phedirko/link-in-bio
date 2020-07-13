using LinkInBio.Host.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LinkInBio.Host.Repos
{
    public class TilesRepo
    {
        private readonly AppDbContext context;

        public TilesRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Task<Tile> Get(Guid id)
        {
            return context.Tiles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Tile> Insert(Tile bioLanding)
        {
            var result = await context.AddAsync(bioLanding);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public Task<Tile[]> GetAll()
        {
            return context.Tiles.ToArrayAsync();
        }

        public Task<Tile[]> GetByLinkId(Guid landingId)
        {
            return context.Tiles.Where(x => x.BioLandingId == landingId).ToArrayAsync();
        }

        public async Task<Tile> Update(Tile entity)
        {
            var result = context.Tiles.Update(entity);
            await context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
