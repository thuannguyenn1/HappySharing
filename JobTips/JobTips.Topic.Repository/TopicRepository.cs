using JobTips.Topic.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.Topic.Repository
{
    public class TopicRepository : JobTipsDataRepository, ITopicRepository
    {
        public TopicPagingObject GetTopicsByIndex(int index, int numberPerPage, bool isActive, IUnitOfWork unitOfWork)
        {
            ValidateUnitOfWork(unitOfWork);

            string procedureName = "dbo.GetTopicsByIndex";

            var parameters = new
            {
                Index = index,
                NumberPerPage = numberPerPage,
                IsActive = isActive
            };

            TopicPagingObject topicPaging;

            using (var reader = unitOfWork.QueryMultiple(procedureName, parameters, commandType: CommandType.StoredProcedure))
            {
                topicPaging = new TopicPagingObject()
                {
                    Topics = reader.Read<BusinessObject.Topic>().ToList(),
                    NumberOfTopic = reader.Read<int>().SingleOrDefault()
                };
            }

            return topicPaging;
        }

        public BusinessObject.Topic GetTopicById(int topicId, IUnitOfWork unitOfWork)
        {
            ValidateUnitOfWork(unitOfWork);

            string procedureName = "dbo.GetTopicById";

            var parameters = new
            {
                TopicId = topicId
            };

            var result = unitOfWork.Query<BusinessObject.Topic>(procedureName, parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();

            return result;
        }

        public int SaveTopic(IList<BusinessObject.Topic> topicInfo, IUnitOfWork unitOfWork)
        {
            ValidateUnitOfWork(unitOfWork);

            string procedureName = "dbo.SaveTopic";

            var parameters = new SqlDynamicParameters();
            parameters.AddAsTable("@Topic", topicInfo);

            var result = unitOfWork.Query<BusinessObject.Topic>(procedureName, parameters, commandType: CommandType.StoredProcedure);

            return result == null? 0 : 1;
        }

        public int DeleteTopic(IList<int> topicId, IUnitOfWork unitOfWork)
        {
            ValidateUnitOfWork(unitOfWork);

            string procedureName = "dbo.DeleteTopic";

            var parameters = new SqlDynamicParameters();
            parameters.AddAsTable("@TopicIds", topicId);

            var result = unitOfWork.Execute(procedureName, parameters, commandType: CommandType.StoredProcedure);

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
