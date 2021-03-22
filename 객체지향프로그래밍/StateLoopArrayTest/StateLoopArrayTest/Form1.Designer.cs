
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
			this.button_Cul = new System.Windows.Forms.Button();
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
			// button_Cul
			// 
			this.button_Cul.Location = new System.Drawing.Point(125, 130);
			this.button_Cul.Name = "button_Cul";
			this.button_Cul.Size = new System.Drawing.Size(75, 23);
			this.button_Cul.TabIndex = 8;
			this.button_Cul.Text = "계산";
			this.button_Cul.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_Cul.UseVisualStyleBackColor = true;
			this.button_Cul.Click += new System.EventHandler(this.button_Cul_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 450);
			this.Controls.Add(this.button_Cul);
			this.Controls.Add(this.lable_result);
			this.Controls.Add(this.textBox_Eng);
			this.Controls.Add(this.textBox_Math);
			this.Controls.Add(this.textBox_Kor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
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
		private System.Windows.Forms.Button button_Cul;
	}
}

