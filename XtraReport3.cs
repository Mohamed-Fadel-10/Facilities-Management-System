using builders_Project.Models;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace license
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport3(IEnumerable<Place> Data)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = Data;
            
            //this.DataMember = Data;
            DataSource = Data;
        }
    }
}
