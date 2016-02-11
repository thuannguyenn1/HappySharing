using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string Abc()
        {
            using (var unitOfWork = this.UserRepository.BeginWork())
            {
                return this.UserRepository.Abc(unitOfWork);
            }
        }
    }
}
