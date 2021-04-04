using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace ModTestForReal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String text = this.richTextBox1.Text;
			XmlWriter xml = XmlWriter.Create(this.textBox1.Text);
			xml.WriteStartElement("document");
			xml.WriteElementString("doctype", "KML");
			xml.WriteElementString("contents", text);
			xml.WriteEndElement();
			xml.Flush();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				XmlReader reader = XmlReader.Create(this.richTextBox2.Text);

				while (reader.Read())
				{
					if (reader.IsStartElement())
					{
						switch (reader.Name.ToString())
						{
							case "contents":
								this.richTextBox1.Text = reader.ReadString();
								break;
						}

					}
				}
			}
			catch (Exception)
			{
				this.richTextBox1.Text = "Something Happened while trying to execute your request.";
			}
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
