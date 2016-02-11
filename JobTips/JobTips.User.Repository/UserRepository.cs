using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.DataAccess;
using JobTips.User.BusinessObject;
namespace JobTips.User.Repository
{
    public class UserRepository : JobTipsDataRepository, IUserRepository
    {
        public UserRepository()
        {
            
        }

        public string Abc(IUnitOfWork unitOfWork)
        {
            return "abc";
        }
    }
}
