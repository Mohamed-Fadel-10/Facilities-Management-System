namespace license
{
	partial class Add_User
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User));
			pictureBox3 = new PictureBox();
			Addbtn = new Button();
			UserNameBox = new TextBox();
			label10 = new Label();
			PasswordBox = new TextBox();
			label7 = new Label();
			label5 = new Label();
			label4 = new Label();
			label2 = new Label();
			Closeimg = new PictureBox();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			NameBox = new TextBox();
			panel1 = new Panel();
			RoleBox = new ComboBox();
			label3 = new Label();
			PhoneBox = new TextBox();
			ShiftBox = new ComboBox();
			Error = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(342, 571);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(86, 60);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 51;
			pictureBox3.TabStop = false;
			// 
			// Addbtn
			// 
			Addbtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Addbtn.Location = new Point(434, 571);
			Addbtn.Name = "Addbtn";
			Addbtn.Size = new Size(163, 60);
			Addbtn.TabIndex = 48;
			Addbtn.Text = "إضافة";
			Addbtn.UseVisualStyleBackColor = true;
			Addbtn.Click += Addbtn_Click;
			// 
			// UserNameBox
			// 
			UserNameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			UserNameBox.Location = new Point(607, 274);
			UserNameBox.Multiline = true;
			UserNameBox.Name = "UserNameBox";
			UserNameBox.Size = new Size(329, 38);
			UserNameBox.TabIndex = 44;
			UserNameBox.KeyDown += UserNameBox_KeyDown;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(1006, 410);
			label10.Name = "label10";
			label10.Size = new Size(79, 30);
			label10.TabIndex = 41;
			label10.Text = "الوردية";
			// 
			// PasswordBox
			// 
			PasswordBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			PasswordBox.Location = new Point(48, 281);
			PasswordBox.Multiline = true;
			PasswordBox.Name = "PasswordBox";
			PasswordBox.Size = new Size(329, 38);
			PasswordBox.TabIndex = 39;
			PasswordBox.KeyDown += PasswordBox_KeyDown;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(389, 413);
			label7.Name = "label7";
			label7.Size = new Size(187, 24);
			label7.TabIndex = 34;
			label7.Text = "السماحية للمستخدم";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(406, 283);
			label5.Name = "label5";
			label5.Size = new Size(121, 30);
			label5.TabIndex = 32;
			label5.Text = "كلمة السر";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(949, 281);
			label4.Name = "label4";
			label4.Size = new Size(180, 24);
			label4.TabIndex = 31;
			label4.Text = "إسم تسجيل الدخول";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(996, 132);
			label2.Name = "label2";
			label2.Size = new Size(76, 30);
			label2.TabIndex = 29;
			label2.Text = "الاسم";
			// 
			// Closeimg
			// 
			Closeimg.Image = Properties.Resources.button;
			Closeimg.Location = new Point(1076, 2);
			Closeimg.Name = "Closeimg";
			Closeimg.Size = new Size(45, 41);
			Closeimg.SizeMode = PictureBoxSizeMode.StretchImage;
			Closeimg.TabIndex = 28;
			Closeimg.TabStop = false;
			Closeimg.Click += Closeimg_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(832, 8);
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
			label1.ForeColor = Color.White;
			label1.Location = new Point(929, 11);
			label1.Name = "label1";
			label1.Size = new Size(172, 35);
			label1.TabIndex = 0;
			label1.Text = "إضافة مستخدم";
			// 
			// NameBox
			// 
			NameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			NameBox.Location = new Point(607, 132);
			NameBox.Multiline = true;
			NameBox.Name = "NameBox";
			NameBox.Size = new Size(329, 38);
			NameBox.TabIndex = 38;
			NameBox.KeyDown += NameBox_KeyDown;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(66, 125, 157);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(-16, 49);
			panel1.Name = "panel1";
			panel1.Size = new Size(1144, 54);
			panel1.TabIndex = 27;
			// 
			// RoleBox
			// 
			RoleBox.DropDownStyle = ComboBoxStyle.DropDownList;
			RoleBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			RoleBox.FormattingEnabled = true;
			RoleBox.Items.AddRange(new object[] { "Admin", "User" });
			RoleBox.Location = new Point(48, 408);
			RoleBox.Name = "RoleBox";
			RoleBox.Size = new Size(330, 39);
			RoleBox.TabIndex = 54;
			RoleBox.KeyDown += RoleBox_KeyDown;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(414, 132);
			label3.Name = "label3";
			label3.Size = new Size(138, 30);
			label3.TabIndex = 55;
			label3.Text = "رقم التليفون";
			// 
			// PhoneBox
			// 
			PhoneBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			PhoneBox.Location = new Point(48, 132);
			PhoneBox.Multiline = true;
			PhoneBox.Name = "PhoneBox";
			PhoneBox.Size = new Size(329, 38);
			PhoneBox.TabIndex = 56;
			PhoneBox.KeyDown += PhoneBox_KeyDown;
			// 
			// ShiftBox
			// 
			ShiftBox.DropDownStyle = ComboBoxStyle.DropDownList;
			ShiftBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			ShiftBox.FormattingEnabled = true;
			ShiftBox.Items.AddRange(new object[] { "صباحى", "مسائى" });
			ShiftBox.Location = new Point(608, 407);
			ShiftBox.Name = "ShiftBox";
			ShiftBox.Size = new Size(329, 39);
			ShiftBox.TabIndex = 57;
			ShiftBox.KeyDown += ShiftBox_KeyDown;
			// 
			// Error
			// 
			Error.AutoSize = true;
			Error.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
			Error.ForeColor = Color.Red;
			Error.Location = new Point(315, 493);
			Error.Name = "Error";
			Error.Size = new Size(366, 30);
			Error.TabIndex = 58;
			Error.Text = "برجاء ادخال جميع البيانات المطلوبة";
			Error.Visible = false;
			// 
			// Add_User
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1133, 656);
			Controls.Add(Error);
			Controls.Add(ShiftBox);
			Controls.Add(label3);
			Controls.Add(PhoneBox);
			Controls.Add(RoleBox);
			Controls.Add(pictureBox3);
			Controls.Add(Addbtn);
			Controls.Add(UserNameBox);
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
			Name = "Add_User";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "إضافة مستخدم";
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
		private PictureBox pictureBox3;
		private Button button3;
		private Button button2;
		private Button Addbtn;
		private TextBox UserNameBox;
		private Label label10;
		private TextBox PasswordBox;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label2;
		private PictureBox Closeimg;
		private PictureBox pictureBox2;
		private Label label1;
		private TextBox NameBox;
		private Panel panel1;
		private ComboBox RoleBox;
		private Label label3;
		private TextBox PhoneBox;
		private ComboBox ShiftBox;
		private Label Error;
	}
}