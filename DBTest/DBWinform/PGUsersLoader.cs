using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWinform
{
    public class PGUsersLoader
    {
        public List<Users> Load()
        {
            List<Users> result = new List<Users>();
            var cs = "Host=192.168.1.48;Username=st50-9;Password=509;Database=Users_P-30";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "SELECT login, password, age, first_name,  last_name FROM ourusers";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Users users = new Users()
                {
                    Login = reader.GetString(0),
                    Age = reader.GetInt32(2),
                    FirstName = reader.GetString(3),
                    LastName = reader.GetString(4),
                    Password = reader.GetString(1)
                };
                result.Add(users);
            }
            return result;
        }
    }
}
