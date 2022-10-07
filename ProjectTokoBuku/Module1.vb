Imports MySql.Data.MySqlClient
Module Module1
    Public str As String
    Public data As Integer
    Public i As Integer
    Public lng As Double
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As DataTable

    Sub koneksi()
        str = "server=localhost;userid=root;password=;database=db_tokobuku;convert zero datetime=true"
        conn = New MySqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
