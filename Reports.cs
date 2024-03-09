using builders_Project.Models;
using DataLayer.Models;
using license.services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace license
{
    public partial class Reports : Form
    {
        private readonly Context context;
        private readonly PlaceService service;
        public Reports()
        {
            InitializeComponent();
            context = new Context();
            service = new PlaceService();


        }

        private void oneYearbtn_Click(object sender, EventArgs e)
        {

            OneYearReportForm reportForm = new OneYearReportForm();

            clsssification selectedClassification = classificationBox.SelectedItem as clsssification;

            if (selectedClassification != null)
            {
                reportForm._Classification = selectedClassification.Name;
                reportForm._Address = AddressBox.Text;
                reportForm.Show();
            }
            else
            {
                MessageBox.Show("قم بإدخال التصنيف ");
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            classificationBox.DisplayMember = "Name";

            classificationBox.ValueMember = "Code";
            classificationBox.DataSource = context.clsssifications.ToList();
            AddressBox.DataSource = service.GetUniqueAddresses();


            OneYearReportForm reportForm = new OneYearReportForm();
            reportForm._Classification = classificationBox.SelectedItem.ToString();
            reportForm._Address = AddressBox.Text;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            AddressBox.SelectedIndex = -1;
            classificationBox.SelectedIndex = -1;


        }

        private void TowYearsbtn_Click(object sender, EventArgs e)
        {
            TwoYearsReportForm reportForm = new TwoYearsReportForm();

            clsssification selectedClassification = classificationBox.SelectedItem as clsssification;

            if (selectedClassification != null)
            {
                reportForm._Classification = selectedClassification.Name;
                reportForm._Address = AddressBox.Text;
                reportForm.Show();
            }
            else
            {
                MessageBox.Show("قم بإدخال التصنيف ");
            }

        }

        private void Monthbtn_Click(object sender, EventArgs e)
        {
            MonthToEndLicenseForm reportForm = new MonthToEndLicenseForm();
            clsssification selectedClassification = classificationBox.SelectedItem as clsssification;

            if (selectedClassification != null)
            {
                reportForm._Classification = selectedClassification.Name;
                reportForm._Address = AddressBox.Text;
                reportForm.Show();
            }
            else
            {
                MessageBox.Show("قم بإدخال التصنيف ");
            }
        }

        private void Expirebtn_Click(object sender, EventArgs e)
        {
            ExpiredLicenseForm reportForm = new ExpiredLicenseForm();
            clsssification selectedClassification = classificationBox.SelectedItem as clsssification;

            if (selectedClassification != null)
            {
                reportForm._Classification = selectedClassification.Name;
                reportForm._Address = AddressBox.Text;
                reportForm.Show();
            }
            else
            {
                MessageBox.Show("قم بإدخال التصنيف ");
            }
        }

        private void betweenTwoDatebtn_Click(object sender, EventArgs e)
        {
            TwoDatesForm reportForm = new TwoDatesForm();
            clsssification selectedClassification = classificationBox.SelectedItem as clsssification;

            if (selectedClassification != null)
            {
                reportForm._Classification = selectedClassification.Name;
                reportForm._Address = AddressBox.Text;
                reportForm.StartDate = DateTime.Parse(dateTimePicker1.Text);
                reportForm.EndDate = DateTime.Parse(dateTimePicker2.Text);
                reportForm.Show();

            }
            else
            {
                MessageBox.Show("قم بإدخال التصنيف ");
            }

        }



        private void Closeimg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pdf1btn_Click(object sender, EventArgs e)
        {
            PlaceService service = new PlaceService();

            List<Place> result = service.AnnualReporting(classificationBox.Text, AddressBox.Text);

            if (result.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "placess.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        XtraReport3 xtra = new XtraReport3(result);
                        xtra.ExportToPdf(pdfFilePath);

                        MessageBox.Show($"تم تنزيل الملف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenPdfFile(pdfFilePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void OpenPdfFile(string filePath)
        {
            try
            {
                // Use the default application associated with the PDF file extension
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle specific exception for access issues
                MessageBox.Show($"Error opening PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error opening PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pdf2btn_Click(object sender, EventArgs e)
        {
            PlaceService service = new PlaceService();

            List<Place> result = service.SecondReporting(classificationBox.Text, AddressBox.Text);

            if (result.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "placess.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        XtraReport3 xtra = new XtraReport3(result);
                        xtra.ExportToPdf(pdfFilePath);

                        MessageBox.Show($"تم تنزيل الملف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenPdfFile(pdfFilePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pdf3btn_Click(object sender, EventArgs e)
        {
            PlaceService service = new PlaceService();

            List<Place> result = service.Expire_Date_Reporting_Before_Month(classificationBox.Text, AddressBox.Text);

            if (result.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "placess.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        XtraReport3 xtra = new XtraReport3(result);
                        xtra.ExportToPdf(pdfFilePath);

                        MessageBox.Show($"تم تنزيل الملف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenPdfFile(pdfFilePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pdf4btn_Click(object sender, EventArgs e)
        {
            PlaceService service = new PlaceService();

            List<Place> result = service.License_Expire_Date(classificationBox.Text, AddressBox.Text);

            if (result.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "placess.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        XtraReport3 xtra = new XtraReport3(result);
                        xtra.ExportToPdf(pdfFilePath);

                        MessageBox.Show($"تم تنزيل الملف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenPdfFile(pdfFilePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pdf5btn_Click(object sender, EventArgs e)
        {
            PlaceService service = new PlaceService();

            List<Place> result = service.License_Expire_Between_Tow_Dates(classificationBox.Text, AddressBox.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));

            if (result.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "placess.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        XtraReport3 xtra = new XtraReport3(result);
                        xtra.ExportToPdf(pdfFilePath);

                        MessageBox.Show($"تم تنزيل الملف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenPdfFile(pdfFilePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
