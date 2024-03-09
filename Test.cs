using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib.Graphic;
using builders_Project.Models;
using DataLayer.Models;
using iTextSharp.text.pdf;
using license.services;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using PdfDocument = Syncfusion.Pdf.PdfDocument;
using PdfPage = Syncfusion.Pdf.PdfPage;
using PdfGraphics = Syncfusion.Pdf.Graphics.PdfGraphics;
using PdfFont = Syncfusion.Pdf.Graphics.PdfFont;
using System.Diagnostics;
using Path = System.IO.Path;
using iText.Layout.Element;
using iText.Layout;

namespace license
{
    public partial class Test : Form
    {
        private Context context;
        private Place place;
        PlaceService placeService;
        public Test()
        {
            InitializeComponent();
            context = new Context();
            place = new Place();
            placeService = new PlaceService();
            sfDataGrid1.AutoGenerateColumns = false;


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            List<Place> places = context.places.ToList();
            sfDataGrid1.DataSource = places;

        }

        private void Test_Load(object sender, EventArgs e)
        {
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ID", HeaderText = "كود المنشأة" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Name", HeaderText = "ألاسم" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "license_Start_Date", HeaderText = "تاريخ المعاينة" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "license_End_Date", HeaderText = "تاريخ إنتهاء المعاينة" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Address", HeaderText = "العنوان" });

            List<Place> places = context.places
                .Select(p => new Place
                {
                    ID = p.ID,
                    Name = p.Name,
                    license_Start_Date = p.license_Start_Date,
                    license_End_Date = p.license_End_Date,
                    Address = p.Address
                })
                .ToList();
            sfDataGrid1.DataSource = places;
        }


    }
}





