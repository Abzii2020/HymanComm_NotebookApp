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
    public partial class NB_LoginScreen : Form
    {
        private readonly HymanComm_NotebookAppEntities _NBdb;
        //private string username;
        //private string hashed_password;

        public NB_LoginScreen()
        {
            InitializeComponent();
            _NBdb = new HymanComm_NotebookAppEntities();
        }

        private void LoginWin_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = Username_tb.Text.Trim();
                var password = Password_tb.Text;
                

                /*byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sBuilder = new StringBuilder();

                for (int i= 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }*/

                var hashed_password = Utils.HashPassword(password);

                var user = _NBdb.UserLogins.FirstOrDefault(q => q.Username == username && 
                q.Password == hashed_password && q.isActive == true);
                
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortNamePosition = role.Role.Shortname_Position;
                    var mainWindow = new NB_MainWindow(this, user, roleShortNamePosition);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again");
                //throw;
            }

        }
    }
    
}
