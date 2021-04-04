using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Formats
{
	public partial class Form1 : Form
	{
		int counter = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			counter+=1;
			this.label2.Text = counter.ToString();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Don't click me!";
		}
	}
}
