using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace ChatApplication {
	public partial class clsfrmSignUp : Form {
		public clsfrmSignUp() {
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e) {
			Regex SpecialCharactersRegex = new Regex(@"[$&+,:;=?@#_\[\]\\\/`~|'<>.^*()%!-]");
			Regex NumberRegex = new Regex(@"[0-9]");
			Regex CapitalRegex = new Regex(@"[A-Z]");

			erpUsername.SetError(txtUsername, "");
			erpPassword.SetError(txtPassword, "");

			if (string.IsNullOrEmpty(txtUsername.Text)) {
				erpUsername.SetError(txtUsername, "Please enter a username.");
			}
			else if (string.IsNullOrEmpty(txtPassword.Text)) {
				erpPassword.SetError(txtPassword, "Please enter a password.");
			}
			else if (!SpecialCharactersRegex.IsMatch(txtPassword.Text)) {
				erpPassword.SetError(txtPassword, "Please use a special character.");
			}
			else if (!NumberRegex.IsMatch(txtPassword.Text)) {
				erpPassword.SetError(txtPassword, "Please use a number.");
			}
			else if (!CapitalRegex.IsMatch(txtPassword.Text)) {
				erpPassword.SetError(txtPassword, "Please use a capital letter.");
			}
			else {
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
