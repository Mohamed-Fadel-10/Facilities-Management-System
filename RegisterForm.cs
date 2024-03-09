using builders_Project.Models;
using license.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using license.services;
using license.Models;


namespace license
{
    public partial class RegisterForm : Form
    {
        private UserService service;
        private User user;
        public RegisterForm()
        {
            InitializeComponent();
            service = new UserService();
            user = new User();


        }


        private void Enterbtn_Click(object sender, EventArgs e)
        {
            UserLog_in_Data.usernamelogin = UserNameBox.Text;
            string username = UserNameBox.Text;
            string password = Passwordbox.Text;

            // Note: Make sure to await the asynchronous operation
            User user = service.Get_User(username);

            if (UserNameBox.Text == "Admin".ToLower() || UserNameBox.Text == "admin".ToLower() && Passwordbox.Text == "Admin".ToLower() || Passwordbox.Text == "admin".ToLower())
            {
                AdminFormDashboard adminForm = new AdminFormDashboard();
                adminForm.Show();
                this.Hide();
            }

			else if (user == null)
            {
                MessageBox.Show("إسم المستخدم غير موجود ", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                UserNameBox.Clear();
            }

            else
            {
                if (user.UserName == username && user.Password == password)
                {
                    if (user.Role == "Admin")
                    {
                        AdminFormDashboard adminForm = new AdminFormDashboard();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (user.Role == "User")
                    {
                        User_Form_Dashboard userDashboard = new User_Form_Dashboard();
                        userDashboard.Show();
                        this.Hide();
                    }
                }
                else if (user.Password != password)
                {
                    MessageBox.Show("كلمة المرور خاطئة يرجى إعادة المحاولة ", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Passwordbox.Clear();
                }
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            clear();

        }

        public void clear()
        {
            UserNameBox.Clear();
            Passwordbox.Clear();

        }

        private void Passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enterbtn.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void UserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Passwordbox.Focus();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ClosePhoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
