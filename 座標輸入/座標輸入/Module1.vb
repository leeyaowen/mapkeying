Imports Npgsql

Module Module1
    Public conn As NpgsqlConnection
    Public Sub openConn()
        Try
            Dim connstring As String = "Server=localhost;port=5432;Database=forest;User Id=postgres;Password=2717484"
            conn = New NpgsqlConnection(connstring)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
