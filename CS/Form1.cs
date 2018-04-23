using System;
using System.Windows.Forms;
// ...

namespace docBookmarks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Output the report.
            report.ShowPreview();
        }
    }
}