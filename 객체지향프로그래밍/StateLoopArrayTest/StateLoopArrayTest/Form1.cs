using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateLoopArrayTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int[] array = new int[] { 0, 0, 0 };

		private void button_Cul_Click(object sender, EventArgs e)
		{
			int kor = int.Parse(textBox_Kor.Text);
			int math = int.Parse(textBox_Math.Text);
			int eng = int.Parse(textBox_Eng.Text);

			double result = (double)(kor + math + eng) / 3;
			if(result >= 90)
			{
				lable_result.Text = result.ToString()+"\n : 합격입니다.";
			}
			else
				lable_result.Text = result.ToString() + "\n : 실격입니다.";

			label_resultArray.Text = "배열 출력 : ";
			array[0] = int.Parse(textBox_Kor.Text);
			array[1] = int.Parse(textBox_Math.Text);
			array[2] = int.Parse(textBox_Eng.Text);

			for (int i = 0; i < array.Length; i++)
			{
				label_resultArray.Text += array[i].ToString() + " ";
			}
		}

		private void bnCalLoop_Click(object sender, EventArgs e)
		{
			label_ResultLoop.Text = "";

			//While문
			/*
			int i = 0;
			while(i < 5)
			{
				label_ResultLoop.Text += "Programming" + "\n";
				i++;
			}
			*/

			//do while문
			/*
			int i = 0;
			do
			{
				label_ResultLoop.Text += "Programming" + Environment.NewLine;
				i++;
			} while (i < 5);
			*/

			//for문
			for(int i = 0; i < 5; i++)
			{
				label_ResultLoop.Text += "Programming" + "\n";
			}
		}

		private void bnCal_GuGu_Click(object sender, EventArgs e)
		{
			label_result_GuGu.Text = "";

			for (int i = 1; i < 10; i++)
			{
				label_result_GuGu.Text += textBox_GuGu.Text + " * " + i.ToString() + " = "
					+ (int.Parse(textBox_GuGu.Text) * i) + Environment.NewLine;
			}
		}
	}
}
