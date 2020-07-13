using LinkInBio.Host.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace LinkInBio.Host.Repos
{
    public class BioLandingRepo
    {
        private readonly AppDbContext context;

        public BioLandingRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Task<BioLanding> Get(Guid id)
        {
            return context.Landings.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<BioLanding> Insert(BioLanding bioLanding)
        {
            var result = await context.AddAsync(bioLanding);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public Task<BioLanding[]> GetAll()
        {
            return context.Landings.ToArrayAsync();
        }

        public async Task<BioLanding> Update(BioLanding entity)
        {
            var result = context.Landings.Update(entity);
            await context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
