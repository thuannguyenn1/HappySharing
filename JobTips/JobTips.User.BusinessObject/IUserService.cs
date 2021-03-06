﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTips.User.BusinessObject
{
    public interface IUserService
    {
        UserResponse LoginUser(UserLoginRequest userInfo);
        int RegisterUser(IList<User> topicInfo);
    }
}
