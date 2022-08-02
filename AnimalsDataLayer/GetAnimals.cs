using MySqlConnector;
using TwentyQuestionsConsoleApp.Animals;

namespace TwentyQuestionsWebApp.AnimalsDataLayer;

public class GetAnimals
{
    public List<Animal> GetAllAnimals()  
    {
        List<Animal> list = new List<Animal>();
        AnimalsDataContext animalsDataContext = new AnimalsDataContext();

        using (MySqlConnection conn = new MySqlConnection(animalsDataContext.GetConnection().ConnectionString))  
        {  
            conn.Open();
            Console.WriteLine(conn.ConnectionString);
            MySqlCommand cmd = new MySqlCommand("select * from Animals", conn);

            using (var reader = cmd.ExecuteReader())  
            {  
                while (reader.Read())  
                {  
                    list.Add(new Animal(reader["Name"].ToString())  
                    {  
                        IsBird = Convert.ToBoolean(reader["IsBird"]),  
                        IsDomestic = Convert.ToBoolean(reader["IsDomestic"]),  
                        IsInsect = Convert.ToBoolean(reader["IsInsect"]),
                        IsSeaDwelling = Convert.ToBoolean(reader["IsSeaDwelling"]),  
                        IsMammal = Convert.ToBoolean(reader["IsMammal"]),  
                        IsPet = Convert.ToBoolean(reader["IsPet"]),
                    });  
                }  
            }  
        }  
        return list;  
    }
}