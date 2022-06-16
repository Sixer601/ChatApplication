namespace ChatApplication {
	partial class clsfrmSignIn {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
		  this.components = new System.ComponentModel.Container();
		  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmSignIn));
		  this.lblUsername = new System.Windows.Forms.Label();
		  this.lblPassword = new System.Windows.Forms.Label();
		  this.txtUsername = new System.Windows.Forms.TextBox();
		  this.txtPassword = new System.Windows.Forms.TextBox();
		  this.btnOK = new System.Windows.Forms.Button();
		  this.btnCancel = new System.Windows.Forms.Button();
		  this.erpUsername = new System.Windows.Forms.ErrorProvider(this.components);
		  this.erpPassword = new System.Windows.Forms.ErrorProvider(this.components);
		  ((System.ComponentModel.ISupportInitialize)(this.erpUsername)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.erpPassword)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // lblUsername
		  // 
		  this.lblUsername.AutoSize = true;
		  this.lblUsername.Location = new System.Drawing.Point(10, 11);
		  this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		  this.lblUsername.Name = "lblUsername";
		  this.lblUsername.Size = new System.Drawing.Size(61, 13);
		  this.lblUsername.TabIndex = 0;
		  this.lblUsername.Text = "Username: ";
		  // 
		  // lblPassword
		  // 
		  this.lblPassword.AutoSize = true;
		  this.lblPassword.Location = new System.Drawing.Point(10, 40);
		  this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		  this.lblPassword.Name = "lblPassword";
		  this.lblPassword.Size = new System.Drawing.Size(59, 13);
		  this.lblPassword.TabIndex = 1;
		  this.lblPassword.Text = "Password: ";
		  // 
		  // txtUsername
		  // 
		  this.txtUsername.Location = new System.Drawing.Point(74, 10);
		  this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		  this.txtUsername.Name = "txtUsername";
		  this.txtUsername.Size = new System.Drawing.Size(129, 20);
		  this.txtUsername.TabIndex = 2;
		  // 
		  // txtPassword
		  // 
		  this.txtPassword.Location = new System.Drawing.Point(74, 40);
		  this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		  this.txtPassword.Name = "txtPassword";
		  this.txtPassword.Size = new System.Drawing.Size(129, 20);
		  this.txtPassword.TabIndex = 3;
		  // 
		  // btnOK
		  // 
		  this.btnOK.Location = new System.Drawing.Point(99, 70);
		  this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		  this.btnOK.Name = "btnOK";
		  this.btnOK.Size = new System.Drawing.Size(56, 19);
		  this.btnOK.TabIndex = 4;
		  this.btnOK.Text = "OK";
		  this.btnOK.UseVisualStyleBackColor = true;
		  this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
		  // 
		  // btnCancel
		  // 
		  this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		  this.btnCancel.Location = new System.Drawing.Point(160, 70);
		  this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		  this.btnCancel.Name = "btnCancel";
		  this.btnCancel.Size = new System.Drawing.Size(56, 19);
		  this.btnCancel.TabIndex = 5;
		  this.btnCancel.Text = "Cancel";
		  this.btnCancel.UseVisualStyleBackColor = true;
		  // 
		  // erpUsername
		  // 
		  this.erpUsername.ContainerControl = this;
		  // 
		  // erpPassword
		  // 
		  this.erpPassword.ContainerControl = this;
		  // 
		  // clsfrmSignIn
		  // 
		  this.AcceptButton = this.btnOK;
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(225, 98);
		  this.Controls.Add(this.btnCancel);
		  this.Controls.Add(this.btnOK);
		  this.Controls.Add(this.txtPassword);
		  this.Controls.Add(this.txtUsername);
		  this.Controls.Add(this.lblPassword);
		  this.Controls.Add(this.lblUsername);
		  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		  this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		  this.Name = "clsfrmSignIn";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		  this.Text = "Sign In";
		  ((System.ComponentModel.ISupportInitialize)(this.erpUsername)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.erpPassword)).EndInit();
		  this.ResumeLayout(false);
		  this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ErrorProvider erpUsername;
		private System.Windows.Forms.ErrorProvider erpPassword;
	}
}