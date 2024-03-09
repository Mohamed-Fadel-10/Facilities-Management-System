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
    public partial class ExpiredLicenseForm : Form
    {
        private readonly Context context;
        private readonly PlaceService placeService;
        public ExpiredLicenseForm()
        {
            InitializeComponent();
            context = new Context();
            placeService = new PlaceService();
        }
        public string _Classification { get; set; }

        public string _Address { get; set; }



        private void ExpiredLicenseForm_Load(object sender, EventArgs e)
        {
            addreslbl.Text = _Address;
            classificationlbl.Text = _Classification;
            dataGridView1.AutoGenerateColumns = false;
            var query = placeService.License_Expire_Date(classificationlbl.Text, addreslbl.Text);
            dataGridView1.DataSource = query;
            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Code"].DataPropertyName = "Code";
            dataGridView1.Columns["Address"].DataPropertyName = "Address";
            dataGridView1.Columns["Licence_Start_Date"].DataPropertyName = "license_Start_Date";
            dataGridView1.Columns["Licence_End_Date"].DataPropertyName = "license_End_Date";
            dataGridView1.Columns["status"].DataPropertyName = "Status";
            dataGridView1.ClearSelection();

        }
    }
}
