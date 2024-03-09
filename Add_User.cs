using builders_Project.Models;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace license
{
	public partial class Add_User : Form
	{
		private readonly Context context;
		private readonly User user;
		public Add_User()
		{
			InitializeComponent();
			context = new Context();
			user = new User();
		}

		private void Addbtn_Click(object sender, EventArgs e)
		{
			string userName = UserNameBox.Text.Trim();

			if (context.users.Any(p => p.UserName == userName))
			{
				MessageBox.Show("اسم المستخدم موجود بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(PhoneBox.Text) || string.IsNullOrEmpty(userName) ||
				string.IsNullOrEmpty(PasswordBox.Text) || RoleBox.SelectedIndex == -1 || ShiftBox.SelectedIndex == -1)
			{
				Error.Visible = true;
				return;
			}

			Error.Visible = false;

			User user = new User
			{
				Name = NameBox.Text,
				Phone = PhoneBox.Text,
				UserName = userName,
				Password = PasswordBox.Text,
				Role = RoleBox.Text,
				Shift = ShiftBox.Text
			};

			context.users.Add(user);
			context.SaveChanges();

			MessageBox.Show("تم إضافة المستخدم بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Closeimg_Click(object sender, EventArgs e)
		{

			this.Close();
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
				UserNameBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void UserNameBox_KeyDown(object sender, KeyEventArgs e)
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
				Addbtn.PerformClick();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
	}
}
