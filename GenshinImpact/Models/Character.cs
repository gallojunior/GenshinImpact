namespace GenshinImpact.Models;

public class Character
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quality { get; set; }
    public string Vision { get; set; }
    public string Weapon { get; set; }
    public string Region { get; set; }
    public string Birthday { get; set; }
    public string Constelation { get; set; }
    public List<string> Affiliations { get; set; }
    public string SpecialDish { get; set; }
    public List<string> Titles { get; set; }
    public string CardPicture { get; set; }
}
