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
	public partial class match : Form
	{
		public String title = null;
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
		public Image draw(String path)
		{
			int num = 0;
			unit[, ,] date = new unit[5, 13, 32];
			StreamReader stream = new StreamReader(path, Encoding.Default);
			String first = stream.ReadLine();//读取第一行：股票名称
			String[] fst = first.Split(new char[] { '\t', ' ' });
			title = fst[1];
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
			} while (stream.EndOfStream == false);
		end: ;
			stream.Close();
			bool start = false;
			PointF p0 = new PointF(0, 0);
			PointF px = new PointF(0, 500);
			PointF py = new PointF(100, 0);
			PointF scan = new PointF(0, 0);
			int height = 100;
			scan = p0;

			Bitmap graph = new Bitmap(num * 10, height);
			Graphics g = Graphics.FromImage(graph);
			Pen Green = new Pen(Color.Green, 1);
			Pen Red = new Pen(Color.Red, 1);
			Pen LineY = new Pen(Color.Black, 5);
			Pen LineM = new Pen(Color.Gray, 1);
			Brush GreenBrush = Brushes.Green;
			Brush RedBrush = Brushes.Red;
			g.FillRectangle(Brushes.Silver, p0.X - 10, p0.Y - 10, num * 10, height + 100);
			for (int year = 0; year <= 4; year++)
			{	//画年份信息
				StringFormat drawFormat = new StringFormat();
				Font drawFont = new Font("Arial", 16);
				SolidBrush drawBrush = new SolidBrush(Color.Yellow);
				PointF pYear = new PointF((float)scan.X, (float)(this.Size.Height - 10));
				
				g.DrawLine(LineY, scan.X, scan.Y, scan.X, this.Size.Height - 10);
				for (int month = 1; month <= 12; month++)
				{	//画竖直月份分割线
					//StringFormat drawFormat = new StringFormat();

					if (start)
					{
						g.DrawLine(LineM, scan.X, scan.Y, scan.X, this.Size.Height - 10);
						Font monthFont = new Font("Arial", 16);
						SolidBrush monthBrush = new SolidBrush(Color.Yellow);
						
					}
					for (int day = 1; day <= 31; day++)
					{

						int difference = Convert.ToInt32(100 - date[year, month, day].close) - Convert.ToInt32(100 - date[year, month, day].open);//大于0为绿，小于0为红
						PointF pHigh = new PointF(scan.X + 4, Convert.ToInt32(100 * (1 - (date[year, month, day].high /50))));
						PointF pLow = new PointF(scan.X + 4, Convert.ToInt32(100 * (1 - (date[year, month, day].low /50))));

						if (date[year, month, day].isExist != 1)
							continue;
						start = true;
						if (difference > 0)
							g.FillRectangle(GreenBrush, scan.X, Convert.ToInt32(100 * (1 - (date[year, month, day].open /50))), 14, difference);
						else
							g.FillRectangle(RedBrush, scan.X, Convert.ToInt32(100 * (1 - (date[year, month, day].close / 50))), 14, Math.Abs(difference));
						g.DrawLine((difference > 0) ? Green : Red, pHigh, pLow);
						scan.X += 10;
					}
				}
			}
			return graph;

		}
		public match()
		{
			InitializeComponent();
		}
		public match(int[] newSimilarity,String path,String[] index)
		{
			InitializeComponent();
			Image temp = null;
			match m=new match();
			panel1.Width = m.Width / 3 - 2 * label1.Height;
			panel1.Height = m.Height / 2 - 2 * label1.Height;
			panel2.Width = m.Width / 3 - 2 * label1.Height;
			panel2.Height = m.Height / 2 - 2 * label1.Height;
			panel3.Width = m.Width / 3 - 2 * label1.Height;
			panel3.Height = m.Height / 2 - 2 * label1.Height;
			panel4.Width = m.Width / 3 - 2 * label1.Height;
			panel4.Height = m.Height / 2 - 2 * label1.Height;
			panel5.Width = m.Width / 3 - 2 * label1.Height;
			panel5.Height = m.Height / 2 - 2 * label1.Height;
			panel6.Width = m.Width / 3 - 2 * label1.Height;
			panel6.Height = m.Height / 2 - 2 * label1.Height;

			Bitmap b1 = new Bitmap(panel1.Width, panel1.Height);
			Graphics g1 = Graphics.FromImage(b1);
			pictureBox1.Width = panel1.Width;
			pictureBox1.Height = panel1.Height;
			temp =draw(path +"\\"+ index[newSimilarity[0]]);
			g1.DrawImage(temp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), new Rectangle(0, 0, temp.Width, temp.Height), GraphicsUnit.Pixel);
			pictureBox1.Image = (Image)b1;
			label1.Text = title;

			Bitmap b2 = new Bitmap(panel1.Width, panel1.Height);
			Graphics g2 = Graphics.FromImage(b2);
			pictureBox2.Width = panel2.Width;
			pictureBox2.Height = panel2.Height;
			temp = draw(path + "\\" + index[newSimilarity[1]]);
			g2.DrawImage(temp, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height), new Rectangle(0, 0, temp.Width, temp.Height), GraphicsUnit.Pixel);
			pictureBox2.Image = (Image)b2;
			label2.Text = title;

			Bitmap b3 = new Bitmap(panel1.Width, panel1.Height);
			Graphics g3 = Graphics.FromImage(b3);
			pictureBox3.Width = panel3.Width;
			pictureBox3.Height = panel3.Height;
			temp = draw(path + "\\" + index[newSimilarity[2]]);
			g3.DrawImage(temp, new Rectangle(0, 0, pictureBox3.Width, pictureBox3.Height), new Rectangle(0, 0, temp.Width, temp.Height), GraphicsUnit.Pixel);
			pictureBox3.Image = (Image)b3;
			label3.Text = title;

			Bitmap b4 = new Bitmap(panel1.Width, panel1.Height);
			Graphics g4 = Graphics.FromImage(b4);
			pictureBox4.Width = panel4.Width;
			pictureBox4.Height = panel4.Height;
			temp = draw(path + "\\" + index[newSimilarity[3]]);
			g4.DrawImage(temp, new Rectangle(0, 0, pictureBox4.Width, pictureBox4.Height), new Rectangle(0, 0, temp.Width, temp.Height), GraphicsUnit.Pixel);
			pictureBox4.Image = (Image)b4;
			label4.Text = title;

			Bitmap b5 = new Bitmap(panel1.Width, panel1.Height);
			Graphics g5 = Graphics.FromImage(b5);
			pictureBox5.Width = panel5.Width;
			pictureBox5.Height = panel5.Height;
			temp = draw(path + "\\" + index[newSimilarity[4]]);
			g5.DrawImage(temp, new Rectangle(0, 0, pictureBox5.Width, pictureBox5.Height), new Rectangle(0, 0, temp.Width, temp.Height), GraphicsUnit.Pixel);
			pictureBox5.Image = (Image)b5;
			label5.Text = title;

			Bitmap b6 = new Bitmap(panel1.Width, panel1.Height);
			Graphics g6 = Graphics.FromImage(b6);
			pictureBox6.Width = panel6.Width;
			pictureBox6.Height = panel6.Height;
			temp = draw(path + "\\" + index[newSimilarity[5]]);
			g6.DrawImage(temp, new Rectangle(0, 0, pictureBox6.Width, pictureBox6.Height), new Rectangle(0, 0, temp.Width, temp.Height), GraphicsUnit.Pixel);
			pictureBox6.Image = (Image)b6;
			label6.Text = title;

			MessageBox.Show((this.Size.Width +"   "+ this.Size.Height+"  "+label1).ToString());
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		
	}
}
