namespace ChatApplication {
	partial class clsfrmSignUp {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmSignUp));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblUsernameDescription = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblPasswordDescription = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblEmailDescription = new System.Windows.Forms.Label();
			this.erpUsername = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPassword = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpEmail = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.erpUsername)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEmail)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(406, 212);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(487, 212);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 16);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(76, 16);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "Username: ";
			// 
			// lblUsernameDescription
			// 
			this.lblUsernameDescription.AutoSize = true;
			this.lblUsernameDescription.Location = new System.Drawing.Point(391, 16);
			this.lblUsernameDescription.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblUsernameDescription.Name = "lblUsernameDescription";
			this.lblUsernameDescription.Size = new System.Drawing.Size(171, 32);
			this.lblUsernameDescription.TabIndex = 3;
			this.lblUsernameDescription.Text = "This is the name that will be displayed to other users.";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 69);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(73, 16);
			this.lblPassword.TabIndex = 4;
			this.lblPassword.Text = "Password: ";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(94, 13);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(243, 22);
			this.txtUsername.TabIndex = 5;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(94, 66);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(243, 22);
			this.txtPassword.TabIndex = 6;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(94, 137);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(243, 22);
			this.txtEmail.TabIndex = 7;
			// 
			// lblPasswordDescription
			// 
			this.lblPasswordDescription.AutoSize = true;
			this.lblPasswordDescription.Location = new System.Drawing.Point(365, 69);
			this.lblPasswordDescription.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblPasswordDescription.Name = "lblPasswordDescription";
			this.lblPasswordDescription.Size = new System.Drawing.Size(197, 48);
			this.lblPasswordDescription.TabIndex = 8;
			this.lblPasswordDescription.Text = "This is used to authenticate the user. It is not remembered so write this down so" +
    "mewhere safe.";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(34, 140);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(51, 16);
			this.lblEmail.TabIndex = 9;
			this.lblEmail.Text = "E-mail: ";
			// 
			// lblEmailDescription
			// 
			this.lblEmailDescription.AutoSize = true;
			this.lblEmailDescription.Location = new System.Drawing.Point(362, 140);
			this.lblEmailDescription.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblEmailDescription.Name = "lblEmailDescription";
			this.lblEmailDescription.Size = new System.Drawing.Size(200, 48);
			this.lblEmailDescription.TabIndex = 10;
			this.lblEmailDescription.Text = "This is used in case you need to reset your password. We will not E-mail you for " +
    "anything else.";
			// 
			// erpUsername
			// 
			this.erpUsername.ContainerControl = this;
			// 
			// erpPassword
			// 
			this.erpPassword.ContainerControl = this;
			// 
			// erpEmail
			// 
			this.erpEmail.ContainerControl = this;
			// 
			// clsfrmSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 247);
			this.Controls.Add(this.lblEmailDescription);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblPasswordDescription);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsernameDescription);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "clsfrmSignUp";
			this.Text = "Sign Up";
			((System.ComponentModel.ISupportInitialize)(this.erpUsername)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEmail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblUsernameDescription;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblPasswordDescription;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblEmailDescription;
		private System.Windows.Forms.ErrorProvider erpUsername;
		private System.Windows.Forms.ErrorProvider erpPassword;
		private System.Windows.Forms.ErrorProvider erpEmail;
	}
}