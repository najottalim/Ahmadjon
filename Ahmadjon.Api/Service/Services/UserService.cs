using Ahmadjon.Api.Data.IRepositories;
using Ahmadjon.Api.Models;
using Ahmadjon.Api.Service.Interfaces;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ahmadjon.Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserModel> CreateAsync(UserModel model)
        {
            return _userRepository.CreateAsync(model);
        }

        public Task<UserModel> GetAsync(Expression<Func<UserModel, bool>> predicate)
        {
            return _userRepository.GetAsync(predicate);
        }
    }
}
