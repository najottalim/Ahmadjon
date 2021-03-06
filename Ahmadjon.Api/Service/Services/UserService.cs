using Ahmadjon.Api.Data.IRepositories;
using Ahmadjon.Api.Enums;
using Ahmadjon.Api.Models;
using Ahmadjon.Api.Models.Common;
using Ahmadjon.Api.Service.Extensions;
using Ahmadjon.Api.Service.Interfaces;
using Ahmadjon.Api.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ahmadjon.Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoggerService _logger;
        public UserService(IUserRepository userRepository, ILoggerService service)
        {
            _userRepository = userRepository;
            _logger = service;
        }

        public Task<UserModel> CreateAsync(UserForCreationViewModel model)
        {
            UserModel user = new UserModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            
            return _userRepository.CreateAsync(user);
        }

        public async Task<IEnumerable<UserModel>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<UserModel, bool>> predicate = null)
        {
            var users = await _userRepository.GetAllAsync(predicate);

            return users.ToPagination(pageSize, pageIndex);
        }

        public async Task<BaseResponse<UserModel>> GetAsync(Expression<Func<UserModel, bool>> predicate)
        {
            var response = new BaseResponse<UserModel>();

            var user = await _userRepository.GetAsync(predicate);
            if(user is null)
            {
                response.Error = new ErrorModel(404, "User not found");
                return response;
            }

            // return response for data

            response.Data = user;

            return response;
        }

        public Task<UserModel> UpdateAsync(UserModel model)
        {
            return _userRepository.UpdateAsync(model);
        }

        public Task<UserModel> UpdateStatusAsync(long id, ItemState state)
        {
            try
            {
                //return _userRepository.UpdateStatusAsync(id, state);
                throw new ArgumentNullException();
            }
            catch(Exception ex)
            {
                _logger.Error(ex, "Error in UpdateStatus");
                throw;
            }
        }
    }
}
