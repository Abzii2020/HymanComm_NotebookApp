using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HymanComm_NotebookApp
{
    public partial class NB_MainWindow : Form
    {
        private NB_LoginScreen _login;
        public UserLogin _userLogin;
        public string _roleName;

        public NB_MainWindow()
        {
            InitializeComponent();
        }

        public NB_MainWindow(NB_LoginScreen login, UserLogin user, string roleShortname)
        {
            InitializeComponent();
            _login = login;
            _userLogin = user;
            _roleName = roleShortname;
        }

        //Add User Button Function
        private void AddNewUser_bt_Click(object sender, EventArgs e)
        {
            var mainWindow = new NB_AddNewUser();
            mainWindow.ShowDialog();
            mainWindow.MdiParent = this.MdiParent;
        }

        //Edit User Button Function
        private void EditUser_btn_Click(object sender, EventArgs e)
        {
            var mainWindow = new NB_EditUsers();
            mainWindow.ShowDialog();
            mainWindow.MdiParent = this.MdiParent;
        }

        //View User Button Function
        private void ViewUserStatus_btn_Click(object sender, EventArgs e)
        {
            var mainWindow = new NB_ViewUserStatus();
            mainWindow.ShowDialog();
            mainWindow.MdiParent = this.MdiParent;
        }
       private void NB_MainWindow_Load(object sender, EventArgs e)
        {
            if(_roleName != "A1")
            {
                EditUser_btn.Visible = false;
                AddNewUser_btn.Visible = false;
            }
                       
            var username = _userLogin.Username;
            toolStripStatusLabel1.Text = $"Logged In As: {username}";
        }

        //Close Main Window form
        private void NB_MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        //Logout and return to login screen
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NB_LoginScreen));
            t.Start();
            this.Close();
        }

        public static void NB_LoginScreen()
        {
            Application.Run(new NB_LoginScreen());
        }

        //Exit application completely
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
