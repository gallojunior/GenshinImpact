using GenshinImpact.Models;

namespace GenshinImpact.Services;

public class GenshinService
{
    private CharacterService _characters;
    private VisionService _visions;

    public GenshinService()
    {
        _characters = new CharacterService();
        _visions = new VisionService();
    }

    public CharacterService Characters
    {
        get
        {
            if (_characters == null)
            {
                _characters = new CharacterService();
            }
            return _characters;
        }
    }

    public VisionService Visions
    {
        get
        {
            if (_visions == null)
            {
                _visions = new VisionService();
            }
            return _visions;
        }
    }

    public IndexDto GetIndexDto()
    {
        return new IndexDto()
        {
            Characters = _characters.GetCharacters(),
            Visions = _visions.GetVisions()
        };
    }
   
}
