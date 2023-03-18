using System.Text.Json;
namespace GenshinImpact.Services;

public abstract class JsonFileService<T>
{
    private string JsonFile { get; set; }

    public JsonFileService(string jsonFile)
    {
        JsonFile = jsonFile;
    }

    protected IEnumerable<T> ReturnObjects()
    {
        string json = ReadFile();
        return JsonSerializer.Deserialize<List<T>>(json);
    }

    private string ReadFile()
    {
        using (StreamReader reader = new StreamReader(JsonFile))
        {
            string data = reader.ReadToEnd();
            return data;
        }
    }
}
