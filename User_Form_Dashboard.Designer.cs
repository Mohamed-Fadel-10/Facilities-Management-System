namespace license
{
	partial class User_Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form_Dashboard));
            label3 = new Label();
            Closeimg = new PictureBox();
            usernamelogin = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Searchlbl = new Label();
            changePasswordlbl = new Label();
            Reportslbl = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ChangeShiftbtn = new Button();
            panel1 = new Panel();
            Exitebtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1432, 118);
            label3.Name = "label3";
            label3.Size = new Size(177, 36);
            label3.TabIndex = 24;
            label3.Text = "وزارة الداخلية";
            // 
            // Closeimg
            // 
            Closeimg.Image = (Image)resources.GetObject("Closeimg.Image");
            Closeimg.Location = new Point(1546, 6);
            Closeimg.Name = "Closeimg";
            Closeimg.Size = new Size(53, 40);
            Closeimg.SizeMode = PictureBoxSizeMode.StretchImage;
            Closeimg.TabIndex = 8;
            Closeimg.TabStop = false;
            Closeimg.Click += Closeimg_Click;
            // 
            // usernamelogin
            // 
            usernamelogin.AutoSize = true;
            usernamelogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelogin.ForeColor = Color.White;
            usernamelogin.Location = new Point(1358, 10);
            usernamelogin.Name = "usernamelogin";
            usernamelogin.Size = new Size(28, 35);
            usernamelogin.TabIndex = 7;
            usernamelogin.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1397, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 35);
            label1.TabIndex = 6;
            label1.Text = "/  مرحباً بك  ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.45799F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.54201F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 493F));
            tableLayoutPanel1.Controls.Add(Searchlbl, 2, 0);
            tableLayoutPanel1.Controls.Add(changePasswordlbl, 0, 0);
            tableLayoutPanel1.Controls.Add(Reportslbl, 1, 0);
            tableLayoutPanel1.Location = new Point(110, 472);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1459, 90);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // Searchlbl
            // 
            Searchlbl.AutoSize = true;
            Searchlbl.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Searchlbl.ForeColor = Color.Black;
            Searchlbl.Location = new Point(967, 1);
            Searchlbl.Name = "Searchlbl";
            Searchlbl.Padding = new Padding(200, 40, 20, 0);
            Searchlbl.Size = new Size(309, 76);
            Searchlbl.TabIndex = 15;
            Searchlbl.Text = "البحث";
            Searchlbl.Click += Searchlbl_Click;
            // 
            // changePasswordlbl
            // 
            changePasswordlbl.AutoSize = true;
            changePasswordlbl.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            changePasswordlbl.ForeColor = Color.Black;
            changePasswordlbl.Location = new Point(4, 1);
            changePasswordlbl.Name = "changePasswordlbl";
            changePasswordlbl.Padding = new Padding(200, 40, 20, 0);
            changePasswordlbl.Size = new Size(429, 76);
            changePasswordlbl.TabIndex = 18;
            changePasswordlbl.Text = "تغير كلمة المرور";
            changePasswordlbl.Click += changePasswordlbl_Click;
            // 
            // Reportslbl
            // 
            Reportslbl.AutoSize = true;
            Reportslbl.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Reportslbl.ForeColor = Color.Black;
            Reportslbl.Location = new Point(451, 1);
            Reportslbl.Name = "Reportslbl";
            Reportslbl.Padding = new Padding(250, 40, 20, 0);
            Reportslbl.Size = new Size(367, 76);
            Reportslbl.TabIndex = 16;
            Reportslbl.Text = "التقارير";
            Reportslbl.Click += Reportslbl_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(760, 255);
            label7.Name = "label7";
            label7.Size = new Size(271, 36);
            label7.TabIndex = 28;
            label7.Text = "وحدة وقاية المنشأات";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(769, 204);
            label6.Name = "label6";
            label6.Size = new Size(251, 36);
            label6.TabIndex = 27;
            label6.Text = "ألارشيف الالكترونى";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1395, 204);
            label5.Name = "label5";
            label5.Size = new Size(258, 36);
            label5.TabIndex = 26;
            label5.Text = "إدارة الحماية المدنية";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1371, 160);
            label4.Name = "label4";
            label4.Size = new Size(299, 36);
            label4.TabIndex = 25;
            label4.Text = "مديرية أمن البحر الاحمر";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.exchanging;
            pictureBox1.Location = new Point(264, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.Police_Logo;
            pictureBox3.Location = new Point(62, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(252, 194);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // ChangeShiftbtn
            // 
            ChangeShiftbtn.BackColor = Color.White;
            ChangeShiftbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeShiftbtn.Location = new Point(327, 5);
            ChangeShiftbtn.Name = "ChangeShiftbtn";
            ChangeShiftbtn.Size = new Size(164, 40);
            ChangeShiftbtn.TabIndex = 3;
            ChangeShiftbtn.Text = "تغير وردية";
            ChangeShiftbtn.UseVisualStyleBackColor = false;
            ChangeShiftbtn.Click += ChangeShiftbtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(66, 125, 157);
            panel1.Controls.Add(Closeimg);
            panel1.Controls.Add(usernamelogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ChangeShiftbtn);
            panel1.Controls.Add(Exitebtn);
            panel1.Location = new Point(-6, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1743, 52);
            panel1.TabIndex = 22;
            // 
            // Exitebtn
            // 
            Exitebtn.BackColor = Color.White;
            Exitebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exitebtn.Location = new Point(80, 5);
            Exitebtn.Name = "Exitebtn";
            Exitebtn.Size = new Size(164, 40);
            Exitebtn.TabIndex = 2;
            Exitebtn.Text = "تسجيل الخروج";
            Exitebtn.UseVisualStyleBackColor = false;
            Exitebtn.Click += Exitebtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1352, 6);
            label2.Name = "label2";
            label2.Size = new Size(148, 24);
            label2.TabIndex = 40;
            label2.Text = "الصفحة الرئيسية";
            // 
            // User_Form_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1734, 779);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User_Form_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Form_Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
		private PictureBox Closeimg;
		private Label usernamelogin;
		private Label label1;
		private PictureBox pictureBox2;
		private TableLayoutPanel tableLayoutPanel1;
		private Label changePasswordlbl;
		private Label Reportslbl;
		private Label Searchlbl;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox3;
		private Button ChangeShiftbtn;
		private Panel panel1;
		private Button Exitebtn;
		private Label label2;
	}
}