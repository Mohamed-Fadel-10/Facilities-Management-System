namespace license
{
	partial class Add_Classification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Classification));
			pictureBox3 = new PictureBox();
			Addbtn = new Button();
			NameBox = new TextBox();
			CodeBox = new TextBox();
			label3 = new Label();
			label2 = new Label();
			Closeimg = new PictureBox();
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			errorelbl = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(434, 644);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(86, 60);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 51;
			pictureBox3.TabStop = false;
			// 
			// Addbtn
			// 
			Addbtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Addbtn.Location = new Point(526, 644);
			Addbtn.Name = "Addbtn";
			Addbtn.Size = new Size(163, 60);
			Addbtn.TabIndex = 48;
			Addbtn.Text = "إضافة";
			Addbtn.UseVisualStyleBackColor = true;
			Addbtn.Click += Addbtn_Click;
			// 
			// NameBox
			// 
			NameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			NameBox.Location = new Point(626, 312);
			NameBox.Multiline = true;
			NameBox.Name = "NameBox";
			NameBox.Size = new Size(326, 38);
			NameBox.TabIndex = 38;
			NameBox.KeyDown += NameBox_KeyDown;
			// 
			// CodeBox
			// 
			CodeBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			CodeBox.Location = new Point(626, 164);
			CodeBox.Multiline = true;
			CodeBox.Name = "CodeBox";
			CodeBox.Size = new Size(326, 38);
			CodeBox.TabIndex = 37;
			CodeBox.KeyDown += CodeBox_KeyDown;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(974, 169);
			label3.Name = "label3";
			label3.Size = new Size(109, 24);
			label3.TabIndex = 30;
			label3.Text = "كود التصنيف";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(982, 319);
			label2.Name = "label2";
			label2.Size = new Size(120, 24);
			label2.TabIndex = 29;
			label2.Text = "إسم التصنيف";
			// 
			// Closeimg
			// 
			Closeimg.Image = Properties.Resources.button;
			Closeimg.Location = new Point(1082, 4);
			Closeimg.Name = "Closeimg";
			Closeimg.Size = new Size(45, 41);
			Closeimg.SizeMode = PictureBoxSizeMode.StretchImage;
			Closeimg.TabIndex = 28;
			Closeimg.TabStop = false;
			Closeimg.Click += Closeimg_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(66, 125, 157);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(-7, 51);
			panel1.Name = "panel1";
			panel1.Size = new Size(1144, 54);
			panel1.TabIndex = 27;
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
			label1.Location = new Point(924, 11);
			label1.Name = "label1";
			label1.Size = new Size(159, 35);
			label1.TabIndex = 0;
			label1.Text = "إضافة تصنيف";
			// 
			// errorelbl
			// 
			errorelbl.AutoSize = true;
			errorelbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			errorelbl.ForeColor = Color.Red;
			errorelbl.Location = new Point(407, 403);
			errorelbl.Name = "errorelbl";
			errorelbl.Size = new Size(349, 35);
			errorelbl.TabIndex = 52;
			errorelbl.Text = "يرجى ادخال كل البيانات المطلوبة";
			errorelbl.Visible = false;
			// 
			// Add_Classification
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1130, 743);
			Controls.Add(errorelbl);
			Controls.Add(pictureBox3);
			Controls.Add(Addbtn);
			Controls.Add(NameBox);
			Controls.Add(CodeBox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(Closeimg);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Add_Classification";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "إضافة تصنيف";
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
		private TextBox NameBox;
		private TextBox CodeBox;
		private Label label3;
		private Label label2;
		private PictureBox Closeimg;
		private Panel panel1;
		private PictureBox pictureBox2;
		private Label label1;
		private Label errorelbl;
	}
}