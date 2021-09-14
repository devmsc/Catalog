using Catalog.Database;
using Catalog.Models.Questionnaires;

namespace Catalog.Repositories.Questionnaires
{
    public class QuestionnaireRepository : RepositoryBase<Questionnaire>, IQuestionnaireRepository
    {
        public QuestionnaireRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}