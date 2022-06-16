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

	   private void btnOK_Click (object sender, EventArgs e){
		  string strSQLConnetionString = "Data Source=mis-sdbgis;Initial Catalog=GIS;Integrated Security=SSPI;Uid = GRIMMWAY\\SBeardsley";
		  // Integrated Security is for Windows Authentication. This code is only for grimmway's database.
		  // TODO: Change connection string to match computer's database.
		  // TODO: Implement a remote connection to computer's database using IP + port.
		  SqlConnection scnSQLConnection;
		  scnSQLConnection = new SqlConnection(strSQLConnetionString);
		  try{
			 scnSQLConnection.Open();
			 // TODO: Create check against database for if username and password exist in database.
			 scnSQLConnection.Close();
		  }
		  catch (Exception ex)
		  {
			 MessageBox.Show("Can not open connection ! ");
		  }
	   }
    }
}
