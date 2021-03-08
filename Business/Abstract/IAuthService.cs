using System;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        public IDataResult<User> Login(UserForLoginDto userForLoginDto);
        public IResult UserExists(string email);
        public IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
