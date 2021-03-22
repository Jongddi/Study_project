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
		}
	}
}
