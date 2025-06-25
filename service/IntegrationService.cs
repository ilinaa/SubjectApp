using SubjectApp.repository;

namespace SubjectApp.service
{
    public class IntegrationService<Subject> : BaseIntegrationService<Subject>
    {
        public override void AddNewIntegration(IRepository<Subject> repository)
        {
            this.repositories.Add(repository);
        }

        public override List<Subject> GetAllSubjects()
        {
            return this.repositories.Select(repository => repository.FindAll()).SelectMany(s => s).ToList();
        }

        public override Subject GetById(long id)
        {
            var subject = repositories
           .Select(r => r.FindById(id))
           .FirstOrDefault(s => s != null);

            if (subject == null)
            {
                throw new Exception("The subject doesn't exist!");
            }

            return subject;
        }


    }
}