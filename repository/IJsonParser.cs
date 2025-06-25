namespace SubjectApp.repository
{
    public interface IJsonParser
    {
        public T ReadFromJson<T>(String json);
        public String ReadJson(String path);
    }
}