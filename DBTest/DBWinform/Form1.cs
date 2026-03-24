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
        PGUsersLoader loader = new PGUsersLoader();
        List<string> info = new List<string>();

        public Form1()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<Users> users = loader.Load();
            dataGridView.DataSource = users;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Внимамние!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                Users user = row.DataBoundItem as Users;
                loader.DeleteSelectUser(user.Login);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить все записи?", "Внимамние!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loader.ClearAllUsers();
            }
        }
    }
}