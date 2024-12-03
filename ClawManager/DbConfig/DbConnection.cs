using Npgsql;
using dotenv.net;

namespace Stocku_.Db
{
    public class DbConnection
    {
        public NpgsqlConnection Connection { get; private set; }
        public DbConnection()
        {
            DotEnv.Load();

            string? host = Environment.GetEnvironmentVariable("dbHost");
            string? port = Environment.GetEnvironmentVariable("dbPort");
            string? dbName = Environment.GetEnvironmentVariable("dbName");
            string? user = Environment.GetEnvironmentVariable("dbUser");
            string? pass = Environment.GetEnvironmentVariable("dbPass");
            string dsn = $"Host={host};Port={port};Username={user};Password={pass};Database={dbName};SslMode=Require;Trust Server Certificate=true;";

            Connection = new NpgsqlConnection(dsn);
        }
    }
}