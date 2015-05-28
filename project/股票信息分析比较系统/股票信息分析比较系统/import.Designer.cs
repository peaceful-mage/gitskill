namespace 股票信息分析比较系统
{
	partial class import
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
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
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(import));
			this.reminder = new System.Windows.Forms.Label();
			this.browser = new System.Windows.Forms.Button();
			this.confirm = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.folder = new System.Windows.Forms.FolderBrowserDialog();
			this.content = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// reminder
			// 
			this.reminder.AutoSize = true;
			this.reminder.Location = new System.Drawing.Point(12, 9);
			this.reminder.Name = "reminder";
			this.reminder.Size = new System.Drawing.Size(89, 12);
			this.reminder.TabIndex = 0;
			this.reminder.Text = "请选择文件夹：";
			// 
			// browser
			// 
			this.browser.Image = ((System.Drawing.Image)(resources.GetObject("browser.Image")));
			this.browser.Location = new System.Drawing.Point(257, 6);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(21, 21);
			this.browser.TabIndex = 2;
			this.browser.UseVisualStyleBackColor = true;
			this.browser.Click += new System.EventHandler(this.browser_Click);
			// 
			// confirm
			// 
			this.confirm.Location = new System.Drawing.Point(107, 45);
			this.confirm.Name = "confirm";
			this.confirm.Size = new System.Drawing.Size(75, 23);
			this.confirm.TabIndex = 3;
			this.confirm.Text = "导入";
			this.confirm.UseVisualStyleBackColor = true;
			this.confirm.Click += new System.EventHandler(this.confirm_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(196, 45);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 4;
			this.cancel.Text = "取消";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// content
			// 
			this.content.Location = new System.Drawing.Point(107, 6);
			this.content.Name = "content";
			this.content.Size = new System.Drawing.Size(144, 21);
			this.content.TabIndex = 5;
			// 
			// import
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 80);
			this.Controls.Add(this.content);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.confirm);
			this.Controls.Add(this.browser);
			this.Controls.Add(this.reminder);
			this.Name = "import";
			this.Text = "导入";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label reminder;
		private System.Windows.Forms.Button browser;
		private System.Windows.Forms.Button confirm;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.FolderBrowserDialog folder;
		private System.Windows.Forms.TextBox content;
	}
}