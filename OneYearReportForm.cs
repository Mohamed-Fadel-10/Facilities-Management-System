using DataLayer.Models;
using DevExpress.CodeParser;
using license.services;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace license
{
	public partial class OneYearReportForm : Form
	{
		private readonly Context context;
		private readonly PlaceService placeService;

		public OneYearReportForm()
		{
			InitializeComponent();
			context = new Context();
			placeService = new PlaceService();
		}

		public string _Classification { get; set; }
		public string _Address { get; set; }

		private void OneYearReportForm_Load(object sender, EventArgs e)
		{
			addreslbl.Text = _Address;
			classificationlbl.Text = _Classification;
			dataGridView1.AutoGenerateColumns = false;
			if (string.IsNullOrEmpty(addreslbl.Text))
			{
				var query = placeService.AnnualReporting(classificationlbl.Text, null);
				dataGridView1.DataSource = query;
			}
			else if (addreslbl.Text != null)
			{
				var query = placeService.AnnualReporting(classificationlbl.Text, addreslbl.Text);
				dataGridView1.DataSource = query;
			}
			dataGridView1.Columns["Name"].DataPropertyName = "Name";
			dataGridView1.Columns["Code"].DataPropertyName = "Code";
			dataGridView1.Columns["Address"].DataPropertyName = "Address";
			dataGridView1.Columns["Licence_Start_Date"].DataPropertyName = "license_Start_Date";
			dataGridView1.Columns["Licence_End_Date"].DataPropertyName = "license_End_Date";
			dataGridView1.Columns["status"].DataPropertyName = "Status";
			dataGridView1.ClearSelection();

		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			// Ensure bmp is not null before using it
			DrawDataGridView(e.Graphics);
		}

		Bitmap bmp;

		private void DrawDataGridView(Graphics g)
		{
			if (dataGridView1.Rows.Count == 0)
				return;

			int rowHeight = dataGridView1.Rows[0].Height;
			int headerHeight = dataGridView1.ColumnHeadersHeight;

			int totalHeight = headerHeight + dataGridView1.Rows.Count * rowHeight;

			if (totalHeight > printDocument1.DefaultPageSettings.Bounds.Height)
			{
				MessageBox.Show("Content exceeds the page height. Please reduce the data to fit on one page.");
				return;
			}

			Bitmap bm = new Bitmap(dataGridView1.Width, totalHeight);
			dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, dataGridView1.Width, totalHeight));

			g.DrawImage(bm, new Point(0, 0));
		}




		private void DownloadPDF_Click(object sender, EventArgs e)
		{
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler((s, args) => DrawDataGridView(args.Graphics));

			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = pd;

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				pd.Print();
			}
		}

	}
}
