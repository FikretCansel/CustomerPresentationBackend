using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        public IUserDal _userDal;

        public AuthManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Result Login(User user)
        {
            var findedUser = _userDal.Get(x => x.UserName == user.UserName);

            if (findedUser == null)
            {
                return new Result { isSuccess = false, Message = "Kullanıcı Bulunamadı" };
            }

            if (findedUser.Password == user.Password)
            {
                return new Result {isSuccess= true,Message= "Giriş Başarılı" };
            }
            else
            {
                return new Result {isSuccess= false, Message="Şifre Hatalı" };
            }
             
        }
    }
}
