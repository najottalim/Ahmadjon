using Ahmadjon.Api.Data.IRepositories;
using Ahmadjon.Api.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ahmadjon.Api.Service.Interfaces
{

    public interface IUserService
    {
        Task<UserModel> CreateAsync(UserModel model);
        Task<UserModel> GetAsync(Expression<Func<UserModel, bool>> predicate);
    }
}
