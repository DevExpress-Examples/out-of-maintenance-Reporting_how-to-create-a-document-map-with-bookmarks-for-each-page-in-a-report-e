Imports DevExpress.XtraReports.UI

Public Class XtraReport1

    ' Set the label's text and bookmark (this label is located on the PageHeader
    ' band, therefore it will show a bookmark for every report page).
    Private Sub xrLabel2_PrintOnPage(ByVal sender As System.Object, ByVal e As PrintOnPageEventArgs) _
    Handles xrLabel2.PrintOnPage
        Dim s As String = "Page " + (e.PageIndex + 1).ToString()
        CType(sender, XRLabel).Bookmark = s
        CType(sender, XRLabel).Text = s
    End Sub

End Class