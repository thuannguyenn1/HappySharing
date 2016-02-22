using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.DataAccess;
using JobTips.User.BusinessObject;

namespace JobTips.User.Repository
{
    public class UserRepository : JobTipsDataRepository, IUserRepository
    {
        public BusinessObject.User LoginUser(UserLoginRequest userInfo, IUnitOfWork unitOfWork)
        {
            ValidateUnitOfWork(unitOfWork);

            string procedureName = "dbo.GetUserLogin";

            var parameters = new
            {
                UserName = userInfo.UserName,
                Password = userInfo.Password
            };

            var result = unitOfWork.Query<BusinessObject.User>(procedureName,parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();

            return result;
        }

        private void ValidateUnitOfWork(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new Exception("unitOfWork", new NullReferenceException());
            }
        }
    }
}
