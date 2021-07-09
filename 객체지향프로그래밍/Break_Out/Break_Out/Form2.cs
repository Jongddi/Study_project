using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_Out
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			this.Text = "5533401_안종현";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			f3.Show();
		}
	}
}
