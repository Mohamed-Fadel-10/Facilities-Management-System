using builders_Project.Models;
using DataLayer.Models;
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
	public partial class Add_Classification : Form
	{
		private readonly Context context;
		public Add_Classification()
		{
			InitializeComponent();
			context = new Context();

		}

		private void Addbtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(CodeBox.Text) || string.IsNullOrWhiteSpace(NameBox.Text))
				{
					errorelbl.Visible = true;
				}
				else
				{
					errorelbl.Visible = false;

					if (context.clsssifications.Any(c => c.Code == CodeBox.Text))
					{
						MessageBox.Show("هذا الكود تم استخدامه من قبل", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						clsssification clsssification = new clsssification();
						clsssification.Name = NameBox.Text;
						clsssification.Code = CodeBox.Text;
						context.clsssifications.Add(clsssification);
						context.SaveChanges();
						MessageBox.Show("تم إضافة التصنيف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("حدث خطأ غير متوقع يرجى إعادة فتح هذه الصفحة والمحاولة مرة اخرى", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Closeimg_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CodeBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				NameBox.Focus();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void NameBox_KeyDown(object sender, KeyEventArgs e)
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
