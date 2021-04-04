
namespace ModTestForReal
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(739, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(33, 122);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(700, 393);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "essay or whatever here. .  .";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1107, 49);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(146, 33);
			this.button2.TabIndex = 2;
			this.button2.Text = "Load";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(1074, 88);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(204, 52);
			this.richTextBox2.TabIndex = 3;
			this.richTextBox2.Text = "";
			this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(229, 54);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(286, 22);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Name + .xml";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1328, 554);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Kai's Essay Thingy";
			this.ResumeLayout(false);
			this.PerformLayout();
			this.Icon = System.Drawing.SystemIcons.Information;
		}

		#endregion

		private System.Windows.Forms.Button button1;


		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.TextBox textBox1;
	}

}

