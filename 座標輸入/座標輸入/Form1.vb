Imports Npgsql
Imports NpgsqlTypes


Public Class mapkeying
    Public conn As NpgsqlConnection
    Dim da As NpgsqlDataAdapter
    Dim pdataset As DataSet
    Dim arrtag As String()
    Dim arrx3 As String()
    Dim arry3 As String()
    Dim arrdbh As Decimal()
    Dim connstring As String = "Server=localhost;port=5432;Database=forest;User Id=postgres;Password=2717484"
    Dim relationname As String



    Private Sub mapkeying_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick '滑鼠座標輸入
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If sptag.Text = "" Then
                Exit Sub  '沒給tag直接驅逐
            End If

            If Val(xlab.Text) > 500 Or Val(xlab.Text) < 0 Or Val(ylab.Text) > 500 Or Val(ylab.Text) < 0 Then
                MsgBox("超出範圍!")
                Exit Sub '出界不給點
            ElseIf x1.Text <> "" And y1.Text <> "" And x2.Text <> "" And y2.Text <> "" And Trim(sptag.Text) <> "" Then

                Dim g As Graphics = CreateGraphics()
                Dim bluepen As New Pen(Color.Blue, 1)
                Dim rect As New Rectangle(e.Location.X, e.Location.Y, 3, 3) '新增點的位置與大小
                Dim maptag As String
                Dim tagfont As New Font("Arial", 10)
                Dim tagpoint As New Point(e.Location.X, e.Location.Y)
                Dim tagbrush As New SolidBrush(Color.Blue)


                Dim cdataadapter As New NpgsqlDataAdapter("select * from plotdata where x1 = '" & CStr(x1.Text) & "' and y1 = '" & CStr(y1.Text) & "' and x2 = '" & CInt(x2.Text) & "' and y2 = '" & CInt(y2.Text) & "'", conn)
                Dim cmdbuild As NpgsqlCommandBuilder = New NpgsqlCommandBuilder(da)
                pdataset = New DataSet
                cdataadapter.Fill(pdataset, "plotdata")
                arrtag = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("tag")).ToArray
                arrx3 = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("x3")).ToArray
                arry3 = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("y3")).ToArray
                '將tag,x3,y3資料分別加入陣列

                Dim result As Integer = Array.IndexOf(arrtag, sptag.Text)
                '檢測欲輸入tag是否於小樣方內

                If result > -1 Then  '若於小樣方內即點出位置並標示tag
                    conn.Open() '打開資料庫
                    maptag = sptag.Text
                    g.DrawEllipse(bluepen, rect)
                    g.DrawString(maptag, tagfont, tagbrush, tagpoint)

                    Dim commandx3 As NpgsqlCommand = New NpgsqlCommand("update plotdata set x3 = " & CInt(xlab.Text) & " where tag = '" & CStr(sptag.Text) & "'", conn)
                    Dim commandy3 As NpgsqlCommand = New NpgsqlCommand("update plotdata set y3 = " & CInt(ylab.Text) & " where tag = '" & CStr(sptag.Text) & "'", conn)

                    commandx3.ExecuteNonQuery()
                    commandy3.ExecuteNonQuery()
                    '執行SQL指令

                    conn.Close() '關閉資料庫
                Else
                    MsgBox("此小樣方無此資料")

                End If
            End If
        End If

    End Sub

    Private Sub mapkeying_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove '偵測x3,y3
        xlab.Text = e.Location.X - 50
        ylab.Text = 500 - e.Location.Y + 50
    End Sub

    Private Sub gotoplot_Click(sender As Object, e As EventArgs) Handles gotoplot.Click

        drawmap() '執行畫格線副程式
        

        conn = New NpgsqlConnection(connstring)
        If x2.Text = "" Or y2.Text = "" Then
            Exit Sub
        End If
        Dim cdataadapter As New NpgsqlDataAdapter("select * from plotdata where x1 = '" & CStr(x1.Text) & "' and y1 = '" & CStr(y1.Text) & "' and x2 = '" & CInt(x2.Text) & "' and y2 = '" & CInt(y2.Text) & "'", conn)
        Dim cmdbuild As NpgsqlCommandBuilder = New NpgsqlCommandBuilder(da)
        pdataset = New DataSet
        cdataadapter.Fill(pdataset, "plotdata")

        DataGridView1.DataSource = pdataset
        DataGridView1.DataMember = "plotdata" '將資料填入顯示畫面
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        conn.Open() '打開資料庫

        drawspot() '執行畫點副程式

        conn.Close() '關閉資料庫

    End Sub
    Public Sub drawmap() '劃格線
        Dim g As Graphics = CreateGraphics()
        Dim redpen As New Pen(Color.Red, 2)
        Dim blackpen As New Pen(Color.Black, 1)

        g.Clear(Me.BackColor) '清空畫布

        If IsNumeric(n.Text) = False Or IsNumeric(m.Text) = False Then
            Exit Sub
        ElseIf n.Text = 0 Or m.Text = 0 Then
            Exit Sub
        End If

        Dim pn, pm As Single '計算格線變換的數學問題
        pn = 500 / CInt(n.Text)
        pm = 500 / CInt(n.Text) / CInt(m.Text)
        Dim K As Single = CInt(n.Text) * CInt(m.Text)

        For i = 0 To K
            g.DrawLine(blackpen, 50, 50 + pm * i, 550, 50 + pm * i)
        Next
        For i = 0 To K
            g.DrawLine(blackpen, 50 + pm * i, 50, 50 + pm * i, 550)
        Next
        For i = 0 To CInt(n.Text)
            g.DrawLine(redpen, 50, 50 + pn * i, 550, 50 + pn * i)
        Next
        For i = 0 To CInt(n.Text)
            g.DrawLine(redpen, 50 + pn * i, 50, 50 + pn * i, 550)
        Next


        redpen.Dispose()
        blackpen.Dispose() '釋放畫筆
    End Sub


    Public Sub drawspot() '畫點副程式

        arrtag = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("tag")).ToArray
        arrx3 = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("x3")).ToArray
        arry3 = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("y3")).ToArray
        'arrdbh = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of Decimal)("dbh")).ToArray
        '舊有資料加入陣列

        Dim g As Graphics = CreateGraphics()
        Dim bluepen As New Pen(Color.Blue, 1)

        Dim maptag As String
        Dim tagfont As New Font("Arial", 10)

        Dim tagbrush As New SolidBrush(Color.Blue) '設定tag字體顏色

        For i = 0 To arrtag.Count - 1
            Dim rect As New Rectangle(CInt(arrx3(i)) + 50, 500 - CInt(arry3(i)) + 50, 3, 3) '設定點的位置與大小
            Dim tagpoint As New Point(CInt(arrx3(i)) + 50, 500 - CInt(arry3(i)) + 50)
            maptag = arrtag(i)
            g.DrawEllipse(bluepen, rect)
            g.DrawString(maptag, tagfont, tagbrush, tagpoint)
        Next


    End Sub

    Private Sub newdt_Click(sender As Object, e As EventArgs) Handles newdt.Click
        newdtbox.Enabled = True
        newx1.Focus()


        conn = New NpgsqlConnection(connstring)
        conn.Open()
        Dim newdataset = New DataSet
        Dim mysource As New AutoCompleteStringCollection
        Dim Str As String = "select distinct sp from plotdata"
        Dim SqlCom As New NpgsqlCommand(Str, conn)
        Dim sqlAdap As New NpgsqlDataAdapter(SqlCom)
        sqlAdap.Fill(newdataset)
        For i As Integer = 0 To newdataset.Tables(0).Rows.Count - 1
            mysource.Add(newdataset.Tables(0).Rows(i)(0).ToString())
        Next
        newsp.AutoCompleteSource = AutoCompleteSource.CustomSource
        newsp.AutoCompleteCustomSource = mysource
        newsp.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        conn.Close()

    End Sub

    Private Sub mapkeying_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(50, 50) '設定程式起始位置
        Me.Show()
        n.Focus()
       
    End Sub

    Private Sub deletedt_Click(sender As Object, e As EventArgs) Handles deletedt.Click
        deletedtbox.Enabled = True
        deletetag.Focus()
    End Sub

    Private Sub mapkeying_Move(sender As Object, e As EventArgs) Handles Me.LostFocus, Me.Activated, Me.LocationChanged

        'gotoplot.PerformClick()
        '避免最小化、移動、視窗切換後圖形消失

        drawmap()  '執行畫格線副程式

        Dim connstring As String = "Server=localhost;port=5432;Database=forest;User Id=postgres;Password=2717484"
        conn = New NpgsqlConnection(connstring)
        If x2.Text = "" Or y2.Text = "" Then
            Exit Sub '缺東缺西先驅逐
        End If
        Dim cdataadapter As New NpgsqlDataAdapter("select * from plotdata where x1 = '" & CStr(x1.Text) & "' and y1 = '" & CStr(y1.Text) & "' and x2 = '" & CInt(x2.Text) & "' and y2 = '" & CInt(y2.Text) & "'", conn)
        Dim cmdbuild As NpgsqlCommandBuilder = New NpgsqlCommandBuilder(da)
        Dim pdataset As DataSet
        pdataset = New DataSet

        cdataadapter.Fill(pdataset, "plotdata")

        conn.Open()

        drawspot() '執行畫點副程式

        conn.Close()
    End Sub

    Private Sub newconfirm_Click(sender As Object, e As EventArgs) Handles newconfirm.Click

        conn.Open()
        If Trim(newx1.Text) = "" Or Trim(newy1.Text) = "" Or Trim(newx2.Text) = "" Or Trim(newy2.Text) = "" Or Trim(newsp.Text) = "" Then
            MsgBox("所需資料不足")
            newdtbox.Enabled = False

            conn.Close()
            Exit Sub '缺資料就重來
        Else
            Try
                Dim newcmd As New NpgsqlCommand
                newcmd.CommandType = System.Data.CommandType.Text
                newcmd.CommandText = "insert into plotdata(x1,y1,x2,y2,tag,sp,dbh) values ('" & newx1.Text & "','" & newy1.Text & "','" & newx2.Text & "','" & newy2.Text & "','" & newtag.Text & "','" & newsp.Text & "','" & Val(newdbh.Text) & "')"
                newcmd.Connection = conn
                newcmd.ExecuteNonQuery() '新增植株SQL

                conn.Close()
                MsgBox("成功新增")
                gotoplot.PerformClick()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
        newdtbox.Enabled = False
        newx1.Text = ""
        newy1.Text = ""
        newx2.Text = ""
        newy2.Text = ""
        newtag.Text = ""
        newsp.Text = ""
        newdbh.Text = ""
    End Sub

    Private Sub deleteconfirm_Click(sender As Object, e As EventArgs) Handles deleteconfirm.Click
        conn.Close()
        deletetag.Focus()
        conn.Open()
        If x1.Text <> "" And y1.Text <> "" And x2.Text <> "" And y2.Text <> "" And deletetag.Text <> "" Then '限制於小樣方中執行刪除動作，增加刪除資料不方便性與困難度
            Dim cdataadapter As New NpgsqlDataAdapter("select * from plotdata where x1 = '" & CStr(x1.Text) & "' and y1 = '" & CStr(y1.Text) & "' and x2 = '" & CInt(x2.Text) & "' and y2 = '" & CInt(y2.Text) & "'", conn)
            Dim cmdbuild As NpgsqlCommandBuilder = New NpgsqlCommandBuilder(da)
            pdataset = New DataSet
            cdataadapter.Fill(pdataset, "plotdata")
            arrtag = (From myRow In pdataset.Tables(0).AsEnumerable Select myRow.Field(Of String)("tag")).ToArray

            Dim result As Integer = Array.IndexOf(arrtag, deletetag.Text)
            If result > 0 Then
                Dim deletecmd As New NpgsqlCommand
                deletecmd.CommandType = System.Data.CommandType.Text
                deletecmd.CommandText = "delete from plotdata where tag = ('" & deletetag.Text & "');"
                deletecmd.Connection = conn

                deletecmd.ExecuteNonQuery() '刪除植株
                conn.Close()
                MsgBox("確認刪除")
                gotoplot.PerformClick()
            Else
                conn.Close()
                MsgBox("植株不在此區域")
            End If
        Else
            conn.Close()
            MsgBox("請先前往小樣方或輸入要刪除的植株tag") '未輸入資料就重來

        End If
        deletedtbox.Enabled = False
        deletetag.Text = ""

    End Sub

    Private Sub lockrelation_Click(sender As Object, e As EventArgs) Handles lockrelation.Click
        If relation.Enabled = True Then
            relationname = CStr(relation.Text)
            relation.Enabled = False
            lockrelation.Text = "解除鎖定"
        Else
            relation.Enabled = True
            lockrelation.Text = "鎖定"
        End If
    End Sub
End Class
