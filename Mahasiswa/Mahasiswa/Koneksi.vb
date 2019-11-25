Imports System.Data.Odbc
Module Koneksi
    Public CMD As OdbcCommand
    Public DS As DataSet
    Public DA As OdbcDataAdapter
    Public RD As OdbcDataReader

    Public LokasiData As String = "Driver={MySQL ODBC 3.51 Driver}; Database=db_test; server=localhost; uid=root"
    Public CONN As OdbcConnection = New OdbcConnection(LokasiData)

    Public Sub bukakoneksi()
        If CONN.State = ConnectionState.Closed Then
            Try
                CONN.Open()
            Catch ex As Exception
                MsgBox("koneksi Gagal : " & ex.ToString)
            End Try
        End If
    End Sub
    Public Sub tutupkoneksi()
        If CONN.State = ConnectionState.Open Then
            Try
                CONN.Close()
            Catch ex As Exception
                MsgBox("gagal menutup koneksi: " & ex.ToString)
            End Try
        End If
    End Sub
End Module
