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
    public partial class NB_Homepage : Form
    {
        public NB_Homepage()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var login = new NB_LoginScreen();
            login.ShowDialog();
            Hide();
            
        }
    }
}
