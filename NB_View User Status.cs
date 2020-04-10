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
    public partial class NB_ViewUserStatus : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MR8GT52J\\SQLEXPRESS01;Initial Catalog=HymanComm_NotebookApp;Integrated Security=true");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        private readonly HymanComm_NotebookAppEntities _NBdb;
        public NB_ViewUserStatus()
        {
            InitializeComponent();
            _NBdb = new HymanComm_NotebookAppEntities();
            
        }

        private void Search_tb(object sender, EventArgs e)
        {
            SearchData(NB_Searchbox.Text);
        }

        public void SearchData(string search)
        {
            con.Open();
            string query = "select * from UserLogins where Firstname like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            gv_ViewUserStatus.DataSource = dt;
            gv_ViewUserStatus.Refresh();
            gv_ViewUserStatus.Columns["Id"].Visible = false;
            gv_ViewUserStatus.Columns["Password"].Visible = false;
            con.Close();
        }

        private void NB_ViewUserStatus_Load(object sender, EventArgs e)
        {
            var user = _NBdb.UserLogins.Select(from => new
            {
            //Select from specific columns
                ID = from.id,
                Userame = from.Username,
                Firstname = from.Firstname,
                Lastname = from.Lastname,
                Status = from.isActive,
                DateStarted = from.Start_date
            }).ToList();

            //Rename column names
            gv_ViewUserStatus.DataSource = user;
            gv_ViewUserStatus.Columns[0].HeaderText = "ID";
            gv_ViewUserStatus.Columns[1].HeaderText = "USERNAME";
            gv_ViewUserStatus.Columns[2].HeaderText = "FIRSTNAME";
            gv_ViewUserStatus.Columns[3].HeaderText = "LASTNAME";
            gv_ViewUserStatus.Columns[4].HeaderText = "ACTIVE STATUS";
            gv_ViewUserStatus.Columns[5].HeaderText = "DATE STARTED";
        }

        //Deactivate or activate user
        private void DeactivateUser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gv_ViewUserStatus.SelectedRows[0].Cells["Id"].Value;
                var user = _NBdb.UserLogins.FirstOrDefault(from => from.id == id);
                user.isActive = user.isActive == true ? false : true;
                _NBdb.SaveChanges();
                gv_ViewUserStatus.Refresh();
                MessageBox.Show($"{user.Username}'s active status has changed!");

                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        
    }
}
