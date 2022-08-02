namespace TwentyQuestionsConsoleApp.Animals;

public class Animal
{
    public Animal(string _name)
    {
        Name = _name;
    }

    public string? Name { get; set; }
    public bool IsPet { get; set; }
    public bool IsSeaDwelling { get; set; }
    public bool IsDomestic { get; set; }
    public bool IsMammal { get; set; }
    public bool IsBird { get; set; }
    public bool IsInsect { get; set; }
    public bool IsWild { get; set; }
    

    public static List<Animal> Where(List<Animal> _animals, string _prop, bool _trueOrFalse)
    {
        return _animals.Where(x => (bool)x.GetType().GetProperty(_prop).GetValue(x, null) == _trueOrFalse).ToList();
    }
    
}