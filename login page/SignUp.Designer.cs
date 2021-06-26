
namespace login_page
{
	partial class SignUp
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.fullname = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.exit = new System.Windows.Forms.Button();
			this.email = new System.Windows.Forms.TextBox();
			this.phone = new System.Windows.Forms.TextBox();
			this.Name = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(290, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(29, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "E-mail";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(290, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Phone No";
			// 
			// fullname
			// 
			this.fullname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.fullname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.fullname.Location = new System.Drawing.Point(102, 56);
			this.fullname.Name = "fullname";
			this.fullname.PlaceholderText = "Name";
			this.fullname.Size = new System.Drawing.Size(170, 23);
			this.fullname.TabIndex = 3;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(386, 53);
			this.password.Name = "password";
			this.password.PlaceholderText = "Password";
			this.password.Size = new System.Drawing.Size(159, 23);
			this.password.TabIndex = 3;
			this.password.UseSystemPasswordChar = true;
			// 
			// OK
			// 
			this.OK.AutoSize = true;
			this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OK.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.OK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.OK.Location = new System.Drawing.Point(170, 222);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 37);
			this.OK.TabIndex = 4;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// Cancel
			// 
			this.Cancel.AutoSize = true;
			this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Cancel.Location = new System.Drawing.Point(260, 222);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 37);
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(386, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 14);
			this.label5.TabIndex = 6;
			this.label5.Text = "Please use stronge password";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// exit
			// 
			this.exit.AutoSize = true;
			this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.exit.Location = new System.Drawing.Point(350, 222);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(75, 37);
			this.exit.TabIndex = 7;
			this.exit.Text = "E&XIT";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.Exit);
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(102, 119);
			this.email.Name = "email";
			this.email.PlaceholderText = "E-mail";
			this.email.Size = new System.Drawing.Size(169, 23);
			this.email.TabIndex = 8;
			// 
			// phone
			// 
			this.phone.Location = new System.Drawing.Point(386, 119);
			this.phone.Name = "phone";
			this.phone.PlaceholderText = "0123456789";
			this.phone.Size = new System.Drawing.Size(159, 23);
			this.phone.TabIndex = 8;
			// 
			// Name
			// 
			this.Name.AutoSize = true;
			this.Name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name.Location = new System.Drawing.Point(37, 53);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(59, 23);
			this.Name.TabIndex = 9;
			this.Name.Text = "Name";
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(557, 333);
			this.Controls.Add(this.Name);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.email);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.password);
			this.Controls.Add(this.fullname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			//this.Name = "SignUp";
			this.Text = "SignUp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox fullname;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox phone;
		private new System.Windows.Forms.Label Name;
		private System.Windows.Forms.Button exit;
	}
}