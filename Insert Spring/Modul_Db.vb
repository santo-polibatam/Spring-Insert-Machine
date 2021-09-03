Imports System.Data.SqlClient
Module Modul_Db

    Public Sub koneksi_db()
        Try
            Dim database As String = "Data Source=DESKTOP-6Q3FDRQ\SQLEXPRESS;
            initial catalog=sch;
            Persist Security Info=True;
            User ID=sa;
            Password=sch@2021;
            Max Pool Size=5000;
            Pooling=True"
            Main.koneksi = New SqlConnection(database)
            If Main.koneksi.State = ConnectionState.Closed Then Main.koneksi.Open() Else Main.koneksi.Close()
        Catch ex As Exception
            MsgBox("Database Connection Error -> " + ex.Message)
        End Try
    End Sub
End Module
