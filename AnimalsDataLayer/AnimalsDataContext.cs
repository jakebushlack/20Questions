using MySqlConnection = MySqlConnector.MySqlConnection;

namespace TwentyQuestionsWebApp.AnimalsDataLayer;

public class AnimalsDataContext
{
    private readonly string _connectionString;

    public AnimalsDataContext()
    {
        _connectionString = "server=animals.ceevtk6zssio.us-west-1.rds.amazonaws.com;port=3306;uid=admin;pwd=bushlack;database=Animals";
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(_connectionString);
    }
    
    
}