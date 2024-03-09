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
    public partial class TwoDatesForm : Form
    {
        private readonly Context context;
        private readonly PlaceService placeService;
        public TwoDatesForm()
        {
            InitializeComponent();
            context = new Context();
            placeService = new PlaceService();
        }
        public string _Classification { get; set; }

        public string _Address { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



        private void TwoDatesForm_Load(object sender, EventArgs e)
        {
            Start.Value = DateTime.Now;
            End.Value = DateTime.Now;

            addreslbl.Text = _Address;
            classificationlbl.Text = _Classification;
            Start.Value = StartDate;
            End.Value = EndDate;
            dataGridView1.AutoGenerateColumns = false;
            if (addreslbl.Text == null)
            {
                var query = placeService.License_Expire_Between_Tow_Dates(classificationlbl.Text, null, Start.Value, End.Value);
                dataGridView1.DataSource = query;
            }
            else if (addreslbl.Text != null)
            {
                var query = placeService.License_Expire_Between_Tow_Dates(classificationlbl.Text, addreslbl.Text, Start.Value, End.Value);
                dataGridView1.DataSource = query;
            }

            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Code"].DataPropertyName = "Code";
            dataGridView1.Columns["Address"].DataPropertyName = "Address";
            dataGridView1.Columns["Licence_Start_Date"].DataPropertyName = "license_Start_Date";
            dataGridView1.Columns["Licence_End_Date"].DataPropertyName = "license_End_Date";
            dataGridView1.Columns["status"].DataPropertyName = "Status";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
