<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BaoCaoDanhSachDocGia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(658, 70)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Báo cáo Danh Sách Độc Giả"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(7, 61)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1408, 51)
        Me.BunifuSeparator1.TabIndex = 151
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = -1
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(74, 120)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(1324, 909)
        Me.CrystalReportViewer3.TabIndex = 148
        Me.CrystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1359, 18)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 149
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Frm_BaoCaoDanhSachDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1467, 1055)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.CrystalReportViewer3)
        Me.Controls.Add(Me.Btn_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_BaoCaoDanhSachDocGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_BaoCaoDanhSachDocGia"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
End Class
