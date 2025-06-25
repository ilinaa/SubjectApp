using System.Text.Json;
namespace SubjectApp.repository
{
    public class JsonParser : IJsonParser
    {
        public T? ReadFromJson<T>(string json)
        {
            T? instance = JsonSerializer.Deserialize<T>(json);
            return instance;
        }

        public string ReadJson(string path)
        {
            return path = File.ReadAllText(path);
        }
    }
}