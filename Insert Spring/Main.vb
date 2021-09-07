Imports System.Data.SqlClient
Imports EasyModbus
Public Class Main

    Public Shared koneksi As SqlConnection
    Public Shared database As String

    Dim ModClient As New ModbusClient


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(920, 900)
    End Sub


    Public Sub DGV_Refresh()

        Call Modul_Db.koneksi_db()
        Try
            Dim sc As New SqlCommand("SELECT TOP 10 * FROM [dbo].[Logging] ORDER BY [ID] DESC", koneksi)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            DGV_Logger.DataSource = ds.Tables(0)
            'DGV_Logger.Rows(0).Selected = True

            adapter.UpdateCommand = New SqlCommandBuilder(adapter).GetUpdateCommand
            adapter.Update(ds)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim str As String = "Fail"
        Try

            For i As Integer = 0 To DGV_Logger.Rows.Count - 1
                For j As Integer = 0 To Me.DGV_Logger.Rows(i).Cells.Count - 1
                    If DGV_Logger.Item(j, i).Value.ToString().Contains("Fail") Then
                        DGV_Logger.Rows(i).Cells(j).Style.ForeColor = Color.Red
                    ElseIf DGV_Logger.Item(j, i).Value.ToString().Contains("Pass") Then
                        DGV_Logger.Rows(i).Cells(j).Style.ForeColor = Color.Green
                    End If
                Next
            Next i

        Catch abc As Exception
        End Try



    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ModClient.IPAddress = txtIpAddrs.Text
        ModClient.Port = txtPort.Text
        Try
            ModClient.Connect()
            If ModClient.Connected Then
                lblStatus.Text = "Status : Connected"
                btnConnect.Enabled = False
                btnDisconnect.Enabled = True
                btnReadModbus.Enabled = True
                btnWriteModbus.Enabled = True
                TimerModbus.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error Connection!")
        End Try

    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Try
            ModClient.Disconnect()
            If ModClient.Connected = False Then
                lblStatus.Text = "Status : Disconnected"
                btnConnect.Enabled = True
                btnDisconnect.Enabled = False
                btnReadModbus.Enabled = False
                btnWriteModbus.Enabled = False
                TimerModbus.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error Disconnect!")
        End Try
    End Sub

    Private Sub btnReadModbus_Click(sender As Object, e As EventArgs) Handles btnReadModbus.Click
        Try
            Dim regvals As Integer()
            regvals = ModClient.ReadHoldingRegisters(txtStartRead.Text, txtLengthRead.Text)
            If regvals.Length > 0 Then
                lstRegValues.Items.Clear()
                Dim idx As Integer = 0
                For Each value As Integer In regvals
                    lstRegValues.Items.Add(value)
                    idx = idx + 1
                Next
            End If
        Catch ex As Exception
            TimerModbus.Enabled = False
            MsgBox("Error Reading")
            btnDisconnect_Click(sender, e)
        End Try
    End Sub

    Private Sub btnWriteModbus_Click(sender As Object, e As EventArgs) Handles btnWriteModbus.Click
        Try
            ModClient.WriteSingleRegister(txtAddrs.Text, txtxWriteValue.Text)
        Catch ex As Exception
            MsgBox("Error Writing")
        End Try
    End Sub

    Private Sub TimerModbus_Tick(sender As Object, e As EventArgs) Handles TimerModbus.Tick
        TimerModbus.Enabled = False
        btnReadModbus_Click(sender, e)
        TimerModbus.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DGV_Refresh()
    End Sub

    Private Sub TXT_LOG_PROCESS_TextChanged(sender As Object, e As EventArgs) Handles TXT_LOG_PROCESS.TextChanged
        If TXT_LOG_PROCESS.Lines.Count > 2 Then
            Dim newList As List(Of String) = TXT_LOG_PROCESS.Lines.ToList
            If TXT_LOG_PROCESS.Lines.Count >= 10 Then newList.RemoveAt(0)
            TXT_LOG_PROCESS.Lines = newList.ToArray
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If lbl_PLC_Connect.Text = "Connected" Then
            Dim a, b, c As Double
            Double.TryParse(txtPass.Text, a)
            Double.TryParse(txtFail.Text, b)
            c = (a / (a + b))
            txtfpYield.Text = Format(c, "0.0%")
        End If
    End Sub
    Private Sub txtFail_TextChanged(sender As Object, e As EventArgs) Handles txtFail.TextChanged
        If lbl_PLC_Connect.Text = "Connected" Then
            Dim a, b, c As Double
            Double.TryParse(txtPass.Text, a)
            Double.TryParse(txtFail.Text, b)
            c = (a / (a + b))
            txtFPYield.Text = Format(c, "0.0%")
        End If
    End Sub


    Private Sub btn_connect_PLC_Click(sender As Object, e As EventArgs) Handles btn_connect_PLC.Click
        btnConnect_Click(sender, e)
        btn_disconnect.Enabled = True
        btn_connect_PLC.Enabled = False

    End Sub

    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        btnDisconnect_Click(sender, e)
        btn_connect_PLC.Enabled = True
        btn_connect_PLC.Select()
        btn_disconnect.Enabled = False

    End Sub

    Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs) Handles lblStatus.TextChanged
        If lblStatus.Text.Contains("Disconnect") Then
            lbl_PLC_Connect.Text = "Disconnected"
        ElseIf lblStatus.Text.Contains("Connected") Then
            lbl_PLC_Connect.Text = "Connected"
        End If
    End Sub

    Private Sub lbl_PLC_Connect_TextChanged(sender As Object, e As EventArgs) Handles lbl_PLC_Connect.TextChanged
        If lblStatus.Text.Contains("Disconnect") Then
            lbl_PLC_Connect.ForeColor = Color.Red
        Else
            lbl_PLC_Connect.ForeColor = Color.Green
        End If
    End Sub




    'Public Sub DGV_to_Csv()
    '    If DGV_Report.RowCount > 0 Then
    '        Dim value As String = ""
    '        Dim dr As New DataGridViewRow()

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

    '            Dim swOut As New StreamWriter(SaveFileDialog1.FileName + ".csv")

    '            'write header rows to csv
    '            For i As Integer = 0 To DGV_Report.Columns.Count - 1
    '                If i > 0 Then
    '                    swOut.Write(",")
    '                End If
    '                swOut.Write(DGV_Report.Columns(i).HeaderText)
    '            Next

    '            swOut.WriteLine()

    '            'write DataGridView rows to csv
    '            For j As Integer = 0 To DGV_Report.Rows.Count - 1
    '                If j > 0 Then
    '                    swOut.WriteLine()
    '                End If

    '                dr = DGV_Report.Rows(j)

    '                For i As Integer = 0 To DGV_Report.Columns.Count - 1
    '                    If i > 0 Then
    '                        swOut.Write(",")
    '                    End If

    '                    'value = dr.Cells(i).Value.ToString()
    '                    value = CStr(dr.Cells(i).Value)

    '                    swOut.Write(value)
    '                Next
    '            Next
    '            swOut.Close()
    '        End If

    '    End If
    'End Sub


End Class
