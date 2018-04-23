using System;
using DevExpress.XtraReports.UI;
// ...

namespace docBookmarks {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            // Obtain the current page number.
            string s = (e.PageIndex + 1).ToString();

            // Set the label's text and bookmark (this label is located on the PageHeader
            // band, therefore it will show a bookmark for every report page).
            ((XRLabel)sender).Bookmark += s;
            ((XRLabel)sender).Text += s;
        }

    }
}
