using Business.Abstract;
using Core.Entity.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {   
        IUserDal userDal;

        public UserManager(IUserDal _userDal)
        {
            userDal = _userDal;
        }

        public void Add(User user)
        {
            userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return userDal.GetClaims(user);
        }
    }
}
