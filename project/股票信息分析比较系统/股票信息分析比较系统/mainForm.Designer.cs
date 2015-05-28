namespace 股票信息分析比较系统
{
	partial class mainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清除图表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelTest = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.smaller = new System.Windows.Forms.Button();
			this.bigger = new System.Windows.Forms.Button();
			this.compare = new System.Windows.Forms.Button();
			this.testLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1239, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.文件ToolStripMenuItem.Text = "文件";
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			// 
			// 编辑ToolStripMenuItem
			// 
			this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.清除图表ToolStripMenuItem,
            this.清空列表ToolStripMenuItem});
			this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
			this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.编辑ToolStripMenuItem.Text = "编辑";
			// 
			// 导入ToolStripMenuItem
			// 
			this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
			this.导入ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.导入ToolStripMenuItem.Text = "导入";
			this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
			// 
			// 清除图表ToolStripMenuItem
			// 
			this.清除图表ToolStripMenuItem.Name = "清除图表ToolStripMenuItem";
			this.清除图表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.清除图表ToolStripMenuItem.Text = "清除图表";
			this.清除图表ToolStripMenuItem.Click += new System.EventHandler(this.清除图表ToolStripMenuItem_Click);
			// 
			// 清空列表ToolStripMenuItem
			// 
			this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
			this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.清空列表ToolStripMenuItem.Text = "清空列表";
			this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.关于ToolStripMenuItem.Text = "关于";
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
			// 
			// listBox
			// 
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 12;
			this.listBox.Location = new System.Drawing.Point(0, 27);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(154, 568);
			this.listBox.TabIndex = 1;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			this.listBox.DoubleClick += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelTest);
			this.panel1.Location = new System.Drawing.Point(211, 25);
			this.panel1.MaximumSize = new System.Drawing.Size(1028, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 400);
			this.panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(12000, 10000);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1027, 400);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// labelTest
			// 
			this.labelTest.AutoSize = true;
			this.labelTest.Location = new System.Drawing.Point(14, 0);
			this.labelTest.Name = "labelTest";
			this.labelTest.Size = new System.Drawing.Size(0, 12);
			this.labelTest.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.MaximumSize = new System.Drawing.Size(12000, 12000);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1028, 229);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// smaller
			// 
			this.smaller.Location = new System.Drawing.Point(160, 64);
			this.smaller.Name = "smaller";
			this.smaller.Size = new System.Drawing.Size(45, 30);
			this.smaller.TabIndex = 4;
			this.smaller.Text = "缩小";
			this.smaller.UseVisualStyleBackColor = true;
			this.smaller.Click += new System.EventHandler(this.smaller_Click);
			// 
			// bigger
			// 
			this.bigger.Location = new System.Drawing.Point(160, 27);
			this.bigger.Name = "bigger";
			this.bigger.Size = new System.Drawing.Size(45, 31);
			this.bigger.TabIndex = 3;
			this.bigger.Text = "放大";
			this.bigger.UseVisualStyleBackColor = true;
			this.bigger.Click += new System.EventHandler(this.bigger_Click);
			// 
			// compare
			// 
			this.compare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.compare.Location = new System.Drawing.Point(79, 628);
			this.compare.Name = "compare";
			this.compare.Size = new System.Drawing.Size(75, 23);
			this.compare.TabIndex = 0;
			this.compare.Text = "开始匹配";
			this.compare.UseVisualStyleBackColor = true;
			this.compare.Click += new System.EventHandler(this.button1_Click);
			// 
			// testLabel
			// 
			this.testLabel.AutoSize = true;
			this.testLabel.Location = new System.Drawing.Point(12, 55);
			this.testLabel.Name = "testLabel";
			this.testLabel.Size = new System.Drawing.Size(0, 12);
			this.testLabel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 613);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 12);
			this.label1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Location = new System.Drawing.Point(12, 628);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(61, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "绘图";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Location = new System.Drawing.Point(211, 431);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1028, 229);
			this.panel2.TabIndex = 5;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 663);
			this.Controls.Add(this.smaller);
			this.Controls.Add(this.bigger);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.compare);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.testLabel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "c#股票信息分析比较系统";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button compare;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 清除图表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.Label testLabel;
		private System.Windows.Forms.Label labelTest;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button smaller;
		private System.Windows.Forms.Button bigger;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		
	}
}

