using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using satis_core.dtos;
using satis_core.Helpers;
using satis_db.dtos;
using satis_db.models;
using satis_db.repositories;
using Microsoft.AspNetCore.Mvc;

namespace satis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthController _authController;

        public UserController(
            IUserRepository userRepository,
            IAuthController authController
            )
        {
            _userRepository = userRepository;
            _authController = authController;
        }

        [HttpGet]
        public string Test()
        {
            return "user controller is work!";
        }

        [HttpPost]
        [Route("Signup")]
        public async Task<UserDto> Signup([FromBody] UserDto user)
        {
            user.Password = EncryptionHelper.MD5Hash(user.Password);

            var entity = AppMapper.Map<User>(user);

            var result = await _userRepository.Insert(entity);

            user.Id = result;

            return user;
        }

        [HttpPost]
        [Route("Signin")]
        public async Task<BaseResponse> Signin([FromBody] AuthenticationDto dto)
        {
            string hashedPassword = EncryptionHelper.MD5Hash(dto.Password);

            var users = await _userRepository.GetAllActive();

            var foundedUser = users.Find(o => o.Email.ToLower() == dto.Email.ToLower());

            var user = AppMapper.Map<UserDto>(foundedUser);

            if (user != null)
            {
                if (user.Password == hashedPassword)
                {
                    var tokenModel = _authController.GetToken((long)user.Id);

                    if (tokenModel == null)
                    {
                        tokenModel = _authController.AddToken((long)user.Id);
                    }

                    if (tokenModel.HasExpired)
                    {
                        return new BaseResponse(false, null, "Token has expired.");
                    }

                    return new BaseResponse(true, new { User = user, Token = tokenModel });
                }
                else
                {
                    return new BaseResponse(false, null, "Wrong password!");
                }
            }

            return new BaseResponse(false, null, "User not found!");
        }
    }
}
