using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 股票信息分析比较系统;
using System.Collections;

namespace 股票信息分析比较系统
{
	class similarity
	{
		
		private int num = 0;
		public List<double> toList(compare.unit[ , , ] arr,int year1,int month1,int day1,int year2,int month2,int day2)
		{
			bool istrue = false;
			List<double> Similarity=new List<double>(300);
			num = (((year2 - year1 - 1) * 365) + (12 - month1) * 32 + (32 - day1) + (month2 - 1) * 32 + day2);
			for (int i = 0; i <= 4; i++)
			{
				for(int j=0;j<=12;j++)
				{
					for(int k=0;k<=31;k++)
					{
						if (istrue=(((i > year1) && (i < year2)) || ((i == year1) && (j > month1)) || ((i == year1) && (j == month1) && (k >= day1)) || ((i == year2) && (j < month2)) || ((i == year2) && (j == month2) && (k <= day2)))&&(arr[i,j,k].isExist==1))
						{
							Similarity.Add(arr[i, j, k].open);
						}
					}
				}
			}
			return Similarity;
		}
		public double GetCosineSimilarity(List<double> V1, List<double> V2)
		{
			//double sim = 0.0d;
			int N = 0;
			N = ((V2.Count < V1.Count) ? V2.Count : V1.Count);
			double dot = 0.0d;
			double mag1 = 0.0d;
			double mag2 = 0.0d;
			for (int n = 0; n < N; n++)
			{
				dot += V1[n] * V2[n];
				mag1 += Math.Pow(V1[n], 2);
				mag2 += Math.Pow(V2[n], 2);
			}

			return dot / (Math.Sqrt(mag1) * Math.Sqrt(mag2));
		}
		public int[] sort(double[] list)
		{
			int n = 0;
			int[] newList = new int[300];
			double temp = 0.0;
			int tempPosition = 0;
			for (int i = 0; i < list.Length; i++)
			{
				for (int j = 0; j < list.Length; j++)
				{
					if (list[j] > temp)
					{
						temp = list[j];
						tempPosition = j;
					}
				}
				newList[n] = tempPosition;
				list[tempPosition] = 0.0;
				n++;
				temp = 0.0;
			}
			return newList;
		}
	}

}
