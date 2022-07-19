using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
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

				//var smtpClient = new SmtpClient("smtp.gmail.com") {
				//	Port = 587,
				//	Credentials = new NetworkCredential("email", "password"),
				//	EnableSsl = true,
				//};

				//smtpClient.Send("email", "recipient", "subject", "body");

				//this.DialogResult = DialogResult.Cancel;
			}
		}
	}
}
