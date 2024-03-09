using builders_Project.Models;
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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace license
{
	public partial class Search : Form
	{
		private PlaceService service;
		private Place Place;
		private Context context;
		public Search()
		{
			InitializeComponent();
			service = new PlaceService();
			Place = new Place();
			context = new Context();

		}
		public void LoadData()
		{
			PlacesData.AutoGenerateColumns = false;
			List<Place> places = context.places.ToList();
			DateTime dateTime = DateTime.Now;

			string wordToAdd = "سارى";

			int columnIndex = PlacesData.Columns["Expire_notExpire"].Index;

			foreach (DataGridViewRow row in PlacesData.Rows)
			{
				if (row.Cells["Expire_notExpire"].Value != null)
				{
					row.Cells["Expire_notExpire"].Value = wordToAdd;
				}
			}




			PlacesData.DataSource = places;
			List<clsssification> clsssifications = context.clsssifications.ToList();
			ClassificatioBox.DataSource = clsssifications;
			ClassificatioBox.DisplayMember = "Name";

			ClassificatioBox.ValueMember = "Code";
			ClassificatioBox.SelectedIndex = -1;
			StatusBox.SelectedIndex = -1;
		}
		private void PopulateDataGridView()
		{
			Place P = service.GetPlaceByCode(PlacesData.Columns["ID"].ToString());
			PlacesData.AutoGenerateColumns = false;
			PlacesData.Columns["Name"].DataPropertyName = "Name";
			PlacesData.Columns["Expire_notExpire"].DataPropertyName = "Expired";
			PlacesData.Columns["Start_Date"].DataPropertyName = "license_Start_Date";
			PlacesData.Columns["End_Date"].DataPropertyName = "license_End_Date";
			PlacesData.Columns["Classification"].DataPropertyName = "classification";
            PlacesData.Columns["Address"].DataPropertyName = "Address";
			PlacesData.Columns["Status"].DataPropertyName = "Status";
			PlacesData.Columns["ID"].DataPropertyName = "Code";

		}


		private void Search_Load(object sender, EventArgs e)
		{
			LoadData();
			PopulateDataGridView();
		}

		private void CLoseimg_Click(object sender, EventArgs e)
		{

			this.Hide();
		}



		private void Searchbtn_Click(object sender, EventArgs e)
		{
			Place items;
			List<Place> query;
			if (ClassificatioBox.SelectedIndex == -1 && StatusBox.SelectedIndex != -1)
			{
				query = context.places.Include(p => p.classification).Where(p => p.Status == StatusBox.SelectedItem).ToList();
				PlacesData.DataSource = query;

			}
			else if (ClassificatioBox.SelectedIndex != -1 && StatusBox.SelectedIndex == -1)
			{
				query = context.places.Include(p => p.classification)
				   .Where(p => p.Classification_ID == ClassificatioBox.SelectedItem.ToString()).ToList();
				PlacesData.DataSource = query;
			}
			else if (ClassificatioBox.SelectedIndex != -1 && StatusBox.SelectedIndex != -1)
			{
				query = context.places.Include(p => p.classification)
				   .Where(p => p.Status == StatusBox.SelectedItem &&
			   p.Classification_ID == ClassificatioBox.SelectedItem.ToString()).ToList();
				PlacesData.DataSource = query;
			}





		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (NameSearchBox.Text == "" && CodeSearchBox.Text != "")
			{
				var item = context.places.Include(p => p.classification).Where(p => p.Code == CodeSearchBox.Text).FirstOrDefault();
				PlacesData.DataSource = new List<Place> { item };

			}
			else if (CodeSearchBox.Text == "" && NameSearchBox.Text != "")
			{
				var items = context.places.Include(p => p.classification)
										   .Where(p => p.Name.Contains(NameSearchBox.Text))
										   .ToList();

				PlacesData.DataSource = items;
			}

		}

		private void PlacesData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < PlacesData.Rows.Count)
			{
				string code = PlacesData.Rows[e.RowIndex].Cells["ID"].Value.ToString();

				Add_New_Place plc = new Add_New_Place();
				plc.Code = code;
				plc.Show();
			}
		}

		private void NameSearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1.PerformClick();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void CodeSearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1.PerformClick();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
	}
}
