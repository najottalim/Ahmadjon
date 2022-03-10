using Ahmadjon.Api.Data.Contexts;
using Ahmadjon.Api.Data.IRepositories;
using Ahmadjon.Api.Enums;
using Ahmadjon.Api.Models;
using System.Threading.Tasks;

namespace Ahmadjon.Api.Data.Repositories
{
    public class UserRepository : GenericRepository<UserModel>, IUserRepository
    {
        public UserRepository(NajotTalimDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<UserModel> UpdateStatusAsync(long id, ItemState state)
        {
            var user = await _dbSet.FindAsync(id);
            user.State = state;

            await _dbContext.SaveChangesAsync();

            return user;
        }
    }
}
