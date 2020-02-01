namespace AuthServer.Models
{
    public interface IAuthDatabaseSettings
    {
        string AuthUsersCollectionName { get; set; }
        string LoginStatusCollectionName { get; set; }
        string ConnectionString { get; set;}
        string DatabaseName { get; set; }
    }

    public class AuthDatabaseSettings : IAuthDatabaseSettings
    {
        public AuthDatabaseSettings()
        {
        }

        public string AuthUsersCollectionName { get; set; }
        public string LoginStatusCollectionName { get; set; }
        public string ConnectionString { get; set;}
        public string DatabaseName { get; set; }
    }
}