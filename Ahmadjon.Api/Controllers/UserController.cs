using Ahmadjon.Api.Enums;
using Ahmadjon.Api.Models;
using Ahmadjon.Api.Models.Common;
using Ahmadjon.Api.Service.Interfaces;
using Ahmadjon.Api.Service.ViewModels;
using Microsoft.AspNetCore.Http;
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
        public Task<UserModel> Create([FromForm]UserForCreationViewModel user)
        {
            return _userService.CreateAsync(user);
        }

        [HttpGet("{id}")]
        public async ValueTask<IActionResult> Get(long id)
        {
            var result = await _userService.GetAsync(p => p.Id.Equals(id));

            return result.Error?.Code == 404 ? NotFound(result) : Ok(result);
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll(int pageSize, int pageIndex)
        {
            IEnumerable<UserModel> users = await _userService.GetAllAsync(pageSize, pageIndex);
            
            return Ok(users);
        }

        [HttpPut]
        public Task<UserModel> Update([FromBody]UserModel model)
        {
            return _userService.UpdateAsync(model);
        }

        [HttpPatch]
        public Task<UserModel> UpdateStatus(long id, ItemState state)
        {
            return _userService.UpdateStatusAsync(id, state);
        }
    }
}
