Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_BaoCaoSachTheoNhaXuatBan
    Private con As SqlConnection
    Private cmd As SqlCommand

    Private Sub Frm_BaoCaoSachTheoNhaXuatBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1000, 607)
        Dim query As String = String.Empty

        query &= " select * from [tblsach],[tblTheLoaiSach],[tblTacGia]"
        query &= "where [tblSach].[MaTheLoaiSach] = [tblTheLoaiSach].[MaTheLoaiSach]"
        query &= " And [tblSach].[MaTacGia] =[tblTacGia].[MaTacGia]"
        con = New SqlConnection()
        cmd = New SqlCommand()
        con.ConnectionString = "Data Source =DESKTOP-PBD6FD7; Initial Catalog =QLTV;" + "Integrated Security = true"
        con.Open()
        cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query

        Dim adt As SqlDataAdapter
        adt = New SqlDataAdapter(cmd)
        Dim ds As DataSet
        ds = New DataSet("tblsach")
        adt.Fill(ds, "tblsach")
        Dim rptd As New ReportDocument
        rptd = New ReportDocument
        rptd.Load("CrystalReport2.rpt")
        rptd.SetDataSource(ds.Tables("tblsach"))
        CrystalReportViewer2.ReportSource = rptd
        CrystalReportViewer2.Zoom(100)
        CrystalReportViewer2.Refresh()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class