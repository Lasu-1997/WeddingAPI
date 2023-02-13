using WeddingAPI.Models;

namespace WeddingAPI.Repository
{
    public interface IUsers
    {
        Task<IEnumerable<Users>> GetUsers();
        Task<Users> GetUser(int id);
        Task<Users> AddUsers(Users users);
        Task<Users> UpdateUsers(Users users);
        void DeleteUsers(int id);
    }
}
