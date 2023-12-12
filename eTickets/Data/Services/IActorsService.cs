using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable <Actor>> GetAll();
        Actor GetActor(int id);
        void AddActor(Actor actor);
        Actor UpdateActor(int id, Actor newActor);
        void DeleteActor(int id);
    }
}
