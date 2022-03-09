using Ahmadjon.Api.Data.Contexts;
using Ahmadjon.Api.Data.IRepositories;
using Ahmadjon.Api.Models;

namespace Ahmadjon.Api.Data.Repositories
{
    public class UserRepository : GenericRepository<UserModel>, IUserRepository
    {
        public UserRepository(NajotTalimDbContext dbContext) : base(dbContext)
        {
        }
    }
}
