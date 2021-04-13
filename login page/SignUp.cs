using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace login_page
{
	public partial class SignUp : Form
	{
		Form1 form1 = new Form1();
		public SignUp()
		{
			InitializeComponent();

		}

		private void OK_Click(object sender, EventArgs e)
		{


			// Local database connection 
			SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ramza\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

			//for inserting new user input data into database Login table 

			sqlConnection.Open();
			string Query = "INSERT INTO Login VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + email.Text + "','" + phoneno.Text + "')";

			SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

			sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			//for closig current open window 
			this.Close();
			//for opening Main login page again
			form1.Show();

		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			//for closing current sign up page 
			this.Hide();
			//for opening Main login page again
			form1.Show();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Please use Mixture of Words and Latters");
		}


		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
