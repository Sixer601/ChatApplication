namespace ChatApplication {
	partial class clsfrmMainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsfrmMainForm));
			this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
			this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbxMessages = new System.Windows.Forms.ListBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.changeAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMenuStrip
			// 
			this.mnuMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mnuMenuStrip.Name = "mnuMenuStrip";
			this.mnuMenuStrip.Size = new System.Drawing.Size(910, 28);
			this.mnuMenuStrip.TabIndex = 0;
			this.mnuMenuStrip.Text = "mnuMenuStrip";
			// 
			// accountToolStripMenuItem
			// 
			this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAccountInfoToolStripMenuItem,
            this.signOutToolStripMenuItem});
			this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
			this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.accountToolStripMenuItem.Text = "&Account";
			// 
			// lbxMessages
			// 
			this.lbxMessages.FormattingEnabled = true;
			this.lbxMessages.ItemHeight = 16;
			this.lbxMessages.Location = new System.Drawing.Point(12, 35);
			this.lbxMessages.Name = "lbxMessages";
			this.lbxMessages.Size = new System.Drawing.Size(885, 372);
			this.lbxMessages.TabIndex = 1;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(13, 423);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(804, 22);
			this.txtMessage.TabIndex = 2;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(823, 422);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 3;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			// 
			// changeAccountInfoToolStripMenuItem
			// 
			this.changeAccountInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.changeEmailToolStripMenuItem});
			this.changeAccountInfoToolStripMenuItem.Name = "changeAccountInfoToolStripMenuItem";
			this.changeAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
			this.changeAccountInfoToolStripMenuItem.Text = "Change Account &Info";
			// 
			// changeUsernameToolStripMenuItem
			// 
			this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
			this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.changeUsernameToolStripMenuItem.Text = "Change &Username";
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.changePasswordToolStripMenuItem.Text = "Change &Password";
			// 
			// changeEmailToolStripMenuItem
			// 
			this.changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
			this.changeEmailToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.changeEmailToolStripMenuItem.Text = "Change &E-mail";
			// 
			// signOutToolStripMenuItem
			// 
			this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
			this.signOutToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
			this.signOutToolStripMenuItem.Text = "Sign &Out";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.helpToolStripMenuItem1.Text = "&Help";
			// 
			// clsfrmMainForm
			// 
			this.AcceptButton = this.btnSend;
			this.ClientSize = new System.Drawing.Size(910, 457);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.lbxMessages);
			this.Controls.Add(this.mnuMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnuMenuStrip;
			this.Name = "clsfrmMainForm";
			this.Text = "Chat Application";
			this.mnuMenuStrip.ResumeLayout(false);
			this.mnuMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeAccountInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeEmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ListBox lbxMessages;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
	}
}

