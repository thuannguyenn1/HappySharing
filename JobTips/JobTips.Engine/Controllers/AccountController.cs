﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using JobTips.Engine.Models;
using JobTips.Engine.Providers;
using JobTips.Engine.Results;
using Microsoft.Practices.Unity;

namespace JobTips.Engine.Controllers
{

    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
      
    }
}
