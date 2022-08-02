using System.Reflection.Metadata;
using MySqlConnector;
using TwentyQuestionsConsoleApp.Animals;

namespace TwentyQuestionsWebApp.Animals;

public class QuestionAlgorithm
{
    private List<Animal> _animals;
    
    public QuestionAlgorithm()
    {
    }

    public string BalanceProperties(List<Animal> _animals)
    {
        int targetCount = _animals.Count / 2;
        int smallestDiffToTarget = targetCount;
        string bestQuestion = "";
        Dictionary<string, int> propertiesCounted = new Dictionary<string, int>();
        
        foreach (var property in _animals[0].GetType().GetProperties())
        {
            if (property.GetValue(_animals[0]).GetType() == typeof(bool))
            {
                propertiesCounted.Add(property.Name , Animal.Where(_animals, property.Name, true).Count);
                Console.WriteLine($"number of {property.Name}: {propertiesCounted[property.Name]}");

                var thisKey = property.Name;
                var thisVal = propertiesCounted[property.Name];
                
                bestQuestion = (targetCount - thisVal) < smallestDiffToTarget ? thisKey : bestQuestion;
                smallestDiffToTarget = (targetCount - thisVal) < smallestDiffToTarget ? targetCount - thisVal : smallestDiffToTarget;
            }
        }

        return bestQuestion;
    }

}