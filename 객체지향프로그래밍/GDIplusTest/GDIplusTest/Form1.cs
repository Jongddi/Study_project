using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPaint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//그래픽 선언
			Graphics g = e.Graphics;

			//펜 선언
			Pen p = new Pen(Color.Red, 5);

			//라인 그리기
			Point start = new Point(50, 50);
			Point end = new Point(250, 250);
			g.DrawLine(p, start, end);

			p.Color = Color.Green;
			p.Width = 5;

			start = new Point(250, 50);
			end = new Point(50, 250);
			g.DrawLine(p, start, end);

			//사각형 그리기
			p.Color = Color.Blue;
			p.Width = 10;

			Rectangle rc1 = new Rectangle(270, 10, 200, 200);
			g.DrawRectangle(p, rc1);

			//채워진 사각형 그리기
			Brush b = new SolidBrush(Color.Red);
			Rectangle rc2 = new Rectangle(500, 10, 200, 200);
			g.FillRectangle(b, rc2);

			//타원 그리기
			p = new Pen(Color.Blue, 10);
			rc1 = new Rectangle(10, 300, 200, 200);
			g.DrawEllipse(p, rc1);

			//채워진 타원그리기
			b = new SolidBrush(Color.Red);
			rc2 = new Rectangle(300, 300, 200, 200);
			g.FillEllipse(b, rc2);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
