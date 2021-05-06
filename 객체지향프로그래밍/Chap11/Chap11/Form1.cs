using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap11
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();

			var dataSource = new List<Product>
			{ 
				new Product() {Name = "고구미", Price = 500},
				new Product() {Name = "감자", Price = 600},
				new Product() {Name = "사과", Price = 700},
			};

			comboBox1.DisplayMember = "Name";
			comboBox1.ValueMember = "Price";
			comboBox1.DataSource = dataSource;
			comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

			listBox1.DisplayMember = "Name";
			listBox1.ValueMember = "Price";
			listBox1.DataSource = dataSource;
			listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

			dataGridView1.DataSource = dataSource;

			comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
			listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

			Button button = new Button();
			button.Text = "버튼";
			button.Click += delegate (object sender, EventArgs args)
			{
				MessageBox.Show("무명 델리게이트를 사용한 이벤트 연결입니다.");
			};
			button.Click += (sender, args) =>
			{
				MessageBox.Show("람다를 사용한 이벤트 연결입니다.");
			};
			Controls.Add(button);
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			label1.Text = listBox1.SelectedIndex
				+ " : " + ((Product)listBox1.SelectedItem).Price
				+ " : " + ((Product)listBox1.SelectedItem).Name;
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			label1.Text = comboBox1.SelectedIndex
				+ " : " + comboBox1.SelectedValue
				+ " : " + comboBox1.SelectedText;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";
			saveFileDialog1.ShowDialog();
			File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";
			openFileDialog1.ShowDialog();
			label2.Text = File.ReadAllText(openFileDialog1.FileName);
		}

		private void buttonFont_Click(object sender, EventArgs e)
		{
			if(fontDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox2.Font = fontDialog1.Font;
			}
		}

		private void buttonColor_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox2.ForeColor = colorDialog1.Color;
			}
		}

		private void buttonBackColor_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox2.BackColor = colorDialog1.Color;
			}
		}
	}

}
