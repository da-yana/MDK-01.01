using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace DBWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var cs = "Host=192.168.1.48;Username=st50-9;Password=509;Database=Users_P-30";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "SELECT version()";
            var cmd = new NpgsqlCommand(sql, con);
            var version = cmd.ExecuteScalar().ToString();

            MessageBox.Show($"Версия PostgreSQL: {version}");
        }
       
    }
}
