Imports System.Data.SqlClient
Imports EasyModbus
Public Class Main

    Public Shared koneksi As SqlConnection

    Dim ModClient As New ModbusClient


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(950, 900)
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
End Class
