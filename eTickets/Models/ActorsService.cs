using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Models
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
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
