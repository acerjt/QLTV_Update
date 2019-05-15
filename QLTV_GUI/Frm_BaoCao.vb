Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Frm_BaoCao
    Private con As SqlConnection
    Private cmd As SqlCommand

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim query As String = String.Empty

        query &= " select [tensach],[ngaymuon],DATEDIFF ( day , [ngaydukientra] , [ngaytra] ) as [Songaytratre], month([ngaytra]) as [thang], year([ngaytra]) as [nam]"
        query &= " from [tblChiTietPhieuTraSach],[tblPhieuTraSach],[tblSach],[tblPhieuMuonSach]"
        query &= " where [tblChiTietPhieuTraSach].[maphieutrasach]=[tblPhieuTraSach].[maphieutrasach]"
        query &= " and [tblSach].[MaSach]=[tblChiTietPhieuTraSach].[masach]"
        query &= " and [tblChiTietPhieuTraSach].[MaPhieuMuonSach]=[tblPhieuMuonSach].[maphieumuonsach]"
        query &= " And [tblChiTietPhieuTraSach].[tinhtrang] Like N'%Trả Trễ%'"
        query &= " And year([ngaytra])=@Nam"
        query &= " And month([ngaytra])=@Thang"

        con = New SqlConnection()
        cmd = New SqlCommand()
        con.ConnectionString = "Data Source = DESKTOP-PBD6FD7; Initial Catalog =QLTV;" + "Integrated Security = true"
        con.Open()
        cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@Thang", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Nam", TextBox2.Text)

        Dim adt As SqlDataAdapter
        adt = New SqlDataAdapter(cmd)
        Dim ds As DataSet
        ds = New DataSet("tblsachtratre")
        adt.Fill(ds, "tblsachtratre")
        Dim rptd As New ReportDocument
        rptd = New ReportDocument
        rptd.Load("CrystalReport1.rpt")
        rptd.SetDataSource(ds.Tables("tblsachtratre"))
        CrystalReportViewer1.ReportSource = rptd
        CrystalReportViewer1.Zoom(75)
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Frm_BaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(900, 607)
    End Sub
End Class