using builders_Project.Models;
using DataLayer.Models;
using license.Models;
using license.services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User = builders_Project.Models.User;

namespace license
{
	public partial class Update_User_Data_Password : Form
	{
		private UserService userService;
		private Context context;
		private User usr;

		public Update_User_Data_Password()
		{
			InitializeComponent();
			usernameloginlbl.Text = UserLog_in_Data.usernamelogin;
			userService = new UserService();
			context = new Context();
			usr = new User();
		}

		private void Searchbtn_Click(object sender, EventArgs e)
		{
			if (SearchBox.Text != "")
			{

				User user = context.users.FirstOrDefault(p => p.UserName == SearchBox.Text);
				if (user != null)
				{
					NameBox.Text = user.Name;
					PhoneBox.Text = user.Phone;
					UsernameBox.Text = user.UserName;
					PasswordBox.Text = user.Password;
					ShiftBox.Text = user.Shift;
					RoleBox.Text = user.Role;
				}
				else
				{
					MessageBox.Show("اسم االمستخدم غير موجود", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

				}

			}
			else if (SearchBox.Text == "")
			{
				MessageBox.Show("ادخل اسم المستخدم للبحث", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}

		}

		private void Update_User_Data_Password_Load(object sender, EventArgs e)
		{
			string UserName = usernameloginlbl.Text;

			User user = (User)userService.Get_User(UserName);
			string Shift = user.Shift;
			if (user.Role == "User")
			{
				Searchbtn.Enabled = false;
				SearchBox.Enabled = false;

			}

			if (user != null)
			{
				NameBox.Text = user.Name;
				PhoneBox.Text = user.Phone;
				UsernameBox.Text = usernameloginlbl.Text;
				PasswordBox.Text = user.Password;
				ShiftBox.Text = Shift;
				RoleBox.Text = user.Role;

				if (string.IsNullOrWhiteSpace(user.Name))
				{
					MessageBox.Show("الرجاء إدخال اسم صحيح", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

			}
			else
			{
				MessageBox.Show("المستخدم غير موجود", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Closeimg_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Savebtn_Click(object sender, EventArgs e)
		{
			User user1 = context.users.FirstOrDefault(p => p.UserName == UsernameBox.Text);


			if (user1 != null)
			{
				user1.Name = NameBox.Text;
				user1.Phone = PhoneBox.Text;
				user1.Password = PasswordBox.Text;
				user1.UserName = UsernameBox.Text;
				user1.Shift = ShiftBox.Text;
				user1.Role = RoleBox.Text;

				context.SaveChanges();

				MessageBox.Show("تم التعديل بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("حدث خطأ يرجى إعادة المحاولة", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{

			User user = (User)context.users.FirstOrDefault(p => p.UserName == UsernameBox.Text);

			if (usernameloginlbl.Text == UsernameBox.Text || usernameloginlbl.Text == SearchBox.Text)
			{
				MessageBox.Show("لا يمكنك حذف هذا الايميل لانك تستخدمه الان", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else
			{
				context.users.Remove(user);
				context.SaveChanges();
				MessageBox.Show("تم الحذف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
				clear();
			}
		}
		public void clear()
		{
			NameBox.Clear();
			PhoneBox.Clear();
			UsernameBox.Clear();
			PasswordBox.Clear();
			ShiftBox.SelectedIndex = -1;
			RoleBox.SelectedIndex = -1;

		}

		private void SearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Searchbtn.PerformClick();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void NameBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				PhoneBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void PhoneBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				UsernameBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void UsernameBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				PasswordBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ShiftBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void ShiftBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				RoleBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void RoleBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Savebtn.PerformClick();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
	}
}

