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
        [HttpGet]
        public string Abc()
        {
            return UserService.Abc();
        }
    }
}
