namespace SubjectApp.repository
{
    public abstract class BaseDatasourceConfigurator
    {
        public required string Path;
        public abstract IDatasourceConnectivity instantiateConnectivity();
    }
}