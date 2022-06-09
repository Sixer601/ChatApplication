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
		  this.pictureBox1.Location = new System.Drawing.Point(62, 12);
		  this.pictureBox1.Name = "pictureBox1";
		  this.pictureBox1.Size = new System.Drawing.Size(150, 150);
		  this.pictureBox1.TabIndex = 0;
		  this.pictureBox1.TabStop = false;
		  // 
		  // btnSignIn
		  // 
		  this.btnSignIn.Location = new System.Drawing.Point(13, 205);
		  this.btnSignIn.Name = "btnSignIn";
		  this.btnSignIn.Size = new System.Drawing.Size(99, 23);
		  this.btnSignIn.TabIndex = 1;
		  this.btnSignIn.Text = "Sign In";
		  this.btnSignIn.UseVisualStyleBackColor = true;
		  // 
		  // btnSignUp
		  // 
		  this.btnSignUp.Location = new System.Drawing.Point(13, 271);
		  this.btnSignUp.Name = "btnSignUp";
		  this.btnSignUp.Size = new System.Drawing.Size(99, 23);
		  this.btnSignUp.TabIndex = 2;
		  this.btnSignUp.Text = "Sign Up";
		  this.btnSignUp.UseVisualStyleBackColor = true;
		  // 
		  // btnForgotPassword
		  // 
		  this.btnForgotPassword.Location = new System.Drawing.Point(13, 334);
		  this.btnForgotPassword.Name = "btnForgotPassword";
		  this.btnForgotPassword.Size = new System.Drawing.Size(99, 23);
		  this.btnForgotPassword.TabIndex = 3;
		  this.btnForgotPassword.Text = "Forgot Password";
		  this.btnForgotPassword.UseVisualStyleBackColor = true;
		  // 
		  // btnCancel
		  // 
		  this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		  this.btnCancel.Location = new System.Drawing.Point(184, 380);
		  this.btnCancel.Name = "btnCancel";
		  this.btnCancel.Size = new System.Drawing.Size(75, 23);
		  this.btnCancel.TabIndex = 4;
		  this.btnCancel.Text = "Cancel";
		  this.btnCancel.UseVisualStyleBackColor = true;
		  // 
		  // label1
		  // 
		  this.label1.AutoSize = true;
		  this.label1.Location = new System.Drawing.Point(119, 210);
		  this.label1.MaximumSize = new System.Drawing.Size(150, 0);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(149, 26);
		  this.label1.TabIndex = 5;
		  this.label1.Text = "Use existing account to log in to the chatroom";
		  // 
		  // label2
		  // 
		  this.label2.AutoSize = true;
		  this.label2.Location = new System.Drawing.Point(119, 271);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(35, 13);
		  this.label2.TabIndex = 6;
		  this.label2.Text = "label2";
		  // 
		  // label3
		  // 
		  this.label3.AutoSize = true;
		  this.label3.Location = new System.Drawing.Point(119, 334);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(35, 13);
		  this.label3.TabIndex = 7;
		  this.label3.Text = "label3";
		  // 
		  // clsfrmMainMenu
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(271, 415);
		  this.Controls.Add(this.label3);
		  this.Controls.Add(this.label2);
		  this.Controls.Add(this.label1);
		  this.Controls.Add(this.btnCancel);
		  this.Controls.Add(this.btnForgotPassword);
		  this.Controls.Add(this.btnSignUp);
		  this.Controls.Add(this.btnSignIn);
		  this.Controls.Add(this.pictureBox1);
		  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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