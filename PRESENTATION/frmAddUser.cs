using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION {
    public partial class frmAddUser : Form {
       
        LOGIC.LogicalUser logicUser = new LOGIC.LogicalUser();  
        public frmAddUser() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;    

             string message = logicUser.LogicalAddUser(username, password);
            if(message == "Agregado") {
                MessageBox.Show("You have insert one new user");
            }
        }

        private void btnShowUpdate_Click(object sender, EventArgs e) {
            FrmUpdateDeleteUser frmupdate = new FrmUpdateDeleteUser();
            frmupdate.Show();
            this.Hide();
        }
    }
}
