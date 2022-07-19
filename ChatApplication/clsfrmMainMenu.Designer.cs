namespace ChatApplication
{
    partial class clsfrmMainMenu
    {
	   /// <summary>
	   /// Required designer variable.
	   /// </summary>
	   private System.ComponentModel.IContainer components = null;

	   /// <summary>
	   /// Clean up any resources being used.
	   /// </summary>
	   /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	   protected override void Dispose (bool disposing)
	   {
		  if (disposing && (components != null))
		  {
			 components.Dispose();
		  }
		  base.Dispose(disposing);
	   }

	   #region Windows Form Designer generated code

	   /// <summary>
	   /// Required method for Designer support - do not modify
	   /// the contents of this method with the code editor.
	   /// </summary>
	   private void InitializeComponent ()
	   {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmMainMenu));
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnForgotPassword = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblSignIn = new System.Windows.Forms.Label();
			this.lblSignUp = new System.Windows.Forms.Label();
			this.lblForgotPassword = new System.Windows.Forms.Label();
			this.pbxImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSignIn
			// 
			this.btnSignIn.Location = new System.Drawing.Point(17, 252);
			this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(132, 28);
			this.btnSignIn.TabIndex = 1;
			this.btnSignIn.Text = "Sign In";
			this.btnSignIn.UseVisualStyleBackColor = true;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// btnSignUp
			// 
			this.btnSignUp.Location = new System.Drawing.Point(17, 334);
			this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(132, 28);
			this.btnSignUp.TabIndex = 2;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = true;
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
			// 
			// btnForgotPassword
			// 
			this.btnForgotPassword.Location = new System.Drawing.Point(17, 411);
			this.btnForgotPassword.Margin = new System.Windows.Forms.Padding(4);
			this.btnForgotPassword.Name = "btnForgotPassword";
			this.btnForgotPassword.Size = new System.Drawing.Size(132, 28);
			this.btnForgotPassword.TabIndex = 3;
			this.btnForgotPassword.Text = "Forgot Password";
			this.btnForgotPassword.UseVisualStyleBackColor = true;
			this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(245, 468);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 28);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblSignIn
			// 
			this.lblSignIn.AutoSize = true;
			this.lblSignIn.Location = new System.Drawing.Point(159, 258);
			this.lblSignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSignIn.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblSignIn.Name = "lblSignIn";
			this.lblSignIn.Size = new System.Drawing.Size(196, 32);
			this.lblSignIn.TabIndex = 5;
			this.lblSignIn.Text = "Use existing account to log in to the chatroom.";
			// 
			// lblSignUp
			// 
			this.lblSignUp.AutoSize = true;
			this.lblSignUp.Location = new System.Drawing.Point(159, 334);
			this.lblSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSignUp.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblSignUp.Name = "lblSignUp";
			this.lblSignUp.Size = new System.Drawing.Size(190, 32);
			this.lblSignUp.TabIndex = 6;
			this.lblSignUp.Text = "Create new account to log in to the chatroom.";
			// 
			// lblForgotPassword
			// 
			this.lblForgotPassword.AutoSize = true;
			this.lblForgotPassword.Location = new System.Drawing.Point(159, 411);
			this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblForgotPassword.MaximumSize = new System.Drawing.Size(200, 0);
			this.lblForgotPassword.Name = "lblForgotPassword";
			this.lblForgotPassword.Size = new System.Drawing.Size(198, 32);
			this.lblForgotPassword.TabIndex = 7;
			this.lblForgotPassword.Text = "Send an E-mail to associated address to reset your password.";
			// 
			// pbxImage
			// 
			this.pbxImage.Image = global::ChatApplication.Properties.Resources.SeanEmailLogo2;
			this.pbxImage.Location = new System.Drawing.Point(84, 13);
			this.pbxImage.Margin = new System.Windows.Forms.Padding(4);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(200, 185);
			this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbxImage.TabIndex = 0;
			this.pbxImage.TabStop = false;
			// 
			// clsfrmMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 511);
			this.Controls.Add(this.lblForgotPassword);
			this.Controls.Add(this.lblSignUp);
			this.Controls.Add(this.lblSignIn);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnForgotPassword);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.pbxImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "clsfrmMainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu";
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

	   }

	   #endregion

	   private System.Windows.Forms.PictureBox pbxImage;
	   private System.Windows.Forms.Button btnSignIn;
	   private System.Windows.Forms.Button btnSignUp;
	   private System.Windows.Forms.Button btnForgotPassword;
	   private System.Windows.Forms.Button btnCancel;
	   private System.Windows.Forms.Label lblSignIn;
	   private System.Windows.Forms.Label lblSignUp;
	   private System.Windows.Forms.Label lblForgotPassword;
    }
}