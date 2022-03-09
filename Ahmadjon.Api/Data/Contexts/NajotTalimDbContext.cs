using Ahmadjon.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Ahmadjon.Api.Data.Contexts
{
    public class NajotTalimDbContext : DbContext
    {
        public NajotTalimDbContext(DbContextOptions<NajotTalimDbContext> options)
            :base(options)
        {

        }

        public NajotTalimDbContext()
        {

        }

        public virtual DbSet<UserModel> Users { get; set; }
    }
}
