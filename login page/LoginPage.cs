using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_page
{
	public partial class LoginPage : Form
	{

		public LoginPage()
		{
			InitializeComponent();
		}


		// Sign Up Section

		#region
		private void SignUp(object sender, EventArgs e)
		{

			//Close Current form
			
			this.Hide();

			// Show SignUp Window 
			SignUp signUp = new SignUp();
			signUp.Show();

		}
		#endregion


		// Sign In Section

		#region
		private void SingIn(object sender, EventArgs e)
		{
			//Creating connection With database
			SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ramza\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

			// Checking Email and Password Validation 
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From Login Where email ='" + textBox1.Text + "' and Password = '" + textBox2.Text + "' ", connection);

			DataTable dataTable = new DataTable();

			sqlDataAdapter.Fill(dataTable);

			if (dataTable.Rows.Count == 1)
			{
				//Close Current Window
				this.Hide();

				// Show Main Window
				Main main = new Main(textBox1.Text);
				main.Show();
			}
			else

			{
				MessageBox.Show("Please Check Your Username or Password ");
			}

		}
		#endregion


		// Exit Section

		#region
		private void Exit(object sender, EventArgs e)
		{

			// Terminate the Application
			Application.Exit();
		}
		#endregion
	}
}
