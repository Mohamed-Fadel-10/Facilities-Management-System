namespace license
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            Passwordbox = new TextBox();
            pictureBox2 = new PictureBox();
            Resetbtn = new Button();
            Enterbtn = new Button();
            label2 = new Label();
            UserNameBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            ClosePhoto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClosePhoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(Passwordbox);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Resetbtn);
            panel1.Controls.Add(Enterbtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UserNameBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 522);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(172, 12);
            label7.Name = "label7";
            label7.Size = new Size(141, 41);
            label7.TabIndex = 16;
            label7.Text = "مرحبا بك";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(262, 422);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(29, 422);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(13, 297);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Passwordbox
            // 
            Passwordbox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Passwordbox.Location = new Point(76, 297);
            Passwordbox.Multiline = true;
            Passwordbox.Name = "Passwordbox";
            Passwordbox.PasswordChar = '*';
            Passwordbox.Size = new Size(329, 38);
            Passwordbox.TabIndex = 7;
            Passwordbox.KeyDown += Passwordbox_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Resetbtn
            // 
            Resetbtn.BackColor = Color.Gold;
            Resetbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Resetbtn.Location = new Point(322, 422);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(151, 51);
            Resetbtn.TabIndex = 5;
            Resetbtn.Text = "إعادة المحاولة";
            Resetbtn.UseVisualStyleBackColor = false;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // Enterbtn
            // 
            Enterbtn.BackColor = Color.FromArgb(48, 129, 208);
            Enterbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Enterbtn.Location = new Point(89, 422);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(151, 51);
            Enterbtn.TabIndex = 4;
            Enterbtn.Text = "دخول";
            Enterbtn.UseVisualStyleBackColor = false;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 254);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 2;
            label2.Text = "كلمة السر";
            // 
            // UserNameBox
            // 
            UserNameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameBox.Location = new Point(76, 140);
            UserNameBox.Multiline = true;
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(329, 38);
            UserNameBox.TabIndex = 1;
            UserNameBox.KeyDown += UserNameBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 97);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "إسم المستخدم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Police_Logo;
            pictureBox1.Location = new Point(750, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(773, 438);
            label5.Name = "label5";
            label5.Size = new Size(258, 36);
            label5.TabIndex = 12;
            label5.Text = "إدارة الحماية المدنية";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(749, 394);
            label4.Name = "label4";
            label4.Size = new Size(299, 36);
            label4.TabIndex = 11;
            label4.Text = "مديرية أمن البحر الاحمر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(810, 352);
            label3.Name = "label3";
            label3.Size = new Size(177, 36);
            label3.TabIndex = 10;
            label3.Text = "وزارة الداخلية";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(445, 26);
            label6.Name = "label6";
            label6.Size = new Size(332, 46);
            label6.TabIndex = 13;
            label6.Text = "تسجيل الدخول للبرنامج";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(750, 536);
            label8.Name = "label8";
            label8.Size = new Size(303, 41);
            label8.TabIndex = 15;
            label8.Text = "وحدة وقاية المنشأت";
            // 
            // ClosePhoto
            // 
            ClosePhoto.Image = (Image)resources.GetObject("ClosePhoto.Image");
            ClosePhoto.Location = new Point(1126, 9);
            ClosePhoto.Name = "ClosePhoto";
            ClosePhoto.Size = new Size(54, 51);
            ClosePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            ClosePhoto.TabIndex = 16;
            ClosePhoto.TabStop = false;
            ClosePhoto.Click += ClosePhoto_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1191, 741);
            Controls.Add(ClosePhoto);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "تسجيل الدخول";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClosePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox UserNameBox;
        private Label label1;
        private Button Resetbtn;
        private Button Enterbtn;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox Passwordbox;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label7;
        private PictureBox ClosePhoto;
    }
}