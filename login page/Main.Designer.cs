
namespace login_page
{
	partial class Main
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
			this.label1 = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			this.Updates = new System.Windows.Forms.Button();
			this.phoneno = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.BtnShowData = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(214, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Wellcome Back Dear User";
			// 
			// Exit
			// 
			this.Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Exit.Location = new System.Drawing.Point(470, 311);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(92, 41);
			this.Exit.TabIndex = 1;
			this.Exit.Text = "E&xit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Back
			// 
			this.Back.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Back.Location = new System.Drawing.Point(228, 311);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(90, 41);
			this.Back.TabIndex = 2;
			this.Back.Text = "Logout";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.btnBack);
			// 
			// Updates
			// 
			this.Updates.Location = new System.Drawing.Point(352, 311);
			this.Updates.Name = "Updates";
			this.Updates.Size = new System.Drawing.Size(92, 41);
			this.Updates.TabIndex = 3;
			this.Updates.Text = "Update";
			this.Updates.UseVisualStyleBackColor = true;
			this.Updates.Click += new System.EventHandler(this.Updates_Click);
			// 
			// phoneno
			// 
			this.phoneno.Location = new System.Drawing.Point(228, 202);
			this.phoneno.Name = "phoneno";
			this.phoneno.PlaceholderText = "0123456789";
			this.phoneno.Size = new System.Drawing.Size(202, 23);
			this.phoneno.TabIndex = 4;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(228, 173);
			this.password.Name = "password";
			this.password.PlaceholderText = "Password";
			this.password.Size = new System.Drawing.Size(202, 23);
			this.password.TabIndex = 4;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(228, 144);
			this.name.Name = "name";
			this.name.PlaceholderText = "Name";
			this.name.Size = new System.Drawing.Size(202, 23);
			this.name.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(117, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(117, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(117, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "Phone No";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.Location = new System.Drawing.Point(592, 311);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(92, 41);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete ";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(470, 144);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 6;
			// 
			// BtnShowData
			// 
			this.BtnShowData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnShowData.Location = new System.Drawing.Point(117, 311);
			this.BtnShowData.Name = "BtnShowData";
			this.BtnShowData.Size = new System.Drawing.Size(90, 41);
			this.BtnShowData.TabIndex = 2;
			this.BtnShowData.Text = "Show Data ";
			this.BtnShowData.UseVisualStyleBackColor = true;
			this.BtnShowData.Click += new System.EventHandler(this.BtnShowData_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name);
			this.Controls.Add(this.password);
			this.Controls.Add(this.phoneno);
			this.Controls.Add(this.Updates);
			this.Controls.Add(this.BtnShowData);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Name = "Main";
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.Button Updates;
		private System.Windows.Forms.TextBox phoneno;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnShowData;
	}
}