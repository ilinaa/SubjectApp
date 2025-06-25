namespace SubjectApp.repository
{
    public class JsonDatasourceConfigurator : BaseDatasourceConfigurator
    {
        private readonly JsonParser JsonParser;

        public JsonDatasourceConfigurator()
        {
            JsonParser = new JsonParser();
        }

        public string GetPath()
        {
            return this.Path;
        }

        public JsonParser GetJsonParser()
        {
            return this.JsonParser;
        }

        public override IDatasourceConnectivity instantiateConnectivity()
        {

            var connectivity = new JsonDatasourceConnectivity(this);
            if (!connectivity.Connect())
            {
                throw new FileNotFoundException($"JSON file not found at path: {Path}");
            }
            return connectivity;
        }
    }
}