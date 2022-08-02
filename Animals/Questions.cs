using Microsoft.VisualBasic;

namespace TwentyQuestionsWebApp.Animals;

public class Questions
{
    public Questions()
    {
        
    }

    public string Question(string _prop)
    {
        string prop = _prop.Remove(0, 2);
        string article = CharacterExtentions.IsVowel(prop[0]) ? "an" : "a";
        return $"Is your animal {article} {prop}?";
    }
}