using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MDIMouseCheck
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (StreamWriter sw = new StreamWriter("../../../fs.txt"))
			{
				sw.Write(textBox1.Text);
				MessageBox.Show("텍스트가 파일에 저장되었습니다.");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			try
			{
				using (StreamReader sr = new StreamReader("../../../fs.txt"))
				{
					textBox1.Text = sr.ReadToEnd();
					MessageBox.Show("텍스트를 모두 읽어왔습니다.");
				}
			}
			catch(Exception exception)
			{
				MessageBox.Show("이 형식은 읽을 수 없습니다.");
				MessageBox.Show(exception.GetType() + "이 발생했습니다." + exception.StackTrace);
				using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(fs, exception.GetType() + "이 발생했습니다," + exception.StackTrace);
					MessageBox.Show("오류메시지가 로그형식으로 저장되었습니다.");
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "All File|*.*|Text|*.txt|Binary|*.bin";
			saveFileDialog.Title = "Save an Text File";
			saveFileDialog.ShowDialog();

			if(saveFileDialog.FileName != "")
			{
				if (saveFileDialog.FileName.Contains(".txt"))
				{
					using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
					{
						sw.Write(textBox1.Text);
					}
				}
				else if (saveFileDialog.FileName.Contains(".bin"))
				{
					using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
					{
						BinaryFormatter bf = new BinaryFormatter();
						bf.Serialize(fs, textBox1.Text);
					}
				}
				else
				{
					MessageBox.Show("형식을 정해주세요.");
				}
				
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All File|*.*|Text|*.txt|Binary|*.bin";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.ShowDialog();
			if(openFileDialog.FileName != "")
			{
				try
				{
					if (openFileDialog.FileName.Contains(".txt"))
					{
						using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
						{
							textBox1.Text = sr.ReadToEnd();
							MessageBox.Show("텍스트를 모두 읽어왔습니다.");
						}
					}
					else if (openFileDialog.FileName.Contains(".bin"))
					{
						using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
						{
							textBox1.Text = "";
							string result;

							BinaryFormatter bf = new BinaryFormatter();
							result = (string)bf.Deserialize(fs);
							textBox1.Text = result;
							MessageBox.Show("바이너리를 모두 읽어왔습니다.");
						}
					}
					else
					{
						throw new Exception();
					}
				}
				catch(Exception exception)
				{
					MessageBox.Show("이 형식은 읽을 수 없습니다.");
					MessageBox.Show(exception.GetType() + "이 발생했습니다." + exception.StackTrace);
					using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
					{
						BinaryFormatter bf = new BinaryFormatter();
						bf.Serialize(fs, exception.GetType() + "이 발생했습니다," + exception.StackTrace);
						MessageBox.Show("오류메시지가 로그형식으로 저장되었습니다.");
					}
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//직렬화
			using (FileStream fs = new FileStream("../../../Binary.bin", FileMode.Create))
			{
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, textBox1.Text);
				MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			//역직렬화
			try
			{
				using (FileStream fs = new FileStream("../../../Binary.bin", FileMode.Open))
				{
					textBox1.Text = "";
					string result;

					BinaryFormatter bf = new BinaryFormatter();
					result = (string)bf.Deserialize(fs);
					textBox1.Text = result;
					MessageBox.Show("바이너리를 모두 읽어왔습니다.");
				}
			}
			catch(Exception exception)
			{
				MessageBox.Show("이 형식은 읽을 수 없습니다.");
				MessageBox.Show(exception.GetType() + "이 발생했습니다." + exception.StackTrace);
				using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(fs, exception.GetType() + "이 발생했습니다," + exception.StackTrace);
					MessageBox.Show("오류메시지가 로그형식으로 파일에 저장되었습니다.");
				}
			}
		}

		//선택저장 버튼
		private void button7_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true && checkBox2.Checked == true)								//둘다 체크하고 저장할 경우 통합 메시지 출력
			{
				if (checkBox1.Checked == true)
				{
					using (StreamWriter sw = new StreamWriter("../../../normal.txt"))
					{
						sw.Write(textBox1.Text);
					}
				}
				if (checkBox2.Checked == true)
				{
					using (FileStream fs = new FileStream("../../../se.bin", FileMode.Create))
					{
						BinaryFormatter bf = new BinaryFormatter();
						bf.Serialize(fs, textBox1.Text);
					}
				}
				MessageBox.Show("텍스트, 바이너리 형식으로 각각 파일에 저장되었습니다.");
			}
			else if (checkBox1.Checked == true)														//일반 저장
			{
				using (StreamWriter sw = new StreamWriter("../../../normal.txt"))
				{
					sw.Write(textBox1.Text);
					MessageBox.Show("텍스트가 파일에 저장되었습니다.");
				}
			}
			else if(checkBox2.Checked == true)														//직렬화 저장
			{
				using (FileStream fs = new FileStream("../../../se.bin", FileMode.Create))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(fs, textBox1.Text);
					MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
				}
			}
			else if(checkBox1.Checked == false && checkBox2.Checked == false)						//아무것도 선택 안하고 저장 누를시 발생
			{
				MessageBox.Show("아무것도 선택 안했습니다.");
			}
			checkBox1.Checked = false;		//버튼이 눌려지고 난 다음 체크 비활성화
			checkBox2.Checked = false;		
		}

		//선택읽기 버튼
		private void button8_Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked == true)
			{
				try
				{
					using (StreamReader sr = new StreamReader("../../../normal.txt"))
					{
						textBox1.Text = sr.ReadToEnd();
						MessageBox.Show("텍스트를 모두 읽어왔습니다.");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("이 형식은 읽을 수 없습니다.");
					MessageBox.Show(exception.GetType() + "이 발생했습니다." + exception.StackTrace);
					using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
					{
						BinaryFormatter bf = new BinaryFormatter();
						bf.Serialize(fs, exception.GetType() + "이 발생했습니다," + exception.StackTrace);
						MessageBox.Show("오류메시지가 로그형식으로 저장되었습니다.");
					}
				}
			}
			else if (radioButton2.Checked == true)
			{
				try
				{

					using (FileStream fs = new FileStream("../../../se.bin", FileMode.Open))
					{
						textBox1.Text = "";
						string result;

						BinaryFormatter bf = new BinaryFormatter();
						result = (string)bf.Deserialize(fs);
						textBox1.Text = result;
						MessageBox.Show("바이너리를 모두 읽어왔습니다.");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("이 형식은 읽을 수 없습니다.");
					MessageBox.Show(exception.GetType() + "이 발생했습니다." + exception.StackTrace);
					using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
					{
						BinaryFormatter bf = new BinaryFormatter();
						bf.Serialize(fs, exception.GetType() + "이 발생했습니다," + exception.StackTrace);
						MessageBox.Show("오류메시지가 로그형식으로 파일에 저장되었습니다.");
					}
				}
			}
			else if(radioButton1.Checked == false && radioButton2.Checked == false)
			{
				MessageBox.Show("아무것도 선택 안했습니다.");
			}
			radioButton1.Checked = false;
			radioButton2.Checked = false;
		}
	}
}