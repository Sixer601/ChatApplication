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
using System.Data.SqlClient;

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
			     string strSQLConnetionString = "Data Source=mis-sdbgis;Initial Catalog=GIS;Integrated Security=SSPI;Uid = GRIMMWAY\\SBeardsley";
			     // Integrated Security is for Windows Authentication. This code is only for grimmway's database.
			     // TODO: Change connection string to match computer's database.
			     // TODO: Implement a remote connection to computer's database using IP + port.
			     SqlConnection scnSQLConnection;
			     scnSQLConnection = new SqlConnection(strSQLConnetionString);
			     try {
				    scnSQLConnection.Open();
				    // TODO: Create adding of account information into the database.
				    scnSQLConnection.Close();
				    this.DialogResult = DialogResult.OK;
			     }
			     catch (Exception ex) {
				    // TODO: Add way to provide error stating that a connection to the database could not be established.
			     }
			}
		}
	}
}
