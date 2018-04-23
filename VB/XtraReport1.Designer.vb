Imports Microsoft.VisualBasic
Imports System
Namespace docBookmarks
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.nwindDataSet1 = New docBookmarks.nwindDataSet()
			Me.productsTableAdapter = New docBookmarks.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
			Me.Detail.HeightF = 42F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(215))))))
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrLabel3.Font = New System.Drawing.Font("Arial", 12F)
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(458F, 42F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "xrLabel1"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.PageHeader.HeightF = 42F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel2.Bookmark = "Name "
			Me.xrLabel2.BookmarkParent = Me.xrLabel1
			Me.xrLabel2.Font = New System.Drawing.Font("Arial", 14F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(458F, 42F)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "Page "
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
'			Me.xrLabel2.PrintOnPage += New DevExpress.XtraReports.UI.PrintOnPageEventHandler(Me.xrLabel2_PrintOnPage);
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
			Me.xrLabel1.Bookmark = "Home"
			Me.xrLabel1.Font = New System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(458F, 42F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Home"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 42F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 49F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 49F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.Bookmark = "Table of Contents"
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Margins = New System.Drawing.Printing.Margins(50, 100, 49, 49)
			Me.Version = "9.3"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As docBookmarks.nwindDataSetTableAdapters.ProductsTableAdapter
		Public xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Public WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Public xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
