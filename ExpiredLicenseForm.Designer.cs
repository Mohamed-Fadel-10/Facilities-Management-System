namespace license
{
    partial class ExpiredLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredLicenseForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            classificationlbl = new Label();
            button1 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            openFileDialog1 = new OpenFileDialog();
            addreslbl = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Licence_Start_Date = new DataGridViewTextBoxColumn();
            Licence_End_Date = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // classificationlbl
            // 
            classificationlbl.AutoSize = true;
            classificationlbl.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            classificationlbl.ForeColor = Color.Black;
            classificationlbl.Location = new Point(243, 94);
            classificationlbl.Name = "classificationlbl";
            classificationlbl.Size = new Size(144, 29);
            classificationlbl.TabIndex = 29;
            classificationlbl.Text = "وزارة الداخلية";
            // 
            // button1
            // 
            button1.Location = new Point(573, 950);
            button1.Name = "button1";
            button1.Size = new Size(102, 43);
            button1.TabIndex = 27;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // addreslbl
            // 
            addreslbl.AutoSize = true;
            addreslbl.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addreslbl.ForeColor = Color.Black;
            addreslbl.Location = new Point(243, 27);
            addreslbl.Name = "addreslbl";
            addreslbl.Size = new Size(144, 29);
            addreslbl.TabIndex = 28;
            addreslbl.Text = "وزارة الداخلية";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1128, 113);
            label1.Name = "label1";
            label1.Size = new Size(214, 29);
            label1.TabIndex = 25;
            label1.Text = "إدارة الحماية المدنية";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1104, 69);
            label4.Name = "label4";
            label4.Size = new Size(245, 29);
            label4.TabIndex = 24;
            label4.Text = "مديرية أمن البحر الاحمر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1165, 27);
            label3.Name = "label3";
            label3.Size = new Size(144, 29);
            label3.TabIndex = 23;
            label3.Text = "وزارة الداخلية";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(573, 94);
            label7.Name = "label7";
            label7.Size = new Size(220, 29);
            label7.TabIndex = 22;
            label7.Text = "وحدة وقاية المنشأات";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(573, 36);
            label5.Name = "label5";
            label5.Size = new Size(214, 29);
            label5.TabIndex = 21;
            label5.Text = "إدارة الحماية المدنية";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Police_Logo;
            pictureBox3.Location = new Point(12, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 145);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Code, Name, Address, Licence_Start_Date, Licence_End_Date, status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(5, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Yellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1374, 826);
            dataGridView1.TabIndex = 31;
            // 
            // Code
            // 
            Code.HeaderText = "كود المنشأة";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            // 
            // Name
            // 
            Name.HeaderText = "الاسم";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Address
            // 
            Address.HeaderText = "عنوان";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // Licence_Start_Date
            // 
            Licence_Start_Date.HeaderText = "تاريخ المعاينة";
            Licence_Start_Date.MinimumWidth = 6;
            Licence_Start_Date.Name = "Licence_Start_Date";
            // 
            // Licence_End_Date
            // 
            Licence_End_Date.HeaderText = "انتهاء الرخصة";
            Licence_End_Date.MinimumWidth = 6;
            Licence_End_Date.Name = "Licence_End_Date";
            // 
            // status
            // 
            status.HeaderText = "ساري-منتهي";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // ExpiredLicenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 1001);
            Controls.Add(dataGridView1);
            Controls.Add(classificationlbl);
            Controls.Add(button1);
            Controls.Add(addreslbl);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تقارير رخصة منتهية";
            Load += ExpiredLicenseForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classificationlbl;
        private Button button1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private OpenFileDialog openFileDialog1;
        private Label addreslbl;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label5;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Licence_Start_Date;
        private DataGridViewTextBoxColumn Licence_End_Date;
        private DataGridViewTextBoxColumn status;
    }
}