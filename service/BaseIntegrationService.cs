using SubjectApp.repository;

namespace SubjectApp.service
{
    public abstract class BaseIntegrationService<T>
    {
        public List<IRepository<T>> repositories = [];
        public abstract void AddNewIntegration(IRepository<T> repository);
        public abstract List<T> GetAllSubjects();
        public abstract T GetById(long id);
    }
}