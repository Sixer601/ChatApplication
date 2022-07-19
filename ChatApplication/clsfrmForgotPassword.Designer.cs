namespace ChatApplication {
	partial class clsfrmForgotPassword {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmForgotPassword));
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblInformation = new System.Windows.Forms.Label();
			this.erpEmail = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.erpEmail)).BeginInit();
			this.SuspendLayout();
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.Location = new System.Drawing.Point(178, 95);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(118, 29);
			this.btnResetPassword.TabIndex = 0;
			this.btnResetPassword.Text = "Reset Password";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			this.btnResetPassword.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(12, 56);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(51, 16);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "E-mail: ";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(69, 53);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(209, 22);
			this.txtEmail.TabIndex = 2;
			// 
			// lblInformation
			// 
			this.lblInformation.AutoSize = true;
			this.lblInformation.Location = new System.Drawing.Point(12, 9);
			this.lblInformation.MaximumSize = new System.Drawing.Size(300, 0);
			this.lblInformation.Name = "lblInformation";
			this.lblInformation.Size = new System.Drawing.Size(292, 32);
			this.lblInformation.TabIndex = 3;
			this.lblInformation.Text = "Enter your e-mail address here, then check your inbox for a link to reset your pa" +
    "ssword.";
			// 
			// erpEmail
			// 
			this.erpEmail.ContainerControl = this;
			// 
			// clsfrmForgotPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 136);
			this.Controls.Add(this.lblInformation);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.btnResetPassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "clsfrmForgotPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Password Reset";
			((System.ComponentModel.ISupportInitialize)(this.erpEmail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblInformation;
		private System.Windows.Forms.ErrorProvider erpEmail;
	}
}