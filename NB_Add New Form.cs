using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HymanComm_NotebookApp
{
    public partial class NB_AddNewUser : Form
    {
        private readonly HymanComm_NotebookAppEntities _NBdb;
        public NB_AddNewUser()
        {
            InitializeComponent();
            _NBdb = new HymanComm_NotebookAppEntities();
        }

        //Populate roles in dropdown menu
        private void AddNewUser_Load(object sender, EventArgs e)
        {
            var roles = _NBdb.Roles.ToList();
            AccessLevel_cb.DisplayMember = "Position";
            AccessLevel_cb.ValueMember = "id";
            AccessLevel_cb.DataSource = roles;
        }

        //Enter user credentials and save
        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var firstname = Firstname_tb.Text;
                var lastname = Lastname_tb.Text;
                var username = Username_tb.Text;
                var password = Password_tb.Text;
                var rolesId = (int)AccessLevel_cb.SelectedValue;
                var startDate = Date_Started.Value;
                var isValid = true;
                



                if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(username))
                {
                    isValid = false;
                    MessageBox.Show("Missing Information (Username/Password)");
                }

                if (string.IsNullOrWhiteSpace(Password_tb.Text) || string.IsNullOrWhiteSpace(AccessLevel_cb.Text))
                {
                    isValid = false;
                    MessageBox.Show("Missing Information (Password/Access Level)");
                }

                if (string.IsNullOrWhiteSpace(Date_Started.Text))
                {
                    isValid = false;
                    MessageBox.Show("Missing Information (Start Date)");
                }

                /*if (promodate > startDate)
                {
                    isValid = false;
                    MessageBox.Show("Invalid date selected");
                }*/

                if(isValid == true)
                {
                    var hashed_password = Utils.HashPassword(Password_tb.Text);

                    var user = new UserLogin
                    {
                        Firstname = Firstname_tb.Text,
                        Lastname = Lastname_tb.Text,
                        Username = Username_tb.Text,
                        Password = hashed_password,
                        Start_date = Date_Started.Value,
                        isActive = true,
                    };

                    _NBdb.UserLogins.Add(user);
                    _NBdb.SaveChanges();

                    var userid = user.id;
                    var userRole = new UserRole
                    {
                        Roles_Id = rolesId,
                        Users_Id = userid,
                    };
                    

                    _NBdb.UserRoles.Add(userRole);
                    _NBdb.SaveChanges();
                    MessageBox.Show("User Added Successfully...");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has Occured...");
            }
            Close();
        }

        //Closes window
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
