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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnForgotPassword = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(84, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 185);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnSignIn
			// 
			this.btnSignIn.Location = new System.Drawing.Point(17, 252);
			this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.btnForgotPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 28);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 258);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.MaximumSize = new System.Drawing.Size(200, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Use existing account to log in to the chatroom.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(159, 334);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.MaximumSize = new System.Drawing.Size(200, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 32);
			this.label2.TabIndex = 6;
			this.label2.Text = "Create new account to log in to the chatroom.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(159, 411);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.MaximumSize = new System.Drawing.Size(200, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 32);
			this.label3.TabIndex = 7;
			this.label3.Text = "Send an E-mail to associated address to reset your password.";
			// 
			// clsfrmMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 511);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnForgotPassword);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "clsfrmMainMenu";
			this.Text = "Main Menu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

	   }

	   #endregion

	   private System.Windows.Forms.PictureBox pictureBox1;
	   private System.Windows.Forms.Button btnSignIn;
	   private System.Windows.Forms.Button btnSignUp;
	   private System.Windows.Forms.Button btnForgotPassword;
	   private System.Windows.Forms.Button btnCancel;
	   private System.Windows.Forms.Label label1;
	   private System.Windows.Forms.Label label2;
	   private System.Windows.Forms.Label label3;
    }
}