namespace 股票信息分析比较系统
{
	partial class compare
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
			this.label1 = new System.Windows.Forms.Label();
			this.startDatePicker = new System.Windows.Forms.DateTimePicker();
			this.endDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.compareAll = new System.Windows.Forms.Button();
			this.start = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "请选择搜索日期范围：";
			// 
			// startDatePicker
			// 
			this.startDatePicker.Location = new System.Drawing.Point(28, 33);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new System.Drawing.Size(134, 21);
			this.startDatePicker.TabIndex = 1;
			this.startDatePicker.Value = new System.DateTime(2010, 9, 1, 0, 0, 0, 0);
			// 
			// endDatePicker
			// 
			this.endDatePicker.Location = new System.Drawing.Point(28, 60);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.Size = new System.Drawing.Size(134, 21);
			this.endDatePicker.TabIndex = 2;
			this.endDatePicker.Value = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "开始";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(168, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "截止";
			// 
			// compareAll
			// 
			this.compareAll.Location = new System.Drawing.Point(28, 88);
			this.compareAll.Name = "compareAll";
			this.compareAll.Size = new System.Drawing.Size(67, 27);
			this.compareAll.TabIndex = 5;
			this.compareAll.Text = "全图匹配";
			this.compareAll.UseVisualStyleBackColor = true;
			this.compareAll.Click += new System.EventHandler(this.compareAll_Click);
			// 
			// start
			// 
			this.start.Location = new System.Drawing.Point(101, 88);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(61, 27);
			this.start.TabIndex = 6;
			this.start.Text = "匹配";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.button2_Click);
			// 
			// compare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 127);
			this.Controls.Add(this.start);
			this.Controls.Add(this.compareAll);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.endDatePicker);
			this.Controls.Add(this.startDatePicker);
			this.Controls.Add(this.label1);
			this.Name = "compare";
			this.Text = "compare";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker startDatePicker;
		private System.Windows.Forms.DateTimePicker endDatePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button compareAll;
		private System.Windows.Forms.Button start;
	}
}