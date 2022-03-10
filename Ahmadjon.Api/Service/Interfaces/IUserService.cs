using Ahmadjon.Api.Data.IRepositories;
using Ahmadjon.Api.Enums;
using Ahmadjon.Api.Models;
using Ahmadjon.Api.Models.Common;
using Ahmadjon.Api.Service.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ahmadjon.Api.Service.Interfaces
{

    public interface IUserService
    {
        Task<UserModel> CreateAsync(UserForCreationViewModel model);
        Task<BaseResponse<UserModel>> GetAsync(Expression<Func<UserModel, bool>> predicate);
        Task<IEnumerable<UserModel>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<UserModel, bool>> predicate = null);
        Task<UserModel> UpdateAsync(UserModel model);
        Task<UserModel> UpdateStatusAsync(long id, ItemState state);
    }
}
