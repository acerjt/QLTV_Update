<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_BaoCao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BaoCao))
        Me.TextBox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.TextBox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.button1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(266, 112)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.MaximumSize = New System.Drawing.Size(282, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 44)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.BorderColor = System.Drawing.Color.SeaGreen
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(660, 112)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.MaximumSize = New System.Drawing.Size(282, 44)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(228, 44)
        Me.TextBox2.TabIndex = 4
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(106, 204)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1164, 765)
        Me.CrystalReportViewer1.TabIndex = 6
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1273, 11)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 39
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(2, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(831, 70)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Báo Cáo Sách Trả Trễ Theo Thể Loại"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-3, 58)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1341, 51)
        Me.BunifuSeparator1.TabIndex = 138
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(135, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 42)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Tháng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(561, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 42)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Năm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'button1
        '
        Me.button1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.button1.BackColor = System.Drawing.Color.SeaGreen
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.BorderRadius = 7
        Me.button1.ButtonText = "Lập Báo Cáo"
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.DisabledColor = System.Drawing.Color.Gray
        Me.button1.Iconcolor = System.Drawing.Color.Transparent
        Me.button1.Iconimage = CType(resources.GetObject("button1.Iconimage"), System.Drawing.Image)
        Me.button1.Iconimage_right = Nothing
        Me.button1.Iconimage_right_Selected = Nothing
        Me.button1.Iconimage_Selected = Nothing
        Me.button1.IconMarginLeft = 0
        Me.button1.IconMarginRight = 0
        Me.button1.IconRightVisible = True
        Me.button1.IconRightZoom = 0R
        Me.button1.IconVisible = False
        Me.button1.IconZoom = 90.0R
        Me.button1.IsTab = False
        Me.button1.Location = New System.Drawing.Point(974, 104)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button1.Name = "button1"
        Me.button1.Normalcolor = System.Drawing.Color.SeaGreen
        Me.button1.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.button1.OnHoverTextColor = System.Drawing.Color.White
        Me.button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button1.selected = False
        Me.button1.Size = New System.Drawing.Size(310, 52)
        Me.button1.TabIndex = 135
        Me.button1.Text = "Lập Báo Cáo"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.button1.Textcolor = System.Drawing.Color.White
        Me.button1.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Frm_BaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1367, 1001)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_BaoCao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_BaoCao"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents TextBox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents button1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
