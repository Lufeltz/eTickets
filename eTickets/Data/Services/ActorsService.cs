using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddActorAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActorAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var allActors = await _context.Actors.ToListAsync();
            return allActors;
        }

        public Actor UpdateActor(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
