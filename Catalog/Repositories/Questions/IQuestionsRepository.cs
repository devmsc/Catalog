using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Models.Questions;

namespace Catalog.Repositories.Questions
{
    public interface IQuestionsRepository : IRepositoryBase<Question>
    {
        Task<Question> GetWithTriggers(Guid id);
    }
}