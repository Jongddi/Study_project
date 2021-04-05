using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			myButton.Text = "코드에서 변경!";
			int width = 100;
			int height = 23;
			int margin = 6;
			myButton.Width = 100;

			for (int i=1; i<5; i++)
			{
				Button button = new Button();
				Controls.Add(button);
				button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
				button.Text = "동적 생성" + i + "번째";
				button.Width = width;
				button.Height = height;
			}

		}

	}
}
