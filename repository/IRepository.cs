namespace SubjectApp.repository
{
    public interface IRepository<T>
    {
        List<T> FindAll();
        T? FindById(long id);

    }
}