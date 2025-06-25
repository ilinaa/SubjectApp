
using SubjectApp.model;

namespace SubjectApp.repository
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly IDatasourceConnectivity datasourceConnectivity;

        /*
        Dependency on an abstraction called IDatasourceConnectivity, which encapsulates how the repository connects to a data source (like JSON, database, etc.).

        Promotes loose coupling and flexibility — different implementations of this interface can be injected.

        */

        public Repository(IDatasourceConnectivity datasourceConnectivity) //Uses dependency injection to receive a datasource connectivity object.
        {
            this.datasourceConnectivity = datasourceConnectivity;
        }
        public List<T> FindAll()
        {
            if (!this.datasourceConnectivity.Connect())
            {
                throw new Exception("Unable to acquire a connection");
            }

            return this.datasourceConnectivity.FetchAll<T>();

        }
        public T? FindById(long id)
        {

            var allData = this.datasourceConnectivity.FetchAll<T>();
            foreach (var o in allData)
            {
                if (o.Id == id)
                {
                    return o;
                }
            }
            return null;
        }
    }
}