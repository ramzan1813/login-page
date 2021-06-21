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

namespace Class_task
{
	public partial class Form1 : Form
	{
		//private TextBox textBox1;

		public Form1()
		{
			InitializeComponent();
		}

		private void Show_Click(object sender, EventArgs e)
		{
			string[] total = new string[6];

			for (int i = 1; i < 7; i++)
			{
				string valus ="";
				
				for (int l = i; l < 7; l++)
				{
					//Converting Numaric Valus to string
					valus += Convert.ToString(l);
				}
				//one whole string line give to only one single index 
				total[i-1] = valus;
			}

			for (int p = 0; p < total.Length; p++)
				//sending array value to text Box one idex on each line
				this.textBox1.Text += total[p] + Environment.NewLine;
		}





		private void ShowUp_Click(object sender, EventArgs e)
		{
			string[] total = new string[6];

			for (int i = 1; i < 7; i++)
			{
				string valus = "";

				for (int l = i; l > 0; l--)
				{
					//Converting Numaric Valus to string
					valus += Convert.ToString(l);
				}
				//one whole string line give to only one single index 
				total[i - 1] = valus;
			}
			
			for (int p = 0; p < total.Length; p++)
				//sending array value to text Box one idex on each line
				this.textBox2.Text += total[p] + Environment.NewLine;
		}
	}
}
