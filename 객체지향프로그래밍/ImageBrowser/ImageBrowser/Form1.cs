using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBrowser
{
	public partial class Form1 : Form
	{
		Bitmap myBmp;
		Bitmap tmp;
		bool gray;
		public Form1()
		{
			InitializeComponent();
			gray = false;
		}

		private void toolStripButton1_Click(object sender, EventArgs e) //이미지 열기
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				myBmp = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Width = myBmp.Width;
				pictureBox1.Height = myBmp.Height;
				pictureBox1.Image = myBmp;
				tmp = myBmp.Clone() as Bitmap;
			}

			this.Size = new Size(pictureBox1.Width + 50, pictureBox1.Height + 100);
		}

		private void toolStripButton2_Click(object sender, EventArgs e) //이미지 확대
		{
			pictureBox1.Width += 10;
			pictureBox1.Height += 10;
			pictureBox1.Image = myBmp;
		}

		private void toolStripButton3_Click(object sender, EventArgs e) //이미지 축소
		{
			pictureBox1.Width -= 10;
			pictureBox1.Height -= 10;
			pictureBox1.Image = myBmp;
		}

		private void toolStripButton4_Click(object sender, EventArgs e) //이미지 자동회전
		{
			pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox1.Refresh();
		}

		private void toolStripButton5_Click(object sender, EventArgs e) //회색조
		{
			int width = myBmp.Width;
			int height = myBmp.Height;

			if(gray == false)
			{
				Color colorData;
				for(int i = 0; i < width; i++)
				{
					for(int j = 0; j < height; j++)
					{
						colorData = myBmp.GetPixel(i, j);

						int res = (colorData.R + colorData.G + colorData.B) / 3;
						colorData = Color.FromArgb(res, res, res);
						myBmp.SetPixel(i, j, colorData);
					}
				}
				pictureBox1.Image = myBmp;
				pictureBox1.Refresh();
				gray = true;
			}
			else
			{
				myBmp = tmp.Clone() as Bitmap;
				pictureBox1.Image = myBmp;
				pictureBox1.Refresh();
				gray = false;
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e) //90도 회전
		{
			pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox1.Refresh();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e) //180도 회전
		{
			pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
			pictureBox1.Refresh();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e) //270도 회전
		{
			pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
			pictureBox1.Refresh();
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e) //원상복귀(360도)
		{
			myBmp = tmp.Clone() as Bitmap;
			pictureBox1.Image = myBmp;
			pictureBox1.Refresh();
		}
	}
}
