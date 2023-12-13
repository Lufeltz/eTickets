using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable <Actor>> GetAllAsync();
        Task <Actor> GetActorAsync(int id);
        Task AddActorAsync(Actor actor);
        Actor UpdateActor(int id, Actor newActor);
        void DeleteActor(int id);
    }
}
