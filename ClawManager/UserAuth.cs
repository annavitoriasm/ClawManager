using Stocku_.Db;
using Npgsql;

namespace ManageUser
{
    public class UserAuth
    {
        private readonly DbConnection C;

        public UserAuth()
        {
            C = new();
        }
        public User? Authenticate(string username, string password)
        {
            using (var connection = new NpgsqlConnection(C.Connection.ConnectionString))
            {
                if (C.Connection.State != System.Data.ConnectionState.Open)
                {
                    C.Connection.Open();
                }

                string query = "SELECT \"id\", \"username\", \"password\" FROM \"User\" WHERE \"username\" = @Username";
                using (var cmd = new NpgsqlCommand(query, C.Connection))
                {
                    cmd.Parameters.AddWithValue("Username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var storedUsername = reader.GetString(1);
                            var storedHashedPassword = reader.GetString(2);

                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                return new User(id, storedUsername, storedHashedPassword);
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}