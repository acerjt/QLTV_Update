Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Frm_BaoCaoDanhSachDocGia

    Private con As SqlConnection
    Private cmd As SqlCommand




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(1000, 607)
        Dim query As String = String.Empty

        query &= " select [hovaten],CONVERT(date, [ngaysinh]) as[ngaysinh], [diachi],[diachi] from [tbldocgia],[tblloaidocgia]"
        query &= "where [tbldocgia].[maloaidocgia] = [tblloaidocgia].[maloaidocgia]"

        con = New SqlConnection()
        cmd = New SqlCommand()
        con.ConnectionString = "Data Source = DESKTOP-PBD6FD7; Initial Catalog =QLTV;" + "Integrated Security = true"
        con.Open()
        cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query

        Dim adt As SqlDataAdapter
        adt = New SqlDataAdapter(cmd)
        Dim ds As DataSet
        ds = New DataSet("tbldocgia")
        adt.Fill(ds, "tbldocgia")
        Dim rptd As New ReportDocument
        rptd = New ReportDocument
        rptd.Load("CrystalReport3.rpt")
        rptd.SetDataSource(ds.Tables("tbldocgia"))
        CrystalReportViewer3.ReportSource = rptd
        CrystalReportViewer3.Zoom(100)
        CrystalReportViewer3.Refresh()

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class