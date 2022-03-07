using AutoMapper;
using BitaFacts.Core.Entities.Request;
using BitaFacts.Core.Entities.Response;
using BitaFacts.Core.Interface;
using BitaFacts.Infrastructure.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BitaFacts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthenticateService _authenticateService;
        private readonly IMapper _mapper;
        public UserController(IUserRepository userRepository, IAuthenticateService authenticateService, IMapper mapper)
        {
            _userRepository = userRepository;
            _authenticateService = authenticateService;
            _mapper = mapper;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserRequest model)
        {
            var response = _authenticateService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        //[Authorize]
        [HttpGet("getAllUser")]
        public IActionResult GetAllUsers()
        {
            var users = _userRepository.GetAll();
            var response = _mapper.Map<List<UserResponse>>(users);
            return Ok(response);
        }

    }
}
