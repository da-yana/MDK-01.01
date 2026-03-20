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
        private const string ConnectSetting = "Host=192.168.1.48;Username=st50-9;Password=509;Database=Users_P-30";
        public List<Users> Load()
        {
            try
            {


                List<Users> result = new List<Users>();
                var con = new NpgsqlConnection(ConnectSetting);
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
            catch (NpgsqlException npgsql)
            {
                MessageBox.Show($"Ошибка!: {npgsql.Message}");
                return null;
            }
        } 
        public bool DeleteSelectUser(string login)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(ConnectSetting);
                con.Open();
                var sql = @"DELETE FROM ourusers WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                return result;
            }
            catch (NpgsqlException nsql)
            {
                MessageBox.Show($"Ошибка!: {nsql.Message}");
                return false;
            }
            
           
        }
    }
}
