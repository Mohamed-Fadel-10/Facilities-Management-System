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
    public partial class UpdateLicense : Form
    {
        private Context context;
        private Place place;
        public UpdateLicense()
        {
            InitializeComponent();
            context = new Context();
            place = new Place();
        }
        public string License_Name { get; set; }
        public string PlaceCode { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        private void UpdateLicense_Load(object sender, EventArgs e)
        {
            Namelbl.Text = License_Name;
            StartDateBox.Value = Start;
            EndDateBox.Value = End;
        }

        private void UpdateLicensebtn_Click(object sender, EventArgs e)
        {
            if (StartDateBox.Value == Start && EndDateBox.Value == End)
            {
                MessageBox.Show("يرجى تعديل التاريخ وتجديد الرخصة بتاريخ جديد", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                place = context.places.FirstOrDefault(p=>p.Code== PlaceCode);
                place.license_Start_Date = StartDateBox.Value;
                place.license_End_Date = EndDateBox.Value;
                context.SaveChanges();
                MessageBox.Show("تم تجديد الرخصة بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
