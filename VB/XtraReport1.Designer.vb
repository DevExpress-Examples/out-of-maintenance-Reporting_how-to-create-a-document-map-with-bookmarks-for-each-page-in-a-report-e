<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.NwindDataSet1 = New docBookmarks.nwindDataSet
        Me.ProductsTableAdapter = New docBookmarks.nwindDataSetTableAdapters.ProductsTableAdapter
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3})
        Me.Detail.Height = 42
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
        Me.PageHeader.Height = 42
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.ReportHeader.Height = 42
        Me.ReportHeader.Name = "ReportHeader"
        '
        'NwindDataSet1
        '
        Me.NwindDataSet1.DataSetName = "nwindDataSet"
        Me.NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.xrLabel1.Bookmark = "Home"
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.xrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.Size = New System.Drawing.Size(458, 42)
        Me.xrLabel1.Text = "Home"
        '
        'xrLabel2
        '
        Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xrLabel2.BookmarkParent = Me.xrLabel1
        Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.xrLabel2.Location = New System.Drawing.Point(0, 0)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.Size = New System.Drawing.Size(458, 42)
        Me.xrLabel2.Text = "xrLabel2"
        '
        'xrLabel3
        '
        Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
        Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.xrLabel3.Location = New System.Drawing.Point(0, 0)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.Size = New System.Drawing.Size(458, 42)
        Me.xrLabel3.Text = "xrLabel1"
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.ReportHeader})
        Me.DataAdapter = Me.ProductsTableAdapter
        Me.DataMember = "Products"
        Me.DataSource = Me.NwindDataSet1
        Me.Version = "8.1"
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents NwindDataSet1 As docBookmarks.nwindDataSet
    Friend WithEvents ProductsTableAdapter As docBookmarks.nwindDataSetTableAdapters.ProductsTableAdapter
    Public WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
