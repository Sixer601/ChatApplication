namespace ChatApplication
{
    partial class clsfrmMainForm
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
		  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmMainForm));
		  this.btnSend = new System.Windows.Forms.Button();
		  this.lbxMessages = new System.Windows.Forms.ListBox();
		  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		  this.txtMessage = new System.Windows.Forms.TextBox();
		  this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.changeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.menuStrip1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // btnSend
		  // 
		  this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.btnSend.Location = new System.Drawing.Point(713, 415);
		  this.btnSend.Name = "btnSend";
		  this.btnSend.Size = new System.Drawing.Size(75, 23);
		  this.btnSend.TabIndex = 0;
		  this.btnSend.Text = "Send";
		  this.btnSend.UseVisualStyleBackColor = true;
		  // 
		  // lbxMessages
		  // 
		  this.lbxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.lbxMessages.FormattingEnabled = true;
		  this.lbxMessages.Location = new System.Drawing.Point(13, 27);
		  this.lbxMessages.Name = "lbxMessages";
		  this.lbxMessages.Size = new System.Drawing.Size(775, 381);
		  this.lbxMessages.TabIndex = 1;
		  // 
		  // menuStrip1
		  // 
		  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
		  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
		  this.menuStrip1.Name = "menuStrip1";
		  this.menuStrip1.Size = new System.Drawing.Size(800, 24);
		  this.menuStrip1.TabIndex = 2;
		  this.menuStrip1.Text = "menuStrip1";
		  // 
		  // txtMessage
		  // 
		  this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.txtMessage.Location = new System.Drawing.Point(13, 418);
		  this.txtMessage.Name = "txtMessage";
		  this.txtMessage.Size = new System.Drawing.Size(694, 20);
		  this.txtMessage.TabIndex = 3;
		  // 
		  // accountToolStripMenuItem
		  // 
		  this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.changeEmailToolStripMenuItem,
            this.signOutToolStripMenuItem});
		  this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
		  this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
		  this.accountToolStripMenuItem.Text = "&Account";
		  // 
		  // changeUsernameToolStripMenuItem
		  // 
		  this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
		  this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		  this.changeUsernameToolStripMenuItem.Text = "Change &Username";
		  // 
		  // changePasswordToolStripMenuItem
		  // 
		  this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
		  this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		  this.changePasswordToolStripMenuItem.Text = "Change &Password";
		  // 
		  // changeEmailToolStripMenuItem
		  // 
		  this.changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
		  this.changeEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		  this.changeEmailToolStripMenuItem.Text = "Change &E-mail";
		  // 
		  // signOutToolStripMenuItem
		  // 
		  this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
		  this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		  this.signOutToolStripMenuItem.Text = "Sign &Out";
		  // 
		  // clsfrmMainForm
		  // 
		  this.AcceptButton = this.btnSend;
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(800, 450);
		  this.Controls.Add(this.txtMessage);
		  this.Controls.Add(this.lbxMessages);
		  this.Controls.Add(this.btnSend);
		  this.Controls.Add(this.menuStrip1);
		  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		  this.MainMenuStrip = this.menuStrip1;
		  this.Name = "clsfrmMainForm";
		  this.Text = "Chat Application";
		  this.menuStrip1.ResumeLayout(false);
		  this.menuStrip1.PerformLayout();
		  this.ResumeLayout(false);
		  this.PerformLayout();

	   }

	   #endregion

	   private System.Windows.Forms.Button btnSend;
	   private System.Windows.Forms.ListBox lbxMessages;
	   private System.Windows.Forms.MenuStrip menuStrip1;
	   private System.Windows.Forms.TextBox txtMessage;
	   private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem changeEmailToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}

