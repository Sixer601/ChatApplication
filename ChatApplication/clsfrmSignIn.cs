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

namespace ChatApplication {
	public partial class clsfrmSignIn : Form {
		public clsfrmSignIn() {
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e) {

			erpUsername.SetError(txtUsername, "");
			erpPassword.SetError(txtPassword, "");

			if (string.IsNullOrEmpty(txtUsername.Text)) {
				erpUsername.SetError(txtUsername, "Please enter a username.");
			}
			else if (string.IsNullOrEmpty(txtPassword.Text)) {
				erpPassword.SetError(txtPassword, "Please enter a password.");
			}
			else {
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
