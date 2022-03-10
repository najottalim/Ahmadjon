using Ahmadjon.Api.Enums;
using Ahmadjon.Api.Models;
using System.Threading.Tasks;

namespace Ahmadjon.Api.Data.IRepositories
{
    public interface IUserRepository : IGenericRepository<UserModel>
    {
        Task<UserModel> UpdateStatusAsync(long id, ItemState state);
    }
}
