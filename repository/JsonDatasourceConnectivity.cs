namespace SubjectApp.repository
{
    public class JsonDatasourceConnectivity : IDatasourceConnectivity
    {

        private readonly JsonDatasourceConfigurator jsonDatasourceConfigurator;

        public JsonDatasourceConnectivity(JsonDatasourceConfigurator jsonDatasourceConfigurator)
        {
            this.jsonDatasourceConfigurator = jsonDatasourceConfigurator;
        }

        public bool Connect()
        {
            return File.Exists(this.jsonDatasourceConfigurator.Path);
        }

        public List<T> FetchAll<T>()
        {
            JsonParser jsonParser = this.jsonDatasourceConfigurator.GetJsonParser();
            String json = jsonParser.ReadJson(this.jsonDatasourceConfigurator.GetPath());
            return jsonParser.ReadFromJson<List<T>>(json) ?? new List<T>();
        }
    }
}