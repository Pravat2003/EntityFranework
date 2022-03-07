using AutoMapper;
using BitaFacts.Core.Entities.Modeles;
using BitaFacts.Core.Entities.Request;
using BitaFacts.Core.Entities.Response;
using BitaFacts.Core.Interface;
using BitaFacts.Infrastructure.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitaFacts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IMapper _mapper;
        public UserRoleController(IUserRoleRepository userRoleRepository, IMapper mapper)
        {
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("getUserRoles")]
        public IActionResult GetUserRoles()
        {
            var userRoles = _userRoleRepository.GetAll();
            var response = _mapper.Map<List<UserRoleResponse>>(userRoles);
            return Ok(response);
        }

        [Authorize]
        [HttpPost("addUserRole")]
        public IActionResult AddUserRoles([FromBody] UserRoleRequest request)
        {
            var userRole = new UserRole { RoleName = request.RoleName, IsActive = request.IsActive };
            var isSuccess = _userRoleRepository.Add(userRole);
            return Ok(isSuccess);
        }

        [Authorize]
        [HttpPut("updateUserRole")]
        public IActionResult UpdateUserRoles([FromBody] UserRoleRequest request)
        {
            var userRole = new UserRole { Id= request.RoleId, RoleName = request.RoleName, IsActive = request.IsActive };
            var isSuccess = _userRoleRepository.Update(userRole);
            return Ok(isSuccess);
        }

        [Authorize]
        [HttpDelete("deleteUserRoles")]
        public IActionResult DeleteUserRoles([FromBody] UserRoleRequest request)
        {
            var userRole = new UserRole { Id = request.RoleId, RoleName = request.RoleName, IsActive = request.IsActive };
            var isSuccess = _userRoleRepository.Remove(userRole);
            return Ok(isSuccess);
        }
    }
}
