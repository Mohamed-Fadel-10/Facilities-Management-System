namespace license
{
	partial class Place_Details
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Place_Details));
            button2 = new Button();
            TextBox = new TextBox();
            AddressBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Closeimg = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            NameBox = new TextBox();
            panel1 = new Panel();
            StartDate = new DateTimePicker();
            EndDate = new DateTimePicker();
            ClassificationBox = new ComboBox();
            clsssificationBindingSource = new BindingSource(components);
            StatusBox = new ComboBox();
            Error = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            CodeBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clsssificationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(557, 634);
            button2.Name = "button2";
            button2.Size = new Size(163, 45);
            button2.TabIndex = 49;
            button2.Text = "إضافة";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TextBox
            // 
            TextBox.Enabled = false;
            TextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(138, 448);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(831, 113);
            TextBox.TabIndex = 46;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(107, 233);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(862, 39);
            AddressBox.TabIndex = 44;
            AddressBox.KeyDown += AddressBox_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1016, 501);
            label9.Name = "label9";
            label9.Size = new Size(54, 24);
            label9.TabIndex = 36;
            label9.Text = "مرفق";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(995, 391);
            label8.Name = "label8";
            label8.Size = new Size(75, 24);
            label8.TabIndex = 35;
            label8.Text = "التصنيف";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(416, 386);
            label7.Name = "label7";
            label7.Size = new Size(174, 24);
            label7.TabIndex = 34;
            label7.Text = "الموقف من الترخيص";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(431, 316);
            label6.Name = "label6";
            label6.Size = new Size(110, 24);
            label6.TabIndex = 33;
            label6.Text = "تاريخ الانتهاء";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(985, 315);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 32;
            label5.Text = "تاريخ المعاينة";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1026, 248);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 31;
            label4.Text = "العنوان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1026, 160);
            label2.Name = "label2";
            label2.Size = new Size(61, 24);
            label2.TabIndex = 29;
            label2.Text = "الاسم";
            // 
            // Closeimg
            // 
            Closeimg.Image = Properties.Resources.button;
            Closeimg.Location = new Point(1073, 17);
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
            label1.Location = new Point(923, 11);
            label1.Name = "label1";
            label1.Size = new Size(148, 35);
            label1.TabIndex = 0;
            label1.Text = "إضافة منشأة";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(640, 153);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(329, 39);
            NameBox.TabIndex = 38;
            NameBox.KeyDown += NameBox_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 125, 157);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-16, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 53);
            panel1.TabIndex = 27;
            // 
            // StartDate
            // 
            StartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartDate.Format = DateTimePickerFormat.Custom;
            StartDate.Location = new Point(741, 314);
            StartDate.Margin = new Padding(3, 4, 3, 4);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(228, 34);
            StartDate.TabIndex = 59;
            StartDate.Value = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            StartDate.KeyDown += StartDate_KeyDown;
            // 
            // EndDate
            // 
            EndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EndDate.Format = DateTimePickerFormat.Custom;
            EndDate.Location = new Point(156, 315);
            EndDate.Margin = new Padding(3, 4, 3, 4);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(228, 34);
            EndDate.TabIndex = 60;
            EndDate.Value = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            EndDate.ValueChanged += EndDate_ValueChanged;
            EndDate.KeyDown += EndDate_KeyDown;
            // 
            // ClassificationBox
            // 
            ClassificationBox.DataSource = clsssificationBindingSource;
            ClassificationBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassificationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassificationBox.FormattingEnabled = true;
            ClassificationBox.Location = new Point(741, 387);
            ClassificationBox.Margin = new Padding(3, 4, 3, 4);
            ClassificationBox.Name = "ClassificationBox";
            ClassificationBox.Size = new Size(228, 36);
            ClassificationBox.TabIndex = 61;
            ClassificationBox.KeyDown += ClassificationBox_KeyDown;
            // 
            // clsssificationBindingSource
            // 
            clsssificationBindingSource.DataSource = typeof(builders_Project.Models.clsssification);
            // 
            // StatusBox
            // 
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusBox.FlatStyle = FlatStyle.System;
            StatusBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StatusBox.ForeColor = Color.Red;
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "موافقة", "مرفوضة" });
            StatusBox.Location = new Point(156, 386);
            StatusBox.Margin = new Padding(3, 4, 3, 4);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(228, 36);
            StatusBox.TabIndex = 62;
            StatusBox.KeyDown += StatusBox_KeyDown;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Error.ForeColor = Color.Red;
            Error.Location = new Point(318, 573);
            Error.Name = "Error";
            Error.Size = new Size(554, 28);
            Error.TabIndex = 63;
            Error.Text = "يوجد حقل فارغ يرجى مراجعة البيانات بعناية وادخال الخانات الفارغة";
            Error.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 634);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(467, 160);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 69;
            label3.Text = "كود المنشأة";
            // 
            // CodeBox
            // 
            CodeBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBox.Location = new Point(122, 153);
            CodeBox.Multiline = true;
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(329, 39);
            CodeBox.TabIndex = 70;
            // 
            // Place_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1133, 755);
            Controls.Add(label3);
            Controls.Add(CodeBox);
            Controls.Add(pictureBox1);
            Controls.Add(Error);
            Controls.Add(StatusBox);
            Controls.Add(ClassificationBox);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Controls.Add(button2);
            Controls.Add(TextBox);
            Controls.Add(AddressBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Closeimg);
            Controls.Add(NameBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Place_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Place_Details";
            Load += Place_Details_Load;
            ((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clsssificationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
		private TextBox TextBox;
		private TextBox AddressBox;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label2;
		private PictureBox Closeimg;
		private PictureBox pictureBox2;
		private Label label1;
		private TextBox NameBox;
		private Panel panel1;
		private DateTimePicker StartDate;
		private DateTimePicker EndDate;
		private ComboBox ClassificationBox;
		private ComboBox StatusBox;
		private BindingSource clsssificationBindingSource;
		private Label Error;
		private PictureBox pictureBox1;
        private Label label3;
        private TextBox CodeBox;
    }
}