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
    public partial class NB_EditUserForm : Form
    {
        private readonly HymanComm_NotebookAppEntities _NBdb;

        public NB_EditUserForm()
        {
            InitializeComponent();
            //EditUserForm_lbl.Text = "Edit User";
        }
        public NB_EditUserForm(UserLogin UserToEdit)
        {
            InitializeComponent();
            _NBdb = new HymanComm_NotebookAppEntities();
            PopulateFields(UserToEdit);
        }

        private void PopulateFields(UserLogin editUser)
        {
            Id_lb.Text = editUser.id.ToString();
            Firstname_tb.Text = editUser.Firstname;
            Lastname_tb.Text = editUser.Lastname;
            Username_tb.Text = editUser.Username;

            var roles = _NBdb.Roles.ToList();
            AccessLevel_cb.DisplayMember = "Position";
            AccessLevel_cb.ValueMember = "id";
            AccessLevel_cb.DataSource = roles;
            if(editUser.UserRoles.Count > 0)
            {
                AccessLevel_cb.SelectedValue = editUser.UserRoles.FirstOrDefault().Roles_Id;
            }
            
        }

        //Update user
        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(Id_lb.Text);
                var user = _NBdb.UserLogins.FirstOrDefault(from => from.id == id);
                var roleId = int.Parse(AccessLevel_cb.SelectedValue.ToString());
                var isValid = true;

                user.Firstname = Firstname_tb.Text;
                user.Lastname = Lastname_tb.Text;
                user.Username = Username_tb.Text;
                user.Start_date = Start_Date.Value;
                user.Promotion_date = Promo_Date.Value;

                var userRole = user.UserRoles.FirstOrDefault();
                user.UserRoles.Remove(userRole);

                var newUserRole = new UserRole
                {
                    Roles_Id = roleId,
                    Users_Id = user.id
                };

                user.UserRoles.Add(newUserRole);

                

                if (Promo_Date.Value <= Start_Date.Value)
                {
                    isValid = false;
                    MessageBox.Show("Invalid date selected");
                }

                _NBdb.SaveChanges();
                MessageBox.Show("User Updated!");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Editing User");
            }
            
        }

        //Close edit user form
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
