using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_page
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
	
		private void SignUp(object sender, EventArgs e)
		{
			this.Hide();
			SignUp signUp = new SignUp();
			signUp.Show();

		}

		private void SingIn(object sender, EventArgs e)
		{
			SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ramza\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From Login Where email ='" + textBox1.Text + "' and Password = '" + textBox2.Text + "' ", connection);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 1)
			{
				this.Hide();
				Main main = new Main();
				main.Show();
			}
			else

			{
				MessageBox.Show("Please Check Your Username or Password ");
			}
		}

		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
