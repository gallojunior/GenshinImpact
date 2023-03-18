using GenshinImpact.Models;
namespace GenshinImpact.Services;

public class CharacterService : JsonFileService<Character>
{
    private IEnumerable<Character> characters;

    public CharacterService() : base(@"Data\characters.json")
    {
        characters = ReturnObjects();
    }

    public CharacterService(string jsonFile) : base(jsonFile)
    {
        characters = ReturnObjects();
    }

    public List<Character> GetCharacters()
    {
        return characters.ToList();
    }

    public Character GetCharacter(string Name)
    {
        return characters.FirstOrDefault(c => c.Name.Equals(Name));
    }
}
