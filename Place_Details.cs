using builders_Project.Models;
using DataLayer.Models;
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

namespace license
{
	public partial class Place_Details : Form
	{
		private readonly Context context;
		private readonly PlaceService PlService;
		public Place_Details()
		{
			context = new Context();
			PlService = new PlaceService();
			InitializeComponent();
			StartDate.CustomFormat = "dd/MM/yyyy";
			EndDate.CustomFormat= "dd/MM/yyyy"; 

        }
		public void LoadData()
		{
			List<clsssification> clsssifications = context.clsssifications.ToList();
			ClassificationBox.DataSource = clsssifications;
			ClassificationBox.DisplayMember = "Name";

			ClassificationBox.ValueMember = "Code";
			ClassificationBox.SelectedIndex = -1;
			StatusBox.SelectedIndex = -1;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			var placeUniqueCode = context.places.FirstOrDefault(p => p.Code == CodeBox.Text);

			if (placeUniqueCode != null)
			{
				MessageBox.Show(" هذا الكود تمت اضافته المنشأة اخرى من قبل لا يمكن اضافته لهذه المنشأة");
			}
			else
			{
				DateTime any = new DateTime(2010, 1, 1);
				if (NameBox.Text == "" || AddressBox.Text == ""
					|| StartDate.Value == any || EndDate.Value == any ||
					TextBox.Text == null || ClassificationBox.SelectedIndex == -1 || StatusBox.SelectedIndex == -1)
				{
					Error.Visible = true;
				}
				else
				{
					Error.Visible = false;
					Place place = new Place();
					place.Name = NameBox.Text;
					place.Code = CodeBox.Text;
					place.Address = AddressBox.Text;
					place.license_Start_Date = StartDate.Value;
                    place.license_End_Date = EndDate.Value;
					place.Description = TextBox.Text;
					string x = ClassificationBox.SelectedItem.ToString();
					clsssification item = context.clsssifications.FirstOrDefault(c => c.Code == x);
					place.Classification_ID = item.Code;
					place.Status = StatusBox.SelectedItem.ToString();

					context.places.Add(place);
					context.SaveChanges();

					//place.Code = $"{place.classification.Code}-{place.ID}";
					context.SaveChanges();
					MessageBox.Show("تم إضافة منشأة بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();


				}
			}
		}

		private void Place_Details_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void Closeimg_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void NameBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				AddressBox.Focus();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void AddressBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				StartDate.Focus();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void EndDate_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ClassificationBox.Focus();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void StartDate_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				EndDate.Focus();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void EndDate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void ClassificationBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				StatusBox.Focus();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void StatusBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button2.PerformClick();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
	}
}
