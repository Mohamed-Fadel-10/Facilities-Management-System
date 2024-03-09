namespace license
{
    partial class UpdateLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateLicense));
            Namelbl = new Label();
            Name = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            EndDateBox = new DateTimePicker();
            StartDateBox = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            UpdateLicensebtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Namelbl.Location = new Point(491, 109);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(165, 33);
            Namelbl.TabIndex = 30;
            Namelbl.Text = "إسم المنشأة";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(662, 109);
            Name.Name = "Name";
            Name.Size = new Size(207, 33);
            Name.TabIndex = 31;
            Name.Text = ": إسم المنشأة   ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 125, 157);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 54);
            panel1.TabIndex = 32;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(649, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(714, 10);
            label1.Name = "label1";
            label1.Size = new Size(142, 35);
            label1.TabIndex = 3;
            label1.Text = "تجديد رخصة";
            // 
            // EndDateBox
            // 
            EndDateBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EndDateBox.Format = DateTimePickerFormat.Short;
            EndDateBox.Location = new Point(366, 299);
            EndDateBox.Name = "EndDateBox";
            EndDateBox.Size = new Size(338, 36);
            EndDateBox.TabIndex = 36;
            // 
            // StartDateBox
            // 
            StartDateBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateBox.Format = DateTimePickerFormat.Short;
            StartDateBox.Location = new Point(366, 203);
            StartDateBox.Name = "StartDateBox";
            StartDateBox.Size = new Size(338, 36);
            StartDateBox.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(725, 308);
            label6.Name = "label6";
            label6.Size = new Size(123, 24);
            label6.TabIndex = 34;
            label6.Text = ": تاريخ الانتهاء";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(717, 204);
            label5.Name = "label5";
            label5.Size = new Size(131, 24);
            label5.TabIndex = 33;
            label5.Text = ": تاريخ المعاينة";
            // 
            // UpdateLicensebtn
            // 
            UpdateLicensebtn.BackColor = Color.DodgerBlue;
            UpdateLicensebtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateLicensebtn.Location = new Point(328, 531);
            UpdateLicensebtn.Name = "UpdateLicensebtn";
            UpdateLicensebtn.Size = new Size(155, 45);
            UpdateLicensebtn.TabIndex = 37;
            UpdateLicensebtn.Text = "تجديد";
            UpdateLicensebtn.UseVisualStyleBackColor = false;
            UpdateLicensebtn.Click += UpdateLicensebtn_Click;
            // 
            // UpdateLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 633);
            Controls.Add(UpdateLicensebtn);
            Controls.Add(EndDateBox);
            Controls.Add(StartDateBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(Name);
            Controls.Add(Namelbl);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateLicense";
            Load += UpdateLicense_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Namelbl;
        private Label Name;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private DateTimePicker EndDateBox;
        private DateTimePicker StartDateBox;
        private Label label6;
        private Label label5;
        private Button UpdateLicensebtn;
    }
}