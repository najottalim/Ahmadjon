using Ahmadjon.Api.Models;
using Ahmadjon.Api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoLibrary;

namespace Ahmadjon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public Task<UserModel> Create(UserModel user)
        {
            return _userService.CreateAsync(user);
        }

        [HttpGet("{id}")]
        public Task<UserModel> Get(long id)
        {
            return _userService.GetAsync(p => p.Id.Equals(id));
        }
    }
}
