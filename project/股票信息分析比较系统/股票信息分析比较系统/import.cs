using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 股票信息分析比较系统
{
	public partial class import : Form
	{
		public delegate String getPath(String path);
		getPath pathPassed;
		public delegate void refreshListBox(bool topmost);
		
		public event refreshListBox refresh;
		public import()
		{
			InitializeComponent();
		}
		public import(getPath path)
		{
			InitializeComponent();
			this.pathPassed = path;
		}
		private void cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void confirm_Click(object sender, EventArgs e)
		{
			if (content.Text == null)
			{
				MessageBox.Show("目录不能为空！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				
				//pathPassed(content.Text);
				mainForm.str = content.Text;
				refresh(true);
				this.Close();
			}
		}
		
		

		private void browser_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			folder.ShowDialog();
			content.Text = folder.SelectedPath;
		}
	}
}
