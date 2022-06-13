using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class clsfrmMainMenu: Form
    {
	   public clsfrmMainMenu ()
	   {
		  InitializeComponent();
	   }

		private void btnSignIn_Click(object sender, EventArgs e) {
			clsfrmSignIn frmSignIn = new clsfrmSignIn();
			frmSignIn.ShowDialog();
			if (frmSignIn.DialogResult == DialogResult.OK) {
				this.DialogResult = DialogResult.OK;
			}
		}

		private void btnSignUp_Click(object sender, EventArgs e) {
			clsfrmSignUp frmSignUp = new clsfrmSignUp();
			frmSignUp.ShowDialog();
			if (frmSignUp.DialogResult == DialogResult.OK) {
				this.DialogResult = DialogResult.OK;
			}
		}

		private void btnForgotPassword_Click(object sender, EventArgs e) {
			clsfrmForgotPassword frmForgotPassword = new clsfrmForgotPassword();
			frmForgotPassword.ShowDialog();
			if (frmForgotPassword.DialogResult == DialogResult.OK) {
				this.DialogResult = DialogResult.OK;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
