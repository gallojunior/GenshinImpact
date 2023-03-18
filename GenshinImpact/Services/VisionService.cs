using GenshinImpact.Models;

namespace GenshinImpact.Services;

public class VisionService : JsonFileService<Vision>
{
    public VisionService() : base(@"Data\visions.json")
    {
    }

    public VisionService(string jsonFile) : base(jsonFile)
    {
    }

    public List<Vision> GetVisions()
    {
        return ReturnObjects().ToList();
    }

    public Vision GetVision(string Name)
    {
        var visions = GetVisions();
        return visions.FirstOrDefault(v => v.Name.Equals(Name));
    }
}
