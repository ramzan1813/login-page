using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace login_page
{
	public partial class SignUp : Form
	{
		LoginPage form1 = new LoginPage();
		public SignUp()
		{
			InitializeComponent();

		}


		// OK Button Section

		#region

		private void OK_Click(object sender, EventArgs e)
		{

			if(this.Name.Text=="" )
			{
				MessageBox.Show("Please Enter Full Name ");

			}
			else if (this.email.Text=="")
			{
				MessageBox.Show("Please Enter Email");
			}
			else if(this.password.Text=="")
			{
				MessageBox.Show("Please Enter Password ");
			}
			else if(this.phone.Text=="")
			{
				MessageBox.Show("Please Enter Phone Number ");
			}
			else
			{
				// Local database connection String

				SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\LoginPage New Branch\Database\LoginDataBase.mdf;Integrated Security=True;Connect Timeout=30");

				try
				{
					
					//for inserting new user input data into database Login table 

					string Query = "INSERT INTO Login VALUES ('" + fullname.Text + "','" + password.Text + "','" + email.Text + "','" + phone.Text + "')";

					//open connection

					sqlConnection.Open();

					SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

					// Executing Sql Commond

					sqlCommand.ExecuteNonQuery();

				}
				catch
				{
					MessageBox.Show("User Cannot SignUp This Time Please Try \n again Later ");
				}
				finally
				{
					// Closing Connection with Database 

					sqlConnection.Close();

					//for closig current open window 

					this.Close();

					//for opening Main login page again

					form1.Show();

				}

			}

		}
		#endregion


		// Cancel Section 

		#region

		private void Cancel_Click(object sender, EventArgs e)
		{
			//for closing current sign up page 
			this.Hide();
			//for opening Main login page again
			form1.Show();
		}
		#endregion


		// Label Section 

		#region
		private void label5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Please use Mixture of Words and Latters");
		}

		#endregion

		// Exit Section
		#region
		private void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion
	}
}
