using Business.Abstract;
using Business.Contants;
using Core.Entity.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JsonWebToken;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService userService;
        private ITokenHelper tokenHelper;

        public AuthManager(IUserService _userService, ITokenHelper _tokenHelper)
        {
            userService = _userService;
            tokenHelper = _tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userCheck = userService.GetByMail(userForLoginDto.Email);
            if (userCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
