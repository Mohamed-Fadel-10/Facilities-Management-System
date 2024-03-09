using license.Models;
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
	public partial class User_Form_Dashboard : Form
	{
		public User_Form_Dashboard()
		{
			InitializeComponent();
			usernamelogin.Text = UserLog_in_Data.usernamelogin;

		}

		private void Searchlbl_Click(object sender, EventArgs e)
		{
			Search search = new Search();
			search.Show();
		}

		private void Reportslbl_Click(object sender, EventArgs e)
		{
			Reports reports = new Reports();
			reports.Show();
		}

		private void changePasswordlbl_Click(object sender, EventArgs e)
		{
			Update_User_Data_Password update_User = new Update_User_Data_Password();
			update_User.Show();
		}

		private void Closeimg_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Exitebtn_Click(object sender, EventArgs e)
		{
			RegisterForm register = new RegisterForm();
			this.Close();
			register.Show();
		}

		private void ChangeShiftbtn_Click(object sender, EventArgs e)
		{
			RegisterForm register = new RegisterForm();
			this.Close();
			register.Show();
		}
	}
}
