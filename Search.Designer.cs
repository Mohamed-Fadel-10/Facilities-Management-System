namespace license
{
	partial class Search
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            PlacesData = new DataGridView();
            Expire_notExpire = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            End_Date = new DataGridViewTextBoxColumn();
            Start_Date = new DataGridViewTextBoxColumn();
            Classification = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            Searchbtn = new Button();
            StatusBox = new ComboBox();
            label4 = new Label();
            CodeSearchBox = new TextBox();
            label3 = new Label();
            NameSearchBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ClassificatioBox = new ComboBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)PlacesData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PlacesData
            // 
            PlacesData.AllowUserToAddRows = false;
            PlacesData.AllowUserToDeleteRows = false;
            PlacesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PlacesData.BackgroundColor = Color.White;
            PlacesData.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PlacesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PlacesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlacesData.Columns.AddRange(new DataGridViewColumn[] { Expire_notExpire, Status, End_Date, Start_Date, Classification, Address, ID, Name });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PlacesData.DefaultCellStyle = dataGridViewCellStyle2;
            PlacesData.Location = new Point(4, 248);
            PlacesData.Name = "PlacesData";
            PlacesData.ReadOnly = true;
            PlacesData.RowHeadersWidth = 51;
            PlacesData.RowTemplate.Height = 29;
            PlacesData.Size = new Size(1670, 573);
            PlacesData.TabIndex = 0;
            PlacesData.CellDoubleClick += PlacesData_CellDoubleClick;
            // 
            // Expire_notExpire
            // 
            Expire_notExpire.HeaderText = "سارى منتهى";
            Expire_notExpire.MinimumWidth = 6;
            Expire_notExpire.Name = "Expire_notExpire";
            Expire_notExpire.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "الموقف من الترخيص";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // End_Date
            // 
            End_Date.HeaderText = "انتهاء تاريخ المعاينة";
            End_Date.MinimumWidth = 6;
            End_Date.Name = "End_Date";
            End_Date.ReadOnly = true;
            // 
            // Start_Date
            // 
            Start_Date.HeaderText = "تاريخ المعاينة";
            Start_Date.MinimumWidth = 6;
            Start_Date.Name = "Start_Date";
            Start_Date.ReadOnly = true;
            // 
            // Classification
            // 
            Classification.HeaderText = "التصنيف";
            Classification.MinimumWidth = 6;
            Classification.Name = "Classification";
            Classification.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "العنوان";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "كود المنشأة";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "ألاسم";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 125, 157);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Searchbtn);
            panel1.Controls.Add(StatusBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CodeSearchBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NameSearchBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ClassificatioBox);
            panel1.Location = new Point(4, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(1670, 182);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(69, 43);
            button1.Name = "button1";
            button1.Size = new Size(124, 44);
            button1.TabIndex = 18;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = Color.White;
            Searchbtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(1116, 27);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(124, 44);
            Searchbtn.TabIndex = 17;
            Searchbtn.Text = "بحث";
            Searchbtn.UseVisualStyleBackColor = false;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // StatusBox
            // 
            StatusBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "موافقة", "مرفوضة" });
            StatusBox.Location = new Point(1263, 124);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(290, 38);
            StatusBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1361, 93);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 15;
            label4.Text = "موقف من الترخيص";
            // 
            // CodeSearchBox
            // 
            CodeSearchBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CodeSearchBox.Location = new Point(223, 116);
            CodeSearchBox.Multiline = true;
            CodeSearchBox.Name = "CodeSearchBox";
            CodeSearchBox.Size = new Size(329, 38);
            CodeSearchBox.TabIndex = 14;
            CodeSearchBox.KeyDown += CodeSearchBox_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(449, 85);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 13;
            label3.Text = "بحث بالكود";
            // 
            // NameSearchBox
            // 
            NameSearchBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NameSearchBox.Location = new Point(223, 44);
            NameSearchBox.Multiline = true;
            NameSearchBox.Name = "NameSearchBox";
            NameSearchBox.Size = new Size(329, 38);
            NameSearchBox.TabIndex = 12;
            NameSearchBox.KeyDown += NameSearchBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(440, 12);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 2;
            label2.Text = " بحث بألاسم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1448, 1);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 1;
            label1.Text = "التصنيف";
            // 
            // ClassificatioBox
            // 
            ClassificatioBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ClassificatioBox.FormattingEnabled = true;
            ClassificatioBox.Location = new Point(1263, 32);
            ClassificatioBox.Name = "ClassificatioBox";
            ClassificatioBox.Size = new Size(290, 38);
            ClassificatioBox.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(821, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(914, 8);
            label5.Name = "label5";
            label5.Size = new Size(102, 46);
            label5.TabIndex = 3;
            label5.Text = "البحث";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1687, 823);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(PlacesData);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            Text = "البحث";
            WindowState = FormWindowState.Maximized;
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)PlacesData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PlacesData;
		private Panel panel1;
		private Label label2;
		private Label label1;
		private ComboBox ClassificatioBox;
		private Label label4;
		private TextBox CodeSearchBox;
		private Label label3;
		private TextBox NameSearchBox;
		private PictureBox pictureBox2;
		private Label label5;
		private Button Searchbtn;
		private ComboBox StatusBox;
		private Button button1;
		private DataGridViewTextBoxColumn Expire_notExpire;
		private DataGridViewTextBoxColumn Status;
		private DataGridViewTextBoxColumn End_Date;
		private DataGridViewTextBoxColumn Start_Date;
		private DataGridViewTextBoxColumn Classification;
		private DataGridViewTextBoxColumn Address;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn Name;
	}
}