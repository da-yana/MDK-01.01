using ModelViewLib.Model;
using ModelViewLib.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UsersTableView tableView = new UsersTableView();
            Controls.Add(tableView);
            tableView.Dock = DockStyle.Top;
            UserPresenter user = new UserPresenter(new MemoryUsersModel(), tableView);
        }
    }
}
