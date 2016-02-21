using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobTips.Core.Utility;
using JobTips.User.BusinessObject;

namespace JobTips.User.Service
{
    public class UserService:IUserService
    {
        public IUserRepository UserRepository;

        public UserService(IUserRepository usetRepository)
        {
            this.UserRepository = usetRepository;
        }

        public BusinessObject.UserResponse LoginUser(UserLoginRequest userInfo)
        {
            using (var unitOfWork = this.UserRepository.BeginWork())
            {
                var result = this.UserRepository.LoginUser(userInfo, unitOfWork);
                UserResponse userResponseData = new UserResponse();
                if (result != null)
                {
                    userResponseData.Token = EncryptHelper.GenerateToken();
                }
                return userResponseData;
            }
        }
    }
}
