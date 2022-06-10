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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmSignUp));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblUsernameDescription = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblPasswordDescription = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblEmailDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(385, 212);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(466, 212);
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
			this.lblUsernameDescription.Location = new System.Drawing.Point(343, 16);
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(94, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(243, 22);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(94, 66);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(243, 22);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(94, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(243, 22);
			this.textBox3.TabIndex = 7;
			// 
			// lblPasswordDescription
			// 
			this.lblPasswordDescription.AutoSize = true;
			this.lblPasswordDescription.Location = new System.Drawing.Point(346, 69);
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
			this.lblEmailDescription.Location = new System.Drawing.Point(343, 140);
			this.lblEmailDescription.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblEmailDescription.Name = "lblEmailDescription";
			this.lblEmailDescription.Size = new System.Drawing.Size(200, 48);
			this.lblEmailDescription.TabIndex = 10;
			this.lblEmailDescription.Text = "This is used in case you need to reset your password. We will not E-mail you for " +
    "anything else.";
			// 
			// clsfrmSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 247);
			this.Controls.Add(this.lblEmailDescription);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblPasswordDescription);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsernameDescription);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "clsfrmSignUp";
			this.Text = "Sign Up";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblUsernameDescription;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblPasswordDescription;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblEmailDescription;
	}
}