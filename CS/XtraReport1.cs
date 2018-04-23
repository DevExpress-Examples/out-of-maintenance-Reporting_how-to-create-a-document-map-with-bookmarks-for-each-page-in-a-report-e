using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace docBookmarks {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }


        // Set the label's text and bookmark (this label is located on the PageHeader
        // band, therefore it will show a bookmark for every report page).
        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            string s = "Page " + (e.PageIndex + 1).ToString();
            ((XRLabel)sender).Bookmark = s;
            ((XRLabel)sender).Text = s;
        }


    }
}
