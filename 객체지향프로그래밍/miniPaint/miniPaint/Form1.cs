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
		private int shape;
		private int rtWidth;
		private int rtHeight;
		private Point ptStart;
		private Point ptEnd;
		private Pen myPen;
		private Boolean bPress;
		private Graphics g;
		private Rectangle rect;

		public Form1()
		{
			InitializeComponent();
			this.BackColor = Color.White;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			//point(시작점)
			ptStart = new Point(0, 0);

			//point(끝점)
			ptEnd = new Point(100, 100);

			//펜 색깔(두께)
			myPen = new Pen(Color.Black, 1);

			//모양
			shape = 0; //0(직선), 1(사각형), 2(원형)

			//너비, 높이
			rtWidth = 0;
			rtHeight = 0;

			//그래픽
			g = Graphics.FromHwnd(this.Handle);	//formhwnd 새로운 그래픽 창을 만들어주는 핸들러

			//현재 마우스
			bPress = false;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			//start
			bPress = true;
			ptStart.X = e.X;
			ptStart.Y = e.Y;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			//변화
			//line, r, e
			if (bPress == true)
			{
				if (shape == 0)
				{
					g.Clear(Color.White);
					ptEnd = new Point(e.X, e.Y);
					g.DrawLine(myPen, ptStart, ptEnd);
				}
				else if (shape == 1)
				{
					g.Clear(Color.White);
					rtWidth = Math.Abs(e.X - ptStart.X);
					rtHeight = Math.Abs(e.Y - ptStart.Y);
					rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
					g.DrawRectangle(myPen, rect);
				}
				else if (shape == 2)
				{
					g.Clear(Color.White);
					rtWidth = Math.Abs(e.X - ptStart.X);
					rtHeight = Math.Abs(e.Y - ptStart.Y);

					if (rtWidth == 0)
						rtWidth = 1;

					if (rtHeight == 0)
						rtHeight = 1;

					rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
					g.DrawArc(myPen, rect, 0, 365);
				}
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			//end
			//line, r, e
			if (shape == 0)
			{
				ptEnd = new Point(e.X, e.Y);
				g.DrawLine(myPen, ptStart, ptEnd);
			}
			else if (shape == 1)
			{
				rtWidth = Math.Abs(e.X - ptStart.X);
				rtHeight = Math.Abs(e.Y - ptStart.Y);
				rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
				g.DrawRectangle(myPen, rect);
			}
			else if (shape == 2)
			{
				rtWidth = Math.Abs(e.X - ptStart.X);
				rtHeight = Math.Abs(e.Y - ptStart.Y);
				rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
				g.DrawArc(myPen, rect, 0, 365);
			}
			bPress = false;
		}

		// 직선
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.shape = 0; //직선
		}
		//사각형
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			this.shape = 1; //사각형
		}
		//원형
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			this.shape = 2; //원형
		}
		//
		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			this.myPen.Color = Color.Red;
		}
		//빨강
		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			this.myPen.Color = Color.Green;
		}
		//초록
		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			this.myPen.Color = Color.Blue;
		}
		//파랑
		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			this.myPen.Color = Color.Black;
		}
		//combobox
		private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.myPen.Width = int.Parse(toolStripComboBox1.SelectedItem.ToString()) * 2;
		}

		private void toolStripMenuItem1_1_Click(object sender, EventArgs e) //새로만들기
		{
			g.Clear(Color.White);
		}

		private void toolStripMenuItem1_2_Click(object sender, EventArgs e) //끝내기
		{
			this.Close();
		}

		private void toolStripMenuItem2_1_Click(object sender, EventArgs e) //직선
		{
			this.shape = 0; //직선
		}

		private void toolStripMenuItem2_2_Click(object sender, EventArgs e) //사각형
		{
			this.shape = 1; //사각형
		}

		private void toolStripMenuItem2_3_Click(object sender, EventArgs e) //원형
		{
			this.shape = 2; //원형
		}

		private void toolStripMenuItem3_1_Click(object sender, EventArgs e) //색상
		{
			if(DialogResult.OK == this.colorDialog1.ShowDialog())
			{
				this.myPen.Color = this.colorDialog1.Color;
			}
		}
	}
}
