namespace SubjectApp.repository
{
    public interface IDatasourceConnectivity //Abstracts the way data is fetched
    {
        Boolean Connect();
        List<T> FetchAll<T>();
    }
}