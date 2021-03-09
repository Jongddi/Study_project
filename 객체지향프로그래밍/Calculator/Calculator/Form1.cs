using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)						//덧셈
		{
			string num1 = textBox1.Text;
			string num2 = textBox2.Text;

			double result = 0.0;								//변수는 초기화 해주는 것이 좋다. double형 이므로 똑같은 형식으로 초기화 해주는게 좋다.
			result = Double.Parse(num1) + Double.Parse(num2);	//Double로 하는 이유 : float보다 더 큰 범위를 가지고 있어 오차를 줄일 수 있음

			label3.Text = result.ToString();
		}

		private void button2_Click(object sender, EventArgs e)						//뺄셈
		{
			string num1 = textBox1.Text;
			string num2 = textBox2.Text;

			double result = 0.0;
			result = Math.Round(Double.Parse(num1) - Double.Parse(num2),10);  //더 긴 비트연산에서 double도 오류가 나기 때문에 반올림이 가능한 Math클래스를 불러온다.

			label3.Text = result.ToString();
		}

		private void button3_Click(object sender, EventArgs e)						//곱셈
		{
			string num1 = textBox1.Text;
			string num2 = textBox2.Text;

			double result = 0.0;
			result = Double.Parse(num1) * Double.Parse(num2);

			label3.Text = result.ToString();
		}

		private void button4_Click(object sender, EventArgs e)						//나눗셈
		{
			string num1 = textBox1.Text;
			string num2 = textBox2.Text;

			double result = 0.0;

			if(double.Parse(num2) == 0.0)							// 두번째 수를 0으로 하고 계산하니 무한대수가 나와 if else조건문을 이용하여 구현
			{
				label3.Text = "0으로 나눌 수 없습니다.";
			}
			else
			{
				result = Double.Parse(num1) / Double.Parse(num2);

				label3.Text = result.ToString();
			}
		}

		private void button5_Click(object sender, EventArgs e)						//비교
		{
			string num1 = textBox1.Text;
			string num2 = textBox2.Text;

			if(double.Parse(num1) > double.Parse(num2))							//만약 첫번째 수가 두번째보다 크다면
			{
				label3.Text = num1 + "이(가) 크다.";
			}
			else if (double.Parse(num1) < double.Parse(num2))					//만약 첫번째 수가 두번째보다 작다면
			{
				label3.Text = num2 + "이(가) 크다.";
			}
			else																//둘다 아니면(두 수가 같으면)
			{
				label3.Text = num1 +"와(과)" + num2 + "은(는) 같다.";
			}
		}

		private void button6_Click(object sender, EventArgs e)						//나머지
		{
			string num1 = textBox1.Text;
			string num2 = textBox2.Text;

			double result = 0.0;
			result = Double.Parse(num1) % Double.Parse(num2);

			label3.Text = result.ToString();
		}
	}
}
