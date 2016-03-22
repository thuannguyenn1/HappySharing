﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTips.User.BusinessObject
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public bool Sex { get; set; }

        public int IsActive { get; set; }
        public int IsDeleted { get; set; }

        DateTime Inserted { get; set; }

    }
}
