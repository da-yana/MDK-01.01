using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWinform
{
    public class PGUsersLoader
    {
        BindingList<Users> loader = new BindingList<Users>();
        private const string ConnectSetting = "Host=192.168.1.48;Username=st50-9;Password=509;Database=Users_P-30";
        public BindingList<Users> Load()
        {
            try
            {
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
                    loader.Add(users);
                }
                return loader;
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
                bool deleteResult = false;
                var con = new NpgsqlConnection(ConnectSetting);
                con.Open();
                var sql = @"DELETE FROM ourusers WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);

                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    deleteResult = true;
                    for (int index = 0; index < loader.Count; index++)
                    {
                        if (loader[index].Login == login)
                        {
                            loader.RemoveAt(index);
                            index--;
                        }
                    }
                }
                return deleteResult;
            }
            catch (NpgsqlException nsql)
            {
                MessageBox.Show($"Ошибка!: {nsql.Message}");
                return false;
            }
        }
            public bool ClearAllUsers()
            {
                try
                {
                    bool result = false;
                    var con = new NpgsqlConnection(ConnectSetting);
                    con.Open();
                    var sql = "DELETE FROM ourusers";
                    var cmd = new NpgsqlCommand(sql, con);

                    int execute = cmd.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        result = true;
                        loader.Clear();
                    }
                    return result;
                }
                catch (NpgsqlException exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}");
                    return false;
                }

            }
    }
}
