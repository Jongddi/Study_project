using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Image newImage = Image.FromFile("../../../Image/아이유.jpg");

			Point pt = new Point(0, 0);
			e.Graphics.DrawImage(newImage, pt);
		}
	}
}
