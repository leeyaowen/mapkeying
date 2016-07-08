<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mapkeying
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.xlab = New System.Windows.Forms.Label()
        Me.ylab = New System.Windows.Forms.Label()
        Me.sptag = New System.Windows.Forms.TextBox()
        Me.taginput = New System.Windows.Forms.Label()
        Me.y1 = New System.Windows.Forms.TextBox()
        Me.plotinput = New System.Windows.Forms.Label()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.y2 = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.TextBox()
        Me.gotoplot = New System.Windows.Forms.Button()
        Me.n = New System.Windows.Forms.TextBox()
        Me.m = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.newdtbox = New System.Windows.Forms.GroupBox()
        Me.newconfirm = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newdbh = New System.Windows.Forms.TextBox()
        Me.newsp = New System.Windows.Forms.TextBox()
        Me.newtag = New System.Windows.Forms.TextBox()
        Me.newy2 = New System.Windows.Forms.TextBox()
        Me.newx2 = New System.Windows.Forms.TextBox()
        Me.newy1 = New System.Windows.Forms.TextBox()
        Me.newx1 = New System.Windows.Forms.TextBox()
        Me.newdt = New System.Windows.Forms.Button()
        Me.deletedt = New System.Windows.Forms.Button()
        Me.deletedtbox = New System.Windows.Forms.GroupBox()
        Me.deleteconfirm = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.deletetag = New System.Windows.Forms.TextBox()
        Me.plotdataview = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newdtbox.SuspendLayout()
        Me.deletedtbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'xlab
        '
        Me.xlab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xlab.Location = New System.Drawing.Point(966, 579)
        Me.xlab.Name = "xlab"
        Me.xlab.Size = New System.Drawing.Size(50, 23)
        Me.xlab.TabIndex = 0
        Me.xlab.Text = "X"
        Me.xlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ylab
        '
        Me.ylab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ylab.Location = New System.Drawing.Point(1022, 579)
        Me.ylab.Name = "ylab"
        Me.ylab.Size = New System.Drawing.Size(50, 23)
        Me.ylab.TabIndex = 1
        Me.ylab.Text = "Y"
        Me.ylab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sptag
        '
        Me.sptag.Location = New System.Drawing.Point(650, 197)
        Me.sptag.Name = "sptag"
        Me.sptag.Size = New System.Drawing.Size(100, 22)
        Me.sptag.TabIndex = 20
        '
        'taginput
        '
        Me.taginput.Location = New System.Drawing.Point(650, 171)
        Me.taginput.Name = "taginput"
        Me.taginput.Size = New System.Drawing.Size(100, 23)
        Me.taginput.TabIndex = 19
        Me.taginput.Text = "欲輸入Tag"
        Me.taginput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'y1
        '
        Me.y1.Location = New System.Drawing.Point(695, 106)
        Me.y1.Name = "y1"
        Me.y1.Size = New System.Drawing.Size(37, 22)
        Me.y1.TabIndex = 23
        '
        'plotinput
        '
        Me.plotinput.Location = New System.Drawing.Point(650, 57)
        Me.plotinput.Name = "plotinput"
        Me.plotinput.Size = New System.Drawing.Size(168, 23)
        Me.plotinput.TabIndex = 22
        Me.plotinput.Text = "欲輸入樣方"
        Me.plotinput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(652, 106)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(37, 22)
        Me.x1.TabIndex = 21
        '
        'y2
        '
        Me.y2.Location = New System.Drawing.Point(781, 106)
        Me.y2.Name = "y2"
        Me.y2.Size = New System.Drawing.Size(37, 22)
        Me.y2.TabIndex = 25
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(738, 106)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(37, 22)
        Me.x2.TabIndex = 24
        '
        'gotoplot
        '
        Me.gotoplot.Location = New System.Drawing.Point(652, 134)
        Me.gotoplot.Name = "gotoplot"
        Me.gotoplot.Size = New System.Drawing.Size(166, 23)
        Me.gotoplot.TabIndex = 38
        Me.gotoplot.Text = "前往 / 重新整理"
        Me.gotoplot.UseVisualStyleBackColor = True
        '
        'n
        '
        Me.n.Location = New System.Drawing.Point(652, 32)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(48, 22)
        Me.n.TabIndex = 39
        '
        'm
        '
        Me.m.Location = New System.Drawing.Point(706, 32)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(48, 22)
        Me.m.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(659, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "主格數"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(713, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "副格數"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(600, 460)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(472, 107)
        Me.DataGridView1.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(652, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 22)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "x1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(695, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 22)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "y1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(738, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 22)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "x2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(781, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 22)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "y2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'newdtbox
        '
        Me.newdtbox.Controls.Add(Me.newconfirm)
        Me.newdtbox.Controls.Add(Me.Label13)
        Me.newdtbox.Controls.Add(Me.Label12)
        Me.newdtbox.Controls.Add(Me.Label11)
        Me.newdtbox.Controls.Add(Me.Label10)
        Me.newdtbox.Controls.Add(Me.Label9)
        Me.newdtbox.Controls.Add(Me.Label8)
        Me.newdtbox.Controls.Add(Me.Label1)
        Me.newdtbox.Controls.Add(Me.newdbh)
        Me.newdtbox.Controls.Add(Me.newsp)
        Me.newdtbox.Controls.Add(Me.newtag)
        Me.newdtbox.Controls.Add(Me.newy2)
        Me.newdtbox.Controls.Add(Me.newx2)
        Me.newdtbox.Controls.Add(Me.newy1)
        Me.newdtbox.Controls.Add(Me.newx1)
        Me.newdtbox.Enabled = False
        Me.newdtbox.Location = New System.Drawing.Point(824, 43)
        Me.newdtbox.Name = "newdtbox"
        Me.newdtbox.Size = New System.Drawing.Size(192, 254)
        Me.newdtbox.TabIndex = 48
        Me.newdtbox.TabStop = False
        Me.newdtbox.Text = "新增資料欄位填寫"
        '
        'newconfirm
        '
        Me.newconfirm.Location = New System.Drawing.Point(21, 212)
        Me.newconfirm.Name = "newconfirm"
        Me.newconfirm.Size = New System.Drawing.Size(147, 23)
        Me.newconfirm.TabIndex = 14
        Me.newconfirm.Text = "確認新增"
        Me.newconfirm.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 12)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "dbh"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 12)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "sp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 12)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "tag"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "y2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "y1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "x2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "x1"
        '
        'newdbh
        '
        Me.newdbh.Location = New System.Drawing.Point(68, 184)
        Me.newdbh.Name = "newdbh"
        Me.newdbh.Size = New System.Drawing.Size(100, 22)
        Me.newdbh.TabIndex = 6
        '
        'newsp
        '
        Me.newsp.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "44444", "4455"})
        Me.newsp.Location = New System.Drawing.Point(68, 156)
        Me.newsp.Name = "newsp"
        Me.newsp.Size = New System.Drawing.Size(100, 22)
        Me.newsp.TabIndex = 5
        '
        'newtag
        '
        Me.newtag.Location = New System.Drawing.Point(68, 128)
        Me.newtag.Name = "newtag"
        Me.newtag.Size = New System.Drawing.Size(100, 22)
        Me.newtag.TabIndex = 4
        '
        'newy2
        '
        Me.newy2.Location = New System.Drawing.Point(68, 100)
        Me.newy2.Name = "newy2"
        Me.newy2.Size = New System.Drawing.Size(100, 22)
        Me.newy2.TabIndex = 3
        '
        'newx2
        '
        Me.newx2.Location = New System.Drawing.Point(68, 72)
        Me.newx2.Name = "newx2"
        Me.newx2.Size = New System.Drawing.Size(100, 22)
        Me.newx2.TabIndex = 2
        '
        'newy1
        '
        Me.newy1.Location = New System.Drawing.Point(68, 44)
        Me.newy1.Name = "newy1"
        Me.newy1.Size = New System.Drawing.Size(100, 22)
        Me.newy1.TabIndex = 1
        '
        'newx1
        '
        Me.newx1.Location = New System.Drawing.Point(68, 16)
        Me.newx1.Name = "newx1"
        Me.newx1.Size = New System.Drawing.Size(100, 22)
        Me.newx1.TabIndex = 0
        '
        'newdt
        '
        Me.newdt.Location = New System.Drawing.Point(824, 14)
        Me.newdt.Name = "newdt"
        Me.newdt.Size = New System.Drawing.Size(75, 23)
        Me.newdt.TabIndex = 49
        Me.newdt.Text = "新增資料"
        Me.newdt.UseVisualStyleBackColor = True
        '
        'deletedt
        '
        Me.deletedt.Location = New System.Drawing.Point(824, 303)
        Me.deletedt.Name = "deletedt"
        Me.deletedt.Size = New System.Drawing.Size(75, 23)
        Me.deletedt.TabIndex = 50
        Me.deletedt.Text = "刪除資料"
        Me.deletedt.UseVisualStyleBackColor = True
        '
        'deletedtbox
        '
        Me.deletedtbox.Controls.Add(Me.deleteconfirm)
        Me.deletedtbox.Controls.Add(Me.Label14)
        Me.deletedtbox.Controls.Add(Me.deletetag)
        Me.deletedtbox.Enabled = False
        Me.deletedtbox.Location = New System.Drawing.Point(824, 332)
        Me.deletedtbox.Name = "deletedtbox"
        Me.deletedtbox.Size = New System.Drawing.Size(192, 88)
        Me.deletedtbox.TabIndex = 51
        Me.deletedtbox.TabStop = False
        Me.deletedtbox.Text = "刪除資料tag填寫"
        '
        'deleteconfirm
        '
        Me.deleteconfirm.Location = New System.Drawing.Point(21, 49)
        Me.deleteconfirm.Name = "deleteconfirm"
        Me.deleteconfirm.Size = New System.Drawing.Size(147, 23)
        Me.deleteconfirm.TabIndex = 15
        Me.deleteconfirm.Text = "確認刪除"
        Me.deleteconfirm.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 12)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "tag"
        '
        'deletetag
        '
        Me.deletetag.Location = New System.Drawing.Point(68, 21)
        Me.deletetag.Name = "deletetag"
        Me.deletetag.Size = New System.Drawing.Size(100, 22)
        Me.deletetag.TabIndex = 15
        '
        'plotdataview
        '
        Me.plotdataview.AutoSize = True
        Me.plotdataview.Location = New System.Drawing.Point(598, 445)
        Me.plotdataview.Name = "plotdataview"
        Me.plotdataview.Size = New System.Drawing.Size(89, 12)
        Me.plotdataview.TabIndex = 52
        Me.plotdataview.Text = "小樣方資料顯示"
        '
        'mapkeying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1084, 611)
        Me.Controls.Add(Me.plotdataview)
        Me.Controls.Add(Me.deletedtbox)
        Me.Controls.Add(Me.deletedt)
        Me.Controls.Add(Me.newdt)
        Me.Controls.Add(Me.newdtbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.gotoplot)
        Me.Controls.Add(Me.y2)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.y1)
        Me.Controls.Add(Me.plotinput)
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.sptag)
        Me.Controls.Add(Me.taginput)
        Me.Controls.Add(Me.ylab)
        Me.Controls.Add(Me.xlab)
        Me.Name = "mapkeying"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mapkeying"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.newdtbox.ResumeLayout(False)
        Me.newdtbox.PerformLayout()
        Me.deletedtbox.ResumeLayout(False)
        Me.deletedtbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xlab As System.Windows.Forms.Label
    Friend WithEvents ylab As System.Windows.Forms.Label
    Friend WithEvents sptag As System.Windows.Forms.TextBox
    Friend WithEvents taginput As System.Windows.Forms.Label
    Friend WithEvents y1 As System.Windows.Forms.TextBox
    Friend WithEvents plotinput As System.Windows.Forms.Label
    Friend WithEvents x1 As System.Windows.Forms.TextBox
    Friend WithEvents y2 As System.Windows.Forms.TextBox
    Friend WithEvents x2 As System.Windows.Forms.TextBox
    Friend WithEvents gotoplot As System.Windows.Forms.Button
    Friend WithEvents n As System.Windows.Forms.TextBox
    Friend WithEvents m As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents newdtbox As System.Windows.Forms.GroupBox
    Friend WithEvents newconfirm As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newdbh As System.Windows.Forms.TextBox
    Friend WithEvents newsp As System.Windows.Forms.TextBox
    Friend WithEvents newtag As System.Windows.Forms.TextBox
    Friend WithEvents newy2 As System.Windows.Forms.TextBox
    Friend WithEvents newx2 As System.Windows.Forms.TextBox
    Friend WithEvents newy1 As System.Windows.Forms.TextBox
    Friend WithEvents newx1 As System.Windows.Forms.TextBox
    Friend WithEvents newdt As System.Windows.Forms.Button
    Friend WithEvents deletedt As System.Windows.Forms.Button
    Friend WithEvents deletedtbox As System.Windows.Forms.GroupBox
    Friend WithEvents deleteconfirm As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents deletetag As System.Windows.Forms.TextBox
    Friend WithEvents plotdataview As System.Windows.Forms.Label

End Class
