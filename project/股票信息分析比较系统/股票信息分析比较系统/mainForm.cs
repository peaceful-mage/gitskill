using System;
using System.Threading;
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

	//class unit																						//每一天的数据结构体
	//{
	//	public double high;
	//	public double low;
	//	public double open;
	//	public double close;
	//	public double amount;
	//	public double account;
	//	public bool isExist;
	//	unit()
	//	{
	//		open = 0.0;
	//		high = 0.0;
	//		low = 0.0;
	//		close = 0.0;
	//		amount = 0.0;
	//		account = 0.0;
	//		isExist=false;
	//	}

	//}
	public partial class mainForm : Form
	{
		public static String str = "F:\\system\\Desktop\\c#股票信息分析比较系统\\testdata1";													//导入功能读取路径字符串
		String fileName;																				//文本处理传递路径参
		Image image = null;
		Image image2 = null;
		float times = 1.0F;																		//图片放大倍数
		float heightTimes = 1.0F;
		int num = 0;																					//数据条数
		private delegate void myDelegate(String fileName);					//多线程代理
		double max = 0.0;																			//图像的最大值
		double highest = 0.0;
		double highestAmount = 0.0;
		double highestAcount = 0.0;
		String[] names = new string[300];//图像纵坐标的上界
		String selected;
		public struct unit																						//每一天的数据结构体
		{
			public double high;
			public double low;
			public double open;
			public double close;
			public double amount;
			public double account;
			public int isExist;
		};
		public mainForm()
		{
			InitializeComponent();

		}
		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			import import = new import();
			import.refresh += new import.refreshListBox(listBox_load);
			import.ShowDialog();
		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("开发者：肖皓星&郭崎", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		//刷新listbox控件
		public void listBox_load(bool topmost)
		{
			times = 1.0F;
			listBox.Items.Clear();
			int i = 0;
			DirectoryInfo path = new DirectoryInfo(str);
			if (path != null)
			{
				listBox.Text = null;
                int j = 0;
				foreach (FileInfo NextFile in path.GetFiles())
				{
                    if (NextFile.Name.Substring(NextFile.Name.LastIndexOf(".") + 1) == "txt")
                    {
                        string openFileName = str + "\\" + NextFile.Name;
                        StreamReader stream = new StreamReader(openFileName, Encoding.Default);
                        string temp = stream.ReadLine();
                        string[] firstline = new string[3];
                        firstline = temp.Split(' ');
                        string a = firstline[1];
                        listBox.Items.Add(a);
                        stream.Close();
                        names[j] = "SZ" + firstline[0] + ".txt";
                        j++;
                    }
				}

			
			}
			else
			{
				MessageBox.Show("出错了！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//选择listbox中不同股票
		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			times = 1.0F;
            int name;
            if (listBox.SelectedIndex < 59)
                name = listBox.SelectedIndex + 300000 + 1;
            else
                name = listBox.SelectedIndex + 300000 + 2;
			selected = listBox.SelectedItem.ToString();
            String index = "SZ" + name + ".txt";
			String fileName = str + "\\" + index;
			this.fileName = fileName;
			//dataHandle(fileName);
			StreamReader stream = new StreamReader(fileName, Encoding.Default);
			String first = stream.ReadLine();//读取第一行：股票名称
			String[] fst = first.Split(new char[] { '\t', ' ' });
			if (fst.Length != 3)
			{ MessageBox.Show("无法打开此文件！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
			label1.Text = "您选择的是：" + fst[1];
			selected = listBox.SelectedItem.ToString();
		}
		public void ParameterRun(String fileName)
		{
			unit[, ,] date = new unit[5, 13, 32];
			int i = 0;
			StreamReader stream = new StreamReader(Convert.ToString(fileName), Encoding.Default);
			String first = stream.ReadLine();//读取第一行：股票名称
			String second = stream.ReadLine();//读取第二行：表头
			do
			{
				String temp = stream.ReadLine();
				if (temp == "数据来源:通达信")
					goto end;
				String[] array = temp.Split(new char[] { '\t', ' ', '/' });
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].open = Double.Parse(array[3]);
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].high = Double.Parse(array[4]);
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].low = Double.Parse(array[5]);
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].close = Double.Parse(array[6]);
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].amount = Double.Parse(array[7]);
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].account = Double.Parse(array[8]);
				date[Convert.ToInt32(array[2]) - 2010, Convert.ToInt32(array[0]), Convert.ToInt32(array[1])].isExist = 1;
				num++;
				if (max < Double.Parse(array[4]))
					max = Double.Parse(array[4]);
				if (highestAcount < Double.Parse(array[7]))
					highestAcount = Double.Parse(array[7]);
				if (highestAmount < Double.Parse(array[8]))
					highestAmount = Double.Parse(array[8]);
				i++;
			} while (stream.EndOfStream == false);
		end: ;
			stream.Close();
			highest = max;
			draw(date);

		}
		public Image draw(unit[, ,] date)
		{
			pictureBox1.Height = this.Size.Height - menuStrip1.Height-panel2.Height;
			pictureBox2.Height = panel2.Height;
			bool start = false;
			int width = this.Size.Width - listBox.Width;
			int height = this.Size.Height - menuStrip1.Height;
			highestAmount /= 5;
			PointF p0 = new PointF(listBox.Width, menuStrip1.Height);
			PointF px = new PointF(this.Size.Width, menuStrip1.Height);
			PointF py = new PointF(listBox.Width, this.Size.Height);
			PointF scan = new PointF(0, 0);
			scan = p0;

			Bitmap graph = new Bitmap(num * 10, height);
			Graphics g = Graphics.FromImage(graph);
			Bitmap graph2 = new Bitmap(num * 10, 300);
			Graphics g2 = Graphics.FromImage(graph2);
			Pen Green = new Pen(Color.Green, 1);
			Pen Red = new Pen(Color.Red, 1);
			Pen LineY = new Pen(Color.Black, 5);
			Pen LineM = new Pen(Color.Gray, 1);
			Brush GreenBrush = Brushes.Green;
			Brush RedBrush = Brushes.Red;
			g2.FillRectangle(Brushes.DarkGray, p0.X, p0.Y, num * 10, 300);
			g.FillRectangle(Brushes.DarkGray, p0.X - 10, p0.Y - 10, num * 10, height + 100);
			for (int year = 0; year <= 4; year++)
			{	//画年份信息
				StringFormat drawFormat = new StringFormat();
				Font drawFont = new Font("Arial", 16);
				SolidBrush drawBrush = new SolidBrush(Color.Yellow);
				PointF pYear = new PointF((float)scan.X, (float)(this.Size.Height - 10));
				g.DrawString(Convert.ToString((year + 2010) + "年"), drawFont, drawBrush, (float)scan.X - 10, (float)(height - 20));
				g.DrawLine(LineY, scan.X, scan.Y, scan.X, this.Size.Height - 10);
				g2.DrawString(Convert.ToString((year + 2010) + "年"), drawFont, drawBrush, (float)scan.X - 10, (float)(height - 20));
				g2.DrawLine(LineY, scan.X, scan.Y, scan.X, this.Size.Height - 10);
				for (int month = 1; month <= 12; month++)
				{	//画竖直月份分割线
					//StringFormat drawFormat = new StringFormat();

					if (start)
					{
						g.DrawLine(LineM, scan.X, scan.Y, scan.X, this.Size.Height - 10);
						g2.DrawLine(LineM, scan.X, scan.Y, scan.X, this.Size.Height - 10);
						Font monthFont = new Font("Arial", 16);
						SolidBrush monthBrush = new SolidBrush(Color.Yellow);
						g.DrawString(Convert.ToString(month + "月"), monthFont, monthBrush, (float)scan.X - 10, (float)(height - 40));
						g2.DrawString(Convert.ToString(month + "月"), monthFont, monthBrush, (float)scan.X - 10, (float)(height - 40));
					}
					for (int day = 1; day <= 31; day++)
					{

						int difference = Convert.ToInt32(pictureBox1.Height * (1 - (date[year, month, day].close / highest))) - Convert.ToInt32(pictureBox1.Height * (1 - (date[year, month, day].open / highest)));//大于0为绿，小于0为红
						PointF pHigh = new PointF(scan.X + 4, Convert.ToInt32(pictureBox1.Height * (1 - (date[year, month, day].high / highest))));
						PointF pLow = new PointF(scan.X + 4, Convert.ToInt32(pictureBox1.Height * (1 - (date[year, month, day].low / highest))));

						if (date[year, month, day].isExist != 1)
							continue;
						start = true;
						if (difference > 0)
						{
							g.FillRectangle(GreenBrush, scan.X, Convert.ToInt16(pictureBox1.Height * (1 - (date[year, month, day].open / highest))), 8, difference);
							g2.FillRectangle(GreenBrush, scan.X, Convert.ToSingle(pictureBox2.Height * (1 - (date[year, month, day].amount / highestAmount)))-10, 8.0F, Convert.ToSingle(pictureBox2.Height * ((date[year, month, day].amount / highestAmount)))+10);
						}
						else
						{
							g.FillRectangle(RedBrush, scan.X, Convert.ToInt16(pictureBox1.Height * (1 - (date[year, month, day].close / highest))), 8, Math.Abs(difference));
							g2.FillRectangle(RedBrush, scan.X, Convert.ToSingle(pictureBox2.Height * (1 - (date[year, month, day].amount / highestAmount)))-10, 8.0F, Convert.ToSingle(pictureBox2.Height * ( (date[year, month, day].amount / highestAmount)))+10);
						}
							
							g.DrawLine((difference > 0) ? Green : Red, pHigh, pLow);
						
						scan.X += 10;
					}
				}
			}
			pictureBox1.Image = (Image)graph;
			pictureBox2.Image = (Image)graph2;
			image = (Image)graph;
			image2 = (Image)graph2;
			pictureBox1.Width = graph.Width;
			pictureBox1.Height = graph.Height;
			return graph;
		}
		private void mainForm_Load(object sender, EventArgs e)
		{
		}
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox.SelectedItem != null)
			{
				object fileName = this.fileName;
				//mainForm p = new mainForm();
				Thread parameterThread = new Thread(new ThreadStart(ToMulRun));
				parameterThread.Start();
			}
			else
				MessageBox.Show("请先选择一支股票！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void ToMulRun()
		{
			object[] temp = new[] { fileName };
			myDelegate md = new myDelegate(ParameterRun);
			Invoke(md, temp);
		}
		private void 清除图表ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
		}
		private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox.Items.Clear();
		}
		public String getListBoxIndexSelected()
		{
			return listBox.SelectedItem.ToString();
		}
		public String[] getListBoxIndexes()
		{
			return names;
		}
		public String getPath()
		{
			return str;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox.SelectedItem != null)
			{
				compare com = new compare(str, selected, names);
				com.ShowDialog();
			}
			else
				MessageBox.Show("请先选择一支股票！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void bigger_Click(object sender, EventArgs e)
		{
			
			if (times < 0.5F)
			{
				
				Bitmap b = new Bitmap(Convert.ToInt32(image.Width * times * 2), Convert.ToInt32(image.Height *0.5));
				Graphics g = Graphics.FromImage(b);
				g.DrawImage(image, new Rectangle(0, 0, Convert.ToInt32(image.Width * times * 2), Convert.ToInt32(image.Height *0.5)), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
				pictureBox1.Image = (Image)b;

				Bitmap b2 = new Bitmap(Convert.ToInt32((image2.Width * times) *2), Convert.ToInt32(image2.Height *0.5));
				Graphics g2 = Graphics.FromImage(b2);
				g2.DrawImage(image2, new Rectangle(0, 0, Convert.ToInt32((image2.Width * times)*2), Convert.ToInt32(image2.Height *0.5)), new Rectangle(0, 0, image2.Width, image2.Height), GraphicsUnit.Pixel);
				pictureBox2.Image = (Image)b2;


				times *= 2;


			}
			else
			{
				if (times < 2.0F)
				{
					
					Bitmap b = new Bitmap(Convert.ToInt32(image.Width * times*2), Convert.ToInt32(image.Height*times*2));
					Graphics g = Graphics.FromImage(b);
					g.DrawImage(image, new Rectangle(0, 0, Convert.ToInt32(image.Width * times*2), Convert.ToInt32(image.Height * heightTimes)), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
					pictureBox1.Image = (Image)b;

					Bitmap b2 = new Bitmap(Convert.ToInt32((image2.Width * times) *2), Convert.ToInt32((image2.Height * times) *2));
				Graphics g2 = Graphics.FromImage(b2);
				g2.DrawImage(image2, new Rectangle(0, 0, Convert.ToInt32((image2.Width * times) *2), Convert.ToInt32((image2.Height * times)*2)), new Rectangle(0, 0, image2.Width, image2.Height), GraphicsUnit.Pixel);
				pictureBox2.Image = (Image)b2;
					times *= 2;
				}
				else
				{
					MessageBox.Show("已经是最大了！");
				}
			}
			
		}

		private void smaller_Click(object sender, EventArgs e)
		{
			if (times > 0.5F)
			{
				
				Bitmap b = new Bitmap(Convert.ToInt32((image.Width * times)/2), Convert.ToInt32((image.Height*times)/2));
				Graphics g = Graphics.FromImage(b);
				g.DrawImage(image, new Rectangle(0, 0, Convert.ToInt32((image.Width * times)/2), Convert.ToInt32((image.Height*times)/2)), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
				pictureBox1.Image = (Image)b;

				Bitmap b2 = new Bitmap(Convert.ToInt32((image2.Width * times) / 2), Convert.ToInt32((image2.Height * times) / 2));
				Graphics g2 = Graphics.FromImage(b2);
				g2.DrawImage(image2, new Rectangle(0, 0, Convert.ToInt32((image2.Width * times) / 2), Convert.ToInt32((image2.Height * times) / 2)), new Rectangle(0, 0, image2.Width, image2.Height), GraphicsUnit.Pixel);
				pictureBox2.Image = (Image)b2;
				times /= 2;
			}
			else
			{
				if (times > 0.03125F)
				{
					Bitmap b = new Bitmap(Convert.ToInt32(image.Width * times/2), Convert.ToInt32(image.Height*0.5));
					Graphics g = Graphics.FromImage(b);
					g.DrawImage(image, new Rectangle(0, 0, Convert.ToInt32(image.Width * times/2), Convert.ToInt32(image.Height*0.5)), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
					pictureBox1.Image = (Image)b;
					Bitmap b2 = new Bitmap(Convert.ToInt32((image2.Width * times) / 2), Convert.ToInt32(image2.Height*0.5));
					Graphics g2 = Graphics.FromImage(b2);
					g2.DrawImage(image2, new Rectangle(0, 0, Convert.ToInt32((image2.Width * times) / 2), Convert.ToInt32(image2.Height *0.5)), new Rectangle(0, 0, image2.Width, image2.Height), GraphicsUnit.Pixel);
					pictureBox2.Image = (Image)b2;
					times /= 2;
				}
					else
				{
					MessageBox.Show("已经是最小了！");
				}
			}
		}
	}
}
