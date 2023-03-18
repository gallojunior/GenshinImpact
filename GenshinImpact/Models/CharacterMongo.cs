namespace GenshinImpact.Models;

public class Element
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public string Color { get; set; }
}

public class Region
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Arconte { get; set; }
    public Element Element { get; set; }
}

public class CharacterMongo
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quality { get; set; }
    public Element Element { get; set; }
    public string Weapon { get; set; }
    public Region Region { get; set; }
    public string Birthday { get; set; }
    public string Constelation { get; set; }
    public List<string> Affiliations { get; set; }
    public string SpecialDish { get; set; }
    public List<string> Titles { get; set; }
    public string Picture { get; set; }
    public string CardPicture { get; set; }
}
