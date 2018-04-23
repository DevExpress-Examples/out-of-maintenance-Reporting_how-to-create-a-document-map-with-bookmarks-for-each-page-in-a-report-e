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
using DevExpress.XtraReports.UI;
// ...

namespace docBookmarks {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel3_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            // Obtain the current page number.
            string s = (e.PageIndex + 1).ToString();

            // Set the label's text and bookmark (this label is located on the PageHeader
            // band, therefore it will show a bookmark for every report page).
            ((XRLabel)sender).Bookmark += s;
            ((XRLabel)sender).Text += s;
        }
    }
}
