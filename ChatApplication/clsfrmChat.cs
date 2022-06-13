using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication {
	public partial class clsfrmMainForm : Form {
		public clsfrmMainForm() {
			clsfrmMainMenu frmMainMenu = new clsfrmMainMenu();
			frmMainMenu.ShowDialog();
			if (frmMainMenu.DialogResult == DialogResult.OK) {
				InitializeComponent();
			}
		}
	}
}
