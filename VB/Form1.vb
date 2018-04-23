Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ...

Namespace docBookmarks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report.
			Dim report As New XtraReport1()

			' Output the report.
			report.ShowPreview()
		End Sub
	End Class
End Namespace