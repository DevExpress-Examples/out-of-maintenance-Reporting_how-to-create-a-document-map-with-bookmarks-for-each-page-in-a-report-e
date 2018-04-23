// Developer Express Code Central Example:
// How to create a Document Map with bookmarks for each page in a report
// 
// The following example demonstrates how to create a Document Map with bookmarks
// (http://www.devexpress.com/Help/Content.aspx?help=XtraReports&document=CustomDocument2603.htm)
// for each page in a report.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E54

using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace docBookmarks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}