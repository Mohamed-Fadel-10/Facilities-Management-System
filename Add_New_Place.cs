using builders_Project.Models;
using DataLayer.Models;
using license.Models;
using license.services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace license
{
    public partial class Add_New_Place : Form
    {
        private FileDocument Document;
        private Place place, pl;
        private PlaceService placeservice;
        private Context context;

        public string Code { get; set; }
        public string x;

        public Add_New_Place()
        {
            InitializeComponent();
            Load += Add_New_Place_Load_1;
            place = new Place();
            placeservice = new PlaceService();
            context = new Context();
            Document = new FileDocument();
        }

        private void LoadDocumentsDataGridView(Place place)
        {
            // Assuming documentListView is the name of your ListView
            FileView.Rows.Clear();
            FileView.Columns.Clear();

            // Add columns to display ID and Filename
            FileView.Columns.Add("FileName", "File Name");
            FileView.Columns.Add("Id", "ID");

            foreach (var document in place.Files)
            {
                object[] row = { document.FileName, document.Id };
                FileView.Rows.Add(row);
            }
        }

        private void Add_New_Place_Load_1(object sender, EventArgs e)
        {
            ClassificationBox.DataSource = context.clsssifications.ToList();
            ClassificationBox.DisplayMember = "Name";
            ClassificationBox.ValueMember = "Code";
            PlaceIDlbl.Text = Code;

           string PlaceCode = PlaceIDlbl.Text;
            place = placeservice.GetPlaceByCode(PlaceCode);
            pl = place;
            IDBox.Text = place.Code;
            NameBox.Text = place.Name;
            AddressBox.Text = place.Address;
            StartDateBox.Text = place.license_Start_Date.ToString();
            EndDateBox.Text = place.license_End_Date.ToString();
            LicenseDayesBox.Text = (place.license_End_Date - place.license_Start_Date).ToString();
             ClassificationBox.Text = place.classification.Name.ToString();
            StatusBox.Text = place.Status.ToString();
            PlaceNamelbl.Text = place.Name;

            NameBox.Enabled = false;
            AddressBox.Enabled = false;
            PlaceNamelbl.Enabled = false;
            LicenseDayesBox.Enabled = false;
            StartDateBox.Enabled = false;
            EndDateBox.Enabled = false;
            StatusBox.Enabled = false;
            ClassificationBox.Enabled = false;
            FileView.Enabled = false;
            Addbtn.Enabled = false;
            downloadFileBtn.Enabled = false;
            deletfilebtn.Enabled = false;
            var PlaceWithDocuments = context.places.Include(p => p.Files).FirstOrDefault(p => p.Code == PlaceCode);
            LoadDocumentsDataGridView(PlaceWithDocuments);
            FileView.AutoGenerateColumns = false;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            place = context.places.FirstOrDefault(p => p.Code == IDBox.Text);
            place.Name = NameBox.Text;
            place.Address = AddressBox.Text;
            place.Status = StatusBox.Text;
            place.classification = (clsssification)ClassificationBox.SelectedItem;
            place.Classification_ID = pl.classification.Code;
            place.Code = IDBox.Text;
            place.license_Start_Date = StartDateBox.Value;
            place.license_End_Date = EndDateBox.Value;
            context.SaveChanges();
            // context.Entry(place).State = EntityState.Modified;
            MessageBox.Show($"{place.Name}", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (place.Files != null && place.Files.Any())
                {
                    // Remove all associated files from the context
                    context.files.RemoveRange(place.Files);
                }

                // Detach the place from the context
                context.Entry(place).State = EntityState.Detached;

                // Fetch the place again using its ID
                var placeToDelete = context.places.Find(place.ID);

                if (placeToDelete != null)
                {
                    // Remove the place from the context
                    context.places.Remove(placeToDelete);

                    // Save changes to the database
                    context.SaveChanges();

                    MessageBox.Show("تم حذف المنشأة بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"لم يتم العثور على المنشأة برقم {place.ID}", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting the place: {ex.Message}", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            AddressBox.Enabled = true;
            PlaceNamelbl.Enabled = true;
            LicenseDayesBox.Enabled = true;
            StartDateBox.Enabled = true;
            EndDateBox.Enabled = true;
            StatusBox.Enabled = true;
            ClassificationBox.Enabled = true;
            FileView.Enabled = true;
            Addbtn.Enabled = true;
            downloadFileBtn.Enabled = true;
            deletfilebtn.Enabled = true;
            x = ClassificationBox.Text;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select files to upload";
                openFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.doc;*.docx|All Files|*.*";
                openFileDialog.Multiselect = true;
                var place = context.places.Include(p => p.Files).FirstOrDefault(p => p.Code == IDBox.Text);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var uploadedFiles = openFileDialog.FileNames
                        .Where(filePath => IsFileExtensionValid(filePath))
                        .Select(filePath => new license.Models.FileDocument
                        {
                            FileName = Path.GetFileName(filePath),
                            Content = File.ReadAllBytes(filePath),
                            PlaceId = place.ID
                        });

                    foreach (var uploadedFile in uploadedFiles)
                    {
                        context.files.Add(uploadedFile);
                    }

                    context.SaveChanges();
                    LoadDocumentsDataGridView(place);
                }
            }
        }

        private bool IsFileExtensionValid(string filePath)
        {
            // Check if the file extension is valid (only PDF and Word files allowed)
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".pdf" || extension == ".doc" || extension == ".docx";
        }

        private void deletfilebtn_Click(object sender, EventArgs e)
        {
            if (FileView.Rows.Count > 0 && FileView.SelectedCells.Count > 0)
            {
                int rowIndex = FileView.SelectedCells[0].RowIndex;

                if (rowIndex >= 0 && rowIndex < FileView.Rows.Count)
                {
                    var cellValue = FileView.Rows[rowIndex].Cells["Id"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int fileId))
                    {
                        var doc = context.files.FirstOrDefault(f => f.Id == fileId);

                        if (doc != null)
                        {
                            FileView.Rows.RemoveAt(rowIndex);

                            // Additional null checks before removing the document
                            if (context != null && context.files != null)
                            {
                                context.files.Remove(doc);
                                context.SaveChanges();
                                MessageBox.Show("تم حذف الملف بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("فشل في حذف الملف بسبب خطأ في قاعدة البيانات", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"لم يتم العثور على ملف برقم {fileId}", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى تحديد خلية صحيحة للحذف", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("يرجى تحديد خلية صحيحة للحذف", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد مرفقات لهذه المنشأة", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void downloadFileBtn_Click(object sender, EventArgs e)
        {
            if (FileView.Rows.Count > 0 && FileView.SelectedCells.Count > 0)
            {
                int rowIndex = FileView.SelectedCells[0].RowIndex;

                if (rowIndex >= 0 && rowIndex < FileView.Rows.Count)
                {
                    var cellValue = FileView.Rows[rowIndex].Cells["Id"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int fileId))
                    {
                        var selectedFile = context.files.FirstOrDefault(f => f.Id == fileId);

                        if (selectedFile != null)
                        {
                            // Download and open the selected file
                            DownloadAndOpenFile(selectedFile);
                        }
                        else
                        {
                            MessageBox.Show($"File with ID {fileId} not found", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى تحديد خلية صحيحة للتنزيل", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("يرجى تحديد خلية صحيحة للتنزيل", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد مرفقات لهذه المنشأة", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DownloadAndOpenFile(FileDocument file)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = file.FileName,
                Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx",
                Title = "Save File As"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string downloadPath = saveFileDialog.FileName;

                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = downloadPath,
                        UseShellExecute = true
                    };

                    File.WriteAllBytes(downloadPath, file.Content);

                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error downloading and opening the file: {ex.Message}", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        private void UpdateLicensebtn_Click(object sender, EventArgs e)
        {
            UpdateLicense updateLicense = new UpdateLicense();
            updateLicense.PlaceCode = IDBox.Text;
            updateLicense.License_Name = NameBox.Text;
            updateLicense.Start = StartDateBox.Value;
            updateLicense.End = EndDateBox.Value;

            updateLicense.Show();
            this.Close();
        }
    }
}
