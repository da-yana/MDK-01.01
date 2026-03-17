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
       List<string> info = new List<string>();

        public Form1()
        {
            InitializeComponent();
            PGUsersLoader loader = new PGUsersLoader();
            List<Users> users = loader.Load();
            dataGridView.DataSource = users;
        }
       
    }
}
