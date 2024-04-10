using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
    public interface IGenreServices
    {
        bool Add(Genre model);
        bool Update(Genre model);
        bool Delete(int id);
        Genre FindById(int id);
        IEnumerable<Genre> GetAll();
    }
}
