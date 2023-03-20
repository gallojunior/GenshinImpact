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

    public DetailsDto GetDetailedCharacter(string Name)
    {
        var characters = GetCharacters().ToArray();
        var index = Array.IndexOf(characters, characters.Where(p => p.Name.Equals(Name)).FirstOrDefault());
        var character = new DetailsDto()
        {
            Current = characters[index],
            Prior = index - 1 < 0 ? null : characters[index - 1],
            Next = index + 1 >= characters.Count() ? null : characters[index + 1]
        };
        return character;
    }
}
