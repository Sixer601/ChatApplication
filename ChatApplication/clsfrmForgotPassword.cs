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
	public partial class clsfrmForgotPassword : Form {
		public clsfrmForgotPassword() {
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e) {
			Regex EmailRegex = new Regex(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}");

			if (!EmailRegex.IsMatch(txtEmail.Text)) {
				erpEmail.SetError(txtEmail, "Please enter a valid e-mail address.");
			}
			else {
				this.DialogResult = DialogResult.Cancel;
			}
		}
	}
}
