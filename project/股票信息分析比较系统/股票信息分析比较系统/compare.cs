using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 股票信息分析比较系统;
using System.IO;
using System.Collections;

namespace 股票信息分析比较系统
{
	public partial class compare : Form
	{
		String[] index;
		String path;
		String selected;
		double[] similarity = new double[300];
		int[] newSimilarity = new int[300];
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
		public compare()
		{
			InitializeComponent();
		}
		public compare(String path,String selected,String[] index)
		{
			this.path = path;
			this.selected = selected;
			this.index = index;
			InitializeComponent();
		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			if (Convert.ToDateTime(startDatePicker.Value.Date) < Convert.ToDateTime(endDatePicker.Value.Date))
			{
				int i = 0;
				similarity sim = new similarity();


				unit[, ,] array1 = readFile(path + "\\" + selected);
				List<double> list1 = sim.toList(array1,startDatePicker.Value.Year-2010,startDatePicker.Value.Month,startDatePicker.Value.Day,endDatePicker.Value.Year-2010,endDatePicker.Value.Month,endDatePicker.Value.Day);
				do
				{

					unit[, ,] array2 = readFile(path + "\\" + index[i]);
					List<double> list2 = sim.toList(array2, startDatePicker.Value.Year-2010, startDatePicker.Value.Month, startDatePicker.Value.Day, endDatePicker.Value.Year-2010, endDatePicker.Value.Month, endDatePicker.Value.Day);
					similarity[i] = sim.GetCosineSimilarity(list1, list2);
					i++;
				} while ((i < index.Length) && (index[i] != selected));
				newSimilarity = sim.sort(similarity);
				match form = new match(newSimilarity, path, index);
				form.Show();
			}
			else
				MessageBox.Show("请选择正确的时间段！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void compareAll_Click(object sender, EventArgs e)
		{
			int i = 0;
			similarity sim = new similarity();
			

			unit[, ,] array1 = readFile(path + "\\" + selected);
			List<double> list1 = sim.toList(array1, 0, 0, 0, 5, 13, 32);
			do
			{

				unit[, ,] array2 = readFile(path + "\\" + index[i]);
				List<double> list2 = sim.toList(array2, 0, 0, 0, 5, 13, 32);
				similarity[i]=sim.GetCosineSimilarity(list1, list2);
				i++;
			} while ((i<index.Length)&&(index[i]!=selected));
			newSimilarity = sim.sort(similarity);
			match form = new match(newSimilarity,path,index);
			form.Show();
		}
		public unit[, ,] readFile(String fileName)
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
				i++;
			} while (stream.EndOfStream == false);
		end: ;
			stream.Close();
			return date;
		}
	}
}
