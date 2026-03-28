using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestFileStorage
{
    public class PGUsersStorage : IUsersInterface
    {
        private const string ConnectSetting = "Host=192.168.1.48;Username=st56-3;Password=563;Database=Users_P-30";
        List<User> allUsers = new List<User>();
        public List<User> Load()
        {
            try
            {

                var con = new NpgsqlConnection(ConnectSetting);
                con.Open();
                var sql = "SELECT login, password FROM ourusers";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User users = new User(reader.GetString(0), reader.GetString(1));
                    allUsers.Add(users);
                }
                return allUsers;
            }
            catch (NpgsqlException npgsql)
            {
                MessageBox.Show($"Ошибка!: {npgsql.Message}");
                return null;
            }
        }

        public bool UserRegistration(User user)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(ConnectSetting);
                con.Open();
                var sql = "INSERT INTO ourusers(login, password) VALUES(@login, @password)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    allUsers.Add(user);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }


        public bool UserVerification(string login)
        {
            try
            {
                bool verifResult = false;
                var con = new NpgsqlConnection(ConnectSetting);
                con.Open();
                var sql = "select exists(select 1 from ourusers WHERE login = 'emily_brown')";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                verifResult = (bool)cmd.ExecuteScalar();
                con.Close();
                return verifResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка!: {exception.Message}");
                return false;
            }

        }
    }
}

