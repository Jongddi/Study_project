
namespace MDIMouseCheck
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolMenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuFileNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuFileNewFile2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuFileNewFile3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 722);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuFile,
            this.toolMenuEdit});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolMenuFile
			// 
			this.toolMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFileNewFile,
            this.toolStripMenuFileNewFile2,
            this.toolStripMenuFileNewFile3});
			this.toolMenuFile.Name = "toolMenuFile";
			this.toolMenuFile.Size = new System.Drawing.Size(43, 20);
			this.toolMenuFile.Text = "파일";
			// 
			// toolStripMenuFileNewFile
			// 
			this.toolStripMenuFileNewFile.Name = "toolStripMenuFileNewFile";
			this.toolStripMenuFileNewFile.Size = new System.Drawing.Size(109, 22);
			this.toolStripMenuFileNewFile.Text = "Form2";
			this.toolStripMenuFileNewFile.Click += new System.EventHandler(this.toolStripMenuFileNewFile_Click);
			// 
			// toolStripMenuFileNewFile2
			// 
			this.toolStripMenuFileNewFile2.Name = "toolStripMenuFileNewFile2";
			this.toolStripMenuFileNewFile2.Size = new System.Drawing.Size(109, 22);
			this.toolStripMenuFileNewFile2.Text = "Form3";
			this.toolStripMenuFileNewFile2.Click += new System.EventHandler(this.toolStripMenuFileNewFile2_Click);
			// 
			// toolStripMenuFileNewFile3
			// 
			this.toolStripMenuFileNewFile3.Name = "toolStripMenuFileNewFile3";
			this.toolStripMenuFileNewFile3.Size = new System.Drawing.Size(109, 22);
			this.toolStripMenuFileNewFile3.Text = "Form4";
			this.toolStripMenuFileNewFile3.Click += new System.EventHandler(this.toolStripMenuFileNewFile3_Click);
			// 
			// toolMenuEdit
			// 
			this.toolMenuEdit.Name = "toolMenuEdit";
			this.toolMenuEdit.Size = new System.Drawing.Size(43, 20);
			this.toolMenuEdit.Text = "편집";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1060, 744);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolMenuFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileNewFile;
		private System.Windows.Forms.ToolStripMenuItem toolMenuEdit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileNewFile2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileNewFile3;
	}
}

