using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HymanComm_NotebookApp
{
    
    public partial class NB_EditUsers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MR8GT52J\\SQLEXPRESS01;Initial Catalog=HymanComm_NotebookApp;Integrated Security=true");
        DataTable dt;
        SqlDataAdapter adpt;
        private readonly HymanComm_NotebookAppEntities _NBdb;
        public NB_EditUsers()
        {
            InitializeComponent();
            _NBdb = new HymanComm_NotebookAppEntities();
        }

        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from employee", con);
            dt = new DataTable();
            adpt.Fill(dt);
            gv_UserList.DataSource = dt;
            gv_UserList.Columns["Id"].Visible = false;
            gv_UserList.Columns["Password"].Visible = false;
            con.Close();
        }

        private void NB_EditUsers_Load(object sender, EventArgs e)
        {
            //Select from specific columns
            var user = _NBdb.UserLogins.Select(from => new
            {
                ID = from.id,
                Userame = from.Username,
                Firstname = from.Firstname,
                Lastname = from.Lastname,
                Status = from.isActive,
                DateStarted = from.Start_date,
                
                
            }).ToList();

            //Rename column names
            gv_UserList.DataSource = user;
            gv_UserList.Columns[0].HeaderText = "ID";
            gv_UserList.Columns[1].HeaderText = "USERNAME";
            gv_UserList.Columns[2].HeaderText = "FIRSTNAME";
            gv_UserList.Columns[3].HeaderText = "LASTNAME";
            gv_UserList.Columns[4].HeaderText = "ACTIVE STATUS";
            gv_UserList.Columns[5].HeaderText = "DATE STARTED";
        }

        private void EditUserCredentials_btn_Click(object sender, EventArgs e)
        {
            var id = (int)gv_UserList.SelectedRows[0].Cells["Id"].Value;
            var user = _NBdb.UserLogins.FirstOrDefault(from => from.id == id);
            var EditUsers = new NB_EditUserForm(user);
            EditUsers.ShowDialog();
        }

        private void ResetPassword_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gv_UserList.SelectedRows[0].Cells["Id"].Value;
                var user = _NBdb.UserLogins.FirstOrDefault(from => from.id == id);
                var genericPassword = "Password1";
                var hash = Utils.HashPassword(genericPassword);
                user.Password = hash;

                _NBdb.SaveChanges();
                MessageBox.Show($"{user.Username}'s password has been reset!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        //Delete user credentials from gridview and database
        private void DeleteUserCredentials_btn_Click(object sender, EventArgs e)
        {
            var id = (int)gv_UserList.SelectedRows[0].Cells["Id"].Value;

            var user = _NBdb.UserLogins.FirstOrDefault(from => from.id == id);

            _NBdb.UserLogins.Remove(user);
            _NBdb.SaveChanges();
            MessageBox.Show($"{user.Username}'s has been deleted!");
        }

        //Search for user
        private void Search_tb(object sender, EventArgs e)
        {
            SearchData(NB_SearchBox.Text);
        }

        public void SearchData(string search)
        {
            con.Open();
            string query = "select * from UserLogins where Firstname like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            gv_UserList.DataSource = dt;
            gv_UserList.Refresh();
            con.Close();

            
        }
    }
}
