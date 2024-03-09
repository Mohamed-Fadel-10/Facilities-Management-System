namespace license
{
    partial class Reports
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
            panel1 = new Panel();
            Expirebtn = new Button();
            Monthbtn = new Button();
            TowYearsbtn = new Button();
            AddressBox = new ComboBox();
            label2 = new Label();
            oneYearbtn = new Button();
            pdf2btn = new Button();
            pdf3btn = new Button();
            pdf4btn = new Button();
            pdf1btn = new Button();
            classificationBox = new ComboBox();
            label1 = new Label();
            pdf5btn = new Button();
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            betweenTwoDatebtn = new Button();
            label4 = new Label();
            label3 = new Label();
            Closeimg = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Expirebtn);
            panel1.Controls.Add(Monthbtn);
            panel1.Controls.Add(TowYearsbtn);
            panel1.Controls.Add(AddressBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(oneYearbtn);
            panel1.Controls.Add(pdf2btn);
            panel1.Controls.Add(pdf3btn);
            panel1.Controls.Add(pdf4btn);
            panel1.Controls.Add(pdf1btn);
            panel1.Controls.Add(classificationBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 408);
            panel1.TabIndex = 0;
            // 
            // Expirebtn
            // 
            Expirebtn.BackColor = Color.LightSkyBlue;
            Expirebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Expirebtn.Location = new Point(120, 350);
            Expirebtn.Name = "Expirebtn";
            Expirebtn.Size = new Size(406, 38);
            Expirebtn.TabIndex = 12;
            Expirebtn.Text = "تقرير رخصة منتهية";
            Expirebtn.UseVisualStyleBackColor = false;
            Expirebtn.Click += Expirebtn_Click;
            // 
            // Monthbtn
            // 
            Monthbtn.BackColor = Color.LightSkyBlue;
            Monthbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Monthbtn.Location = new Point(120, 290);
            Monthbtn.Name = "Monthbtn";
            Monthbtn.Size = new Size(406, 38);
            Monthbtn.TabIndex = 11;
            Monthbtn.Text = "تقرير قبل انتهاء الرخصة بشهر";
            Monthbtn.UseVisualStyleBackColor = false;
            Monthbtn.Click += Monthbtn_Click;
            // 
            // TowYearsbtn
            // 
            TowYearsbtn.BackColor = Color.LightSkyBlue;
            TowYearsbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TowYearsbtn.Location = new Point(120, 224);
            TowYearsbtn.Name = "TowYearsbtn";
            TowYearsbtn.Size = new Size(406, 38);
            TowYearsbtn.TabIndex = 10;
            TowYearsbtn.Text = "تقرير مراجعة سنتين";
            TowYearsbtn.UseVisualStyleBackColor = false;
            TowYearsbtn.Click += TowYearsbtn_Click;
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.FormattingEnabled = true;
            AddressBox.Location = new Point(120, 84);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(406, 39);
            AddressBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(569, 89);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 8;
            label2.Text = ": العنوان";
            // 
            // oneYearbtn
            // 
            oneYearbtn.BackColor = Color.LightSkyBlue;
            oneYearbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            oneYearbtn.Location = new Point(120, 160);
            oneYearbtn.Name = "oneYearbtn";
            oneYearbtn.Size = new Size(406, 38);
            oneYearbtn.TabIndex = 7;
            oneYearbtn.Text = "تقرير المراجعة السنوية";
            oneYearbtn.UseVisualStyleBackColor = false;
            oneYearbtn.Click += oneYearbtn_Click;
            // 
            // pdf2btn
            // 
            pdf2btn.BackColor = Color.Yellow;
            pdf2btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdf2btn.Location = new Point(569, 224);
            pdf2btn.Name = "pdf2btn";
            pdf2btn.Size = new Size(112, 38);
            pdf2btn.TabIndex = 6;
            pdf2btn.Text = "PDF";
            pdf2btn.UseVisualStyleBackColor = false;
            pdf2btn.Click += pdf2btn_Click;
            // 
            // pdf3btn
            // 
            pdf3btn.BackColor = Color.Yellow;
            pdf3btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdf3btn.Location = new Point(569, 290);
            pdf3btn.Name = "pdf3btn";
            pdf3btn.Size = new Size(112, 38);
            pdf3btn.TabIndex = 5;
            pdf3btn.Text = "PDF";
            pdf3btn.UseVisualStyleBackColor = false;
            pdf3btn.Click += pdf3btn_Click;
            // 
            // pdf4btn
            // 
            pdf4btn.BackColor = Color.Yellow;
            pdf4btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdf4btn.Location = new Point(569, 350);
            pdf4btn.Name = "pdf4btn";
            pdf4btn.Size = new Size(112, 38);
            pdf4btn.TabIndex = 4;
            pdf4btn.Text = "PDF";
            pdf4btn.UseVisualStyleBackColor = false;
            pdf4btn.Click += pdf4btn_Click;
            // 
            // pdf1btn
            // 
            pdf1btn.BackColor = Color.Yellow;
            pdf1btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdf1btn.Location = new Point(569, 160);
            pdf1btn.Name = "pdf1btn";
            pdf1btn.Size = new Size(112, 38);
            pdf1btn.TabIndex = 2;
            pdf1btn.Text = "PDF";
            pdf1btn.UseVisualStyleBackColor = false;
            pdf1btn.Click += pdf1btn_Click;
            // 
            // classificationBox
            // 
            classificationBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            classificationBox.FormattingEnabled = true;
            classificationBox.Location = new Point(120, 28);
            classificationBox.Name = "classificationBox";
            classificationBox.Size = new Size(406, 39);
            classificationBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(548, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = ": تحديد التصنيف";
            // 
            // pdf5btn
            // 
            pdf5btn.BackColor = Color.Yellow;
            pdf5btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdf5btn.Location = new Point(548, 101);
            pdf5btn.Name = "pdf5btn";
            pdf5btn.Size = new Size(112, 51);
            pdf5btn.TabIndex = 3;
            pdf5btn.Text = "PDF";
            pdf5btn.UseVisualStyleBackColor = false;
            pdf5btn.Click += pdf5btn_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(betweenTwoDatebtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pdf5btn);
            panel2.Location = new Point(37, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 166);
            panel2.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(102, 30);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(146, 27);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.Value = new DateTime(2023, 12, 26, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(428, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 27);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2023, 12, 26, 0, 0, 0, 0);
            // 
            // betweenTwoDatebtn
            // 
            betweenTwoDatebtn.BackColor = Color.LightSkyBlue;
            betweenTwoDatebtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            betweenTwoDatebtn.Location = new Point(120, 101);
            betweenTwoDatebtn.Name = "betweenTwoDatebtn";
            betweenTwoDatebtn.Size = new Size(422, 51);
            betweenTwoDatebtn.TabIndex = 9;
            betweenTwoDatebtn.Text = "تقرير بين تاريخين فى تاريخ انتهاء المعاملة";
            betweenTwoDatebtn.UseVisualStyleBackColor = false;
            betweenTwoDatebtn.Click += betweenTwoDatebtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 28);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 8;
            label4.Text = "إلى تاريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(595, 28);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 6;
            label3.Text = "من تاريخ";
            // 
            // Closeimg
            // 
            Closeimg.Image = Properties.Resources.button;
            Closeimg.Location = new Point(775, 8);
            Closeimg.Name = "Closeimg";
            Closeimg.Size = new Size(40, 35);
            Closeimg.SizeMode = PictureBoxSizeMode.StretchImage;
            Closeimg.TabIndex = 5;
            Closeimg.TabStop = false;
            Closeimg.Click += Closeimg_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(821, 633);
            Controls.Add(Closeimg);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "التقارير";
            Load += Reports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button pdf2btn;
        private Button pdf3btn;
        private Button pdf4btn;
        private Button pdf1btn;
        private ComboBox classificationBox;
        private Label label1;
        private Button pdf5btn;
        private Panel panel2;
        private Button Monthbtn;
        private Button TowYearsbtn;
        private ComboBox AddressBox;
        private Label label2;
        private Button oneYearbtn;
        private Button Expirebtn;
        private Button betweenTwoDatebtn;
        private Label label4;
        private Label label3;
        private PictureBox Closeimg;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}