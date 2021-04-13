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
    public partial class Form1 : Form
    {
        private int elapsedTime = 0;

        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            FormClosed += Form1_FormClosed; ;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            self.Text = "저를 클릭했습니다!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            label1.Text += "+";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            label2.Text = elapsedTime + "초 경과";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("내용");
            //MessageBox.Show("내용","제목");

            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
	}
}