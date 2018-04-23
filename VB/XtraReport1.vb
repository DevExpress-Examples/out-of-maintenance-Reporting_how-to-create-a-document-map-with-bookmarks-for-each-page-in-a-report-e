Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace docBookmarks
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel2_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel2.PrintOnPage
			' Obtain the current page number.
			Dim s As String = (e.PageIndex + 1).ToString()

			' Set the label's text and bookmark (this label is located on the PageHeader
			' band, therefore it will show a bookmark for every report page).
			CType(sender, XRLabel).Bookmark += s
			CType(sender, XRLabel).Text += s
		End Sub

	End Class
End Namespace
