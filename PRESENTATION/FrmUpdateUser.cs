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
    public partial class FrmUpdateUser : Form {

        LOGIC.LogicalUpdate logicUpdate = new LOGIC.LogicalUpdate();

        public FrmUpdateUser() {
            InitializeComponent();
        }

      
        private void btnUpdate_Click(object sender, EventArgs e) {
            int idUser = Convert.ToInt32(this.txtIdUser.Text);
            string user = this.txtUser.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string status = this.txtStatus.Text.Trim();


            string message = logicUpdate.LogicalUpdateUser(idUser, user, password, status);    
            if (message == "Usuario actualizado") {
                MessageBox.Show("You update the user: " + idUser);
            } else {
                MessageBox.Show(message);
            }
        }

        private void btnClean_Click(object sender, EventArgs e) {
            this.txtIdUser.Text = "";
            this.txtUser.Text = "";
            this.txtPassword.Text = "";
            this.txtStatus.Text = "";
        }
    }
}
