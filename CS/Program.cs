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
using System.Collections.Generic;
using System.Windows.Forms;

namespace docBookmarks {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}