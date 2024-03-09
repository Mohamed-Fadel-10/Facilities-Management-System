namespace license
{
	partial class Update_User_Data_Password
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_User_Data_Password));
			label3 = new Label();
			RoleBox = new ComboBox();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			PhoneBox = new TextBox();
			pictureBox5 = new PictureBox();
			pictureBox4 = new PictureBox();
			deletebtn = new Button();
			Savebtn = new Button();
			UsernameBox = new TextBox();
			label10 = new Label();
			PasswordBox = new TextBox();
			label7 = new Label();
			label5 = new Label();
			label4 = new Label();
			label2 = new Label();
			Closeimg = new PictureBox();
			NameBox = new TextBox();
			panel1 = new Panel();
			Searchbtn = new Button();
			pictureBox6 = new PictureBox();
			label6 = new Label();
			SearchBox = new TextBox();
			usernameloginlbl = new Label();
			ShiftBox = new ComboBox();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(415, 133);
			label3.Name = "label3";
			label3.Size = new Size(138, 30);
			label3.TabIndex = 75;
			label3.Text = "رقم التليفون";
			// 
			// RoleBox
			// 
			RoleBox.DropDownStyle = ComboBoxStyle.DropDownList;
			RoleBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			RoleBox.FormattingEnabled = true;
			RoleBox.Items.AddRange(new object[] { "Admin", "User" });
			RoleBox.Location = new Point(48, 354);
			RoleBox.Name = "RoleBox";
			RoleBox.Size = new Size(330, 39);
			RoleBox.TabIndex = 74;
			RoleBox.KeyDown += RoleBox_KeyDown;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(292, 6);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(86, 41);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(398, 8);
			label1.Name = "label1";
			label1.Size = new Size(340, 35);
			label1.TabIndex = 0;
			label1.Text = "تغير كلمة المرور وتعديل البيانات";
			// 
			// PhoneBox
			// 
			PhoneBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			PhoneBox.Location = new Point(49, 133);
			PhoneBox.Multiline = true;
			PhoneBox.Name = "PhoneBox";
			PhoneBox.Size = new Size(329, 38);
			PhoneBox.TabIndex = 76;
			PhoneBox.KeyDown += PhoneBox_KeyDown;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(238, 545);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(86, 60);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 73;
			pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(652, 545);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(86, 60);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 72;
			pictureBox4.TabStop = false;
			// 
			// deletebtn
			// 
			deletebtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			deletebtn.Location = new Point(330, 545);
			deletebtn.Name = "deletebtn";
			deletebtn.Size = new Size(163, 60);
			deletebtn.TabIndex = 70;
			deletebtn.Text = "حذف";
			deletebtn.UseVisualStyleBackColor = true;
			deletebtn.Click += deletebtn_Click;
			// 
			// Savebtn
			// 
			Savebtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Savebtn.Location = new Point(744, 545);
			Savebtn.Name = "Savebtn";
			Savebtn.Size = new Size(163, 60);
			Savebtn.TabIndex = 69;
			Savebtn.Text = "حفظ";
			Savebtn.UseVisualStyleBackColor = true;
			Savebtn.Click += Savebtn_Click;
			// 
			// UsernameBox
			// 
			UsernameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			UsernameBox.Location = new Point(608, 236);
			UsernameBox.Multiline = true;
			UsernameBox.Name = "UsernameBox";
			UsernameBox.Size = new Size(329, 38);
			UsernameBox.TabIndex = 67;
			UsernameBox.KeyDown += UsernameBox_KeyDown;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(1006, 356);
			label10.Name = "label10";
			label10.Size = new Size(79, 30);
			label10.TabIndex = 66;
			label10.Text = "الوردية";
			// 
			// PasswordBox
			// 
			PasswordBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			PasswordBox.Location = new Point(49, 243);
			PasswordBox.Multiline = true;
			PasswordBox.Name = "PasswordBox";
			PasswordBox.Size = new Size(329, 38);
			PasswordBox.TabIndex = 65;
			PasswordBox.KeyDown += PasswordBox_KeyDown;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(389, 359);
			label7.Name = "label7";
			label7.Size = new Size(187, 24);
			label7.TabIndex = 63;
			label7.Text = "السماحية للمستخدم";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.Red;
			label5.Location = new Point(407, 245);
			label5.Name = "label5";
			label5.Size = new Size(121, 30);
			label5.TabIndex = 62;
			label5.Text = "كلمة السر";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(950, 243);
			label4.Name = "label4";
			label4.Size = new Size(180, 24);
			label4.TabIndex = 61;
			label4.Text = "إسم تسجيل الدخول";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(997, 133);
			label2.Name = "label2";
			label2.Size = new Size(76, 30);
			label2.TabIndex = 60;
			label2.Text = "الاسم";
			// 
			// Closeimg
			// 
			Closeimg.Image = Properties.Resources.button;
			Closeimg.Location = new Point(1087, 4);
			Closeimg.Name = "Closeimg";
			Closeimg.Size = new Size(45, 41);
			Closeimg.SizeMode = PictureBoxSizeMode.StretchImage;
			Closeimg.TabIndex = 59;
			Closeimg.TabStop = false;
			Closeimg.Click += Closeimg_Click;
			// 
			// NameBox
			// 
			NameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			NameBox.Location = new Point(608, 133);
			NameBox.Multiline = true;
			NameBox.Name = "NameBox";
			NameBox.Size = new Size(329, 38);
			NameBox.TabIndex = 64;
			NameBox.KeyDown += NameBox_KeyDown;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(66, 125, 157);
			panel1.Controls.Add(Searchbtn);
			panel1.Controls.Add(pictureBox6);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(SearchBox);
			panel1.Location = new Point(-15, 50);
			panel1.Name = "panel1";
			panel1.Size = new Size(1154, 54);
			panel1.TabIndex = 58;
			// 
			// Searchbtn
			// 
			Searchbtn.BackColor = Color.Yellow;
			Searchbtn.Location = new Point(129, 7);
			Searchbtn.Name = "Searchbtn";
			Searchbtn.Size = new Size(130, 41);
			Searchbtn.TabIndex = 80;
			Searchbtn.Text = "بحث";
			Searchbtn.UseVisualStyleBackColor = false;
			Searchbtn.Click += Searchbtn_Click;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(1017, 7);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(67, 41);
			pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox6.TabIndex = 79;
			pictureBox6.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(689, 10);
			label6.Name = "label6";
			label6.Size = new Size(326, 30);
			label6.TabIndex = 77;
			label6.Text = "بحث باسم المستخدم للتعديل";
			// 
			// SearchBox
			// 
			SearchBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			SearchBox.Location = new Point(265, 8);
			SearchBox.Multiline = true;
			SearchBox.Name = "SearchBox";
			SearchBox.Size = new Size(418, 38);
			SearchBox.TabIndex = 78;
			SearchBox.KeyDown += SearchBox_KeyDown;
			// 
			// usernameloginlbl
			// 
			usernameloginlbl.AutoSize = true;
			usernameloginlbl.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			usernameloginlbl.Location = new Point(867, 13);
			usernameloginlbl.Name = "usernameloginlbl";
			usernameloginlbl.Size = new Size(121, 30);
			usernameloginlbl.TabIndex = 78;
			usernameloginlbl.Text = "username";
			usernameloginlbl.Visible = false;
			// 
			// ShiftBox
			// 
			ShiftBox.DropDownStyle = ComboBoxStyle.DropDownList;
			ShiftBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			ShiftBox.FormattingEnabled = true;
			ShiftBox.Items.AddRange(new object[] { "صباحى", "مسائى" });
			ShiftBox.Location = new Point(607, 359);
			ShiftBox.Name = "ShiftBox";
			ShiftBox.Size = new Size(330, 39);
			ShiftBox.TabIndex = 79;
			ShiftBox.KeyDown += ShiftBox_KeyDown;
			// 
			// Update_User_Data_Password
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1144, 635);
			Controls.Add(ShiftBox);
			Controls.Add(usernameloginlbl);
			Controls.Add(label3);
			Controls.Add(pictureBox2);
			Controls.Add(RoleBox);
			Controls.Add(label1);
			Controls.Add(PhoneBox);
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(deletebtn);
			Controls.Add(Savebtn);
			Controls.Add(UsernameBox);
			Controls.Add(label10);
			Controls.Add(PasswordBox);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(Closeimg);
			Controls.Add(NameBox);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Update_User_Data_Password";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Update_User_Data_Password";
			Load += Update_User_Data_Password_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label3;
		private ComboBox RoleBox;
		private PictureBox pictureBox2;
		private Label label1;
		private TextBox PhoneBox;
		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
		private Button deletebtn;
		private Button Savebtn;
		private TextBox UsernameBox;
		private Label label10;
		private TextBox PasswordBox;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label2;
		private PictureBox Closeimg;
		private TextBox NameBox;
		private Panel panel1;
		private PictureBox pictureBox6;
		private Label label6;
		private TextBox SearchBox;
		private Button Searchbtn;
		private Label usernameloginlbl;
		private ComboBox ShiftBox;
	}
}