using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login_page
{

	public partial class Main : Form
	{
		LoginPage loginPage = new LoginPage();

		String Email = "";
		public Main(String EmailTextBox)
		{
			InitializeComponent();
			//here we receiving email of user for LoginPage Where he enter for login
			Email = EmailTextBox;

		}


		// Update Section 

		#region
		private void Updates_Click(object sender, EventArgs e)
		{


			//database connection String
			SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\LoginPage New Branch\Database\LoginDataBase.mdf;Integrated Security=True;Connect Timeout=30");
			
			//Updating Command 
			string Query = "";

			if (this.password.Text == "")
			{
				Query = "Update Login set UserName = '" + name.Text + "',PhoneNo = '" + phoneno.Text + "' Where Email = '" + Email + "'";
			}
			else
			{
				Query = "Update Login set UserName = '" + name.Text + "', Password ='" + password.Text + "',  PhoneNo = '" + phoneno.Text + "' Where Email = '" + Email + "'";
			}

			//Runing Query
			SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

			if (this.name.Text == "")
			{
				MessageBox.Show("Please enter Name ");
			}
			else if (this.phoneno.Text == "")
			{
				MessageBox.Show("Please enter Phone Number ");

			}
			else
			{
				try
				{
					//Open connection.
					sqlConnection.Open();

					// Run the stored procedure.
					sqlCommand.ExecuteNonQuery();

					// Display Message if operation seuccesful.

					MessageBox.Show("Profile of this User " + Email + " has been updated");
				}
				catch
				{
					MessageBox.Show("Operation Fail ");
				}
				finally
				{
					// Closing Connection with Database 
					sqlConnection.Close();

				}
			}
		}
		#endregion

		// Exit Section

		#region
		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
			//this.Close();
		}
		#endregion


		// Log Out Section

		#region
		private void btnBack(object sender, EventArgs e)
		{
			LoginPage form1 = new LoginPage();
			form1.Show();
			this.Hide();
		}
		#endregion


		// Delete Section

		#region
		private void btnDelete_Click(object sender, EventArgs e)
		{

			//Show Warning Message to User
			DialogResult dialogResult = MessageBox.Show("Do You Want to delete Your Account ? ", "Delete Account ", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes)
			{
				//Creating connection With database
				SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\LoginPage New Branch\Database\LoginDataBase.mdf;Integrated Security=True;Connect Timeout=30");


				//Delete Command 

				string Query = "Delete from Login  Where Email = '" + Email + "'";



				SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
				//Open connection.

				try
				{
					sqlConnection.Open();

					// Run the stored procedure.
					sqlCommand.ExecuteNonQuery();

					//MessageBox.Show(" Operation Secuess ");


					MessageBox.Show("Profile of this User " + Email + " has been deleted");

				}
				catch
				{
					MessageBox.Show("Operation Fail ");
				}
				finally
				{
					// Closing Connection with Database 
					sqlConnection.Close();
					this.Hide();
					loginPage.Show();
				}
			}



		}
		#endregion

		//Data Show

		#region

		private void BtnShowData_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\LoginPage New Branch\Database\LoginDataBase.mdf;Integrated Security=True;Connect Timeout=30");

			string Quary = "select * from login ";

			try
			{
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Quary, sqlConnection);


				//SqlCommand sqlCommand = new SqlCommand(Quary, sqlConnection);

				//sqlConnection.Open();

				//SqlDataReader sqlDataReader =new SqlDataReader();

				DataGridView dataGridView = new DataGridView();

					//MessageBox.Show("if is now run ");

					DataTable dataTable = new DataTable();

					DataSet dataSet = new DataSet();

					sqlDataAdapter.Fill(dataTable);
					sqlDataAdapter.Fill(dataSet ,"Login");

				//dataTable.Load(sqlDataReader);

				//this.dataGridView1.DataSource = dataSet.Tables[0];

				//dataGridView.DataSource = dataTable;

				dataGridView.DataSource = dataSet.Tables["Login"].DefaultView;
			}
			finally
			{
				sqlConnection.Close();
			}


		}

		#endregion
	}
}
