using SubjectApp.model;

namespace SubjectApp.repository
{
    public class InMemoryRepository : IRepository<Subject>
    {
        public List<Subject> FindAll()
        {
            return DataInitializer.GetSubjects();
        }

        public Subject? FindById(long id)
        {
            return DataInitializer.GetSubjects().Find(s => s.Id.Equals(id));
        }
    }
}