
namespace StateLoopArrayTest
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_Kor = new System.Windows.Forms.TextBox();
			this.textBox_Math = new System.Windows.Forms.TextBox();
			this.textBox_Eng = new System.Windows.Forms.TextBox();
			this.lable_result = new System.Windows.Forms.Label();
			this.result_cal = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label_ResultLoop = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label_result_GuGu = new System.Windows.Forms.Label();
			this.textBox_GuGu = new System.Windows.Forms.TextBox();
			this.bnCal_GuGu = new System.Windows.Forms.Button();
			this.label_resultArray = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "조건문";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "국어";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(125, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "수학";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(240, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "영어";
			// 
			// textBox_Kor
			// 
			this.textBox_Kor.Location = new System.Drawing.Point(13, 85);
			this.textBox_Kor.Name = "textBox_Kor";
			this.textBox_Kor.Size = new System.Drawing.Size(74, 23);
			this.textBox_Kor.TabIndex = 4;
			// 
			// textBox_Math
			// 
			this.textBox_Math.Location = new System.Drawing.Point(125, 85);
			this.textBox_Math.Name = "textBox_Math";
			this.textBox_Math.Size = new System.Drawing.Size(74, 23);
			this.textBox_Math.TabIndex = 5;
			// 
			// textBox_Eng
			// 
			this.textBox_Eng.Location = new System.Drawing.Point(240, 85);
			this.textBox_Eng.Name = "textBox_Eng";
			this.textBox_Eng.Size = new System.Drawing.Size(74, 23);
			this.textBox_Eng.TabIndex = 6;
			// 
			// lable_result
			// 
			this.lable_result.AutoSize = true;
			this.lable_result.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lable_result.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lable_result.Location = new System.Drawing.Point(160, 165);
			this.lable_result.Name = "lable_result";
			this.lable_result.Size = new System.Drawing.Size(0, 30);
			this.lable_result.TabIndex = 7;
			this.lable_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// result_cal
			// 
			this.result_cal.Location = new System.Drawing.Point(125, 130);
			this.result_cal.Name = "result_cal";
			this.result_cal.Size = new System.Drawing.Size(75, 23);
			this.result_cal.TabIndex = 8;
			this.result_cal.Text = "계산";
			this.result_cal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.result_cal.UseVisualStyleBackColor = true;
			this.result_cal.Click += new System.EventHandler(this.button_Cul_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(371, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "반복문";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(371, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "계산";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.bnCalLoop_Click);
			// 
			// label_ResultLoop
			// 
			this.label_ResultLoop.AutoSize = true;
			this.label_ResultLoop.Location = new System.Drawing.Point(371, 100);
			this.label_ResultLoop.Name = "label_ResultLoop";
			this.label_ResultLoop.Size = new System.Drawing.Size(147, 15);
			this.label_ResultLoop.TabIndex = 11;
			this.label_ResultLoop.Text = "위의 버튼을 클릭해주세요";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 226);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "for문 구구단";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 15);
			this.label7.TabIndex = 13;
			this.label7.Text = "단수";
			// 
			// label_result_GuGu
			// 
			this.label_result_GuGu.AutoSize = true;
			this.label_result_GuGu.Location = new System.Drawing.Point(13, 308);
			this.label_result_GuGu.Name = "label_result_GuGu";
			this.label_result_GuGu.Size = new System.Drawing.Size(203, 15);
			this.label_result_GuGu.TabIndex = 14;
			this.label_result_GuGu.Text = "단수를 입력 후 출력을 클릭해주세요";
			// 
			// textBox_GuGu
			// 
			this.textBox_GuGu.Location = new System.Drawing.Point(59, 261);
			this.textBox_GuGu.Name = "textBox_GuGu";
			this.textBox_GuGu.Size = new System.Drawing.Size(116, 23);
			this.textBox_GuGu.TabIndex = 15;
			// 
			// bnCal_GuGu
			// 
			this.bnCal_GuGu.Location = new System.Drawing.Point(212, 261);
			this.bnCal_GuGu.Name = "bnCal_GuGu";
			this.bnCal_GuGu.Size = new System.Drawing.Size(75, 23);
			this.bnCal_GuGu.TabIndex = 16;
			this.bnCal_GuGu.Text = "출력";
			this.bnCal_GuGu.UseVisualStyleBackColor = true;
			this.bnCal_GuGu.Click += new System.EventHandler(this.bnCal_GuGu_Click);
			// 
			// label_resultArray
			// 
			this.label_resultArray.AutoSize = true;
			this.label_resultArray.Location = new System.Drawing.Point(378, 201);
			this.label_resultArray.Name = "label_resultArray";
			this.label_resultArray.Size = new System.Drawing.Size(147, 15);
			this.label_resultArray.TabIndex = 17;
			this.label_resultArray.Text = "성적이 배열로 출력됩니다";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 593);
			this.Controls.Add(this.label_resultArray);
			this.Controls.Add(this.bnCal_GuGu);
			this.Controls.Add(this.textBox_GuGu);
			this.Controls.Add(this.label_result_GuGu);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label_ResultLoop);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.result_cal);
			this.Controls.Add(this.lable_result);
			this.Controls.Add(this.textBox_Eng);
			this.Controls.Add(this.textBox_Math);
			this.Controls.Add(this.textBox_Kor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "5533401_안종현";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_Kor;
		private System.Windows.Forms.TextBox textBox_Math;
		private System.Windows.Forms.TextBox textBox_Eng;
		private System.Windows.Forms.Label lable_result;
		private System.Windows.Forms.Button result_cal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label_ResultLoop;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label_result_GuGu;
		private System.Windows.Forms.TextBox textBox_GuGu;
		private System.Windows.Forms.Button bnCal_GuGu;
		private System.Windows.Forms.Label label_resultArray;
	}
}

