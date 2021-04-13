using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventForm
{
	public partial class Form2 : Form
	{
		class CustomForm1 : Form
		{
			public CustomForm1()
			{
				Text = "제목 글자";
			}
		}
		public Form2()
		{
			InitializeComponent();
			IsMdiContainer = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CustomForm1 cstform = new CustomForm1();
			cstform.MdiParent = this;
			cstform.Show();
		}
	}
}