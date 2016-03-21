using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.User.BusinessObject;
using System.Web.Http;

namespace JobTips.User.Controller
{
    public class UserController: ApiController
    {
        public IUserService UserService;

        public UserController(IUserService userService)
        {
            this.UserService = userService;
        }

        [HttpPost]
        public UserResponse Login(UserLoginRequest userInfo)
        {
            return this.UserService.LoginUser(userInfo);
        }

        [HttpPost]
        public int RegisterUser(IList<BusinessObject.User> users)
        {
            return this.UserService.RegisterUser(users);
        }
    }
}
