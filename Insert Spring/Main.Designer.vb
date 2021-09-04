<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.TabReport = New System.Windows.Forms.TabPage()
        Me.TabRejectRate = New System.Windows.Forms.TabPage()
        Me.TabCom = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIPAddrs = New System.Windows.Forms.Label()
        Me.txtIpAddrs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReadModbus = New System.Windows.Forms.Button()
        Me.txtStartRead = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLengthRead = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstRegValues = New System.Windows.Forms.ListBox()
        Me.btnWriteModbus = New System.Windows.Forms.Button()
        Me.txtxWriteValue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddrs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimerModbus = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabCom.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabHome)
        Me.TabControl1.Controls.Add(Me.TabReport)
        Me.TabControl1.Controls.Add(Me.TabRejectRate)
        Me.TabControl1.Controls.Add(Me.TabCom)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1434, 1360)
        Me.TabControl1.TabIndex = 0
        '
        'TabHome
        '
        Me.TabHome.Location = New System.Drawing.Point(4, 33)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(1426, 1323)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'TabReport
        '
        Me.TabReport.Location = New System.Drawing.Point(4, 33)
        Me.TabReport.Name = "TabReport"
        Me.TabReport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReport.Size = New System.Drawing.Size(1426, 1323)
        Me.TabReport.TabIndex = 1
        Me.TabReport.Text = "Report"
        Me.TabReport.UseVisualStyleBackColor = True
        '
        'TabRejectRate
        '
        Me.TabRejectRate.Location = New System.Drawing.Point(4, 33)
        Me.TabRejectRate.Name = "TabRejectRate"
        Me.TabRejectRate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRejectRate.Size = New System.Drawing.Size(1426, 1323)
        Me.TabRejectRate.TabIndex = 2
        Me.TabRejectRate.Text = "Reject Rate"
        Me.TabRejectRate.UseVisualStyleBackColor = True
        '
        'TabCom
        '
        Me.TabCom.Controls.Add(Me.GroupBox2)
        Me.TabCom.Controls.Add(Me.GroupBox1)
        Me.TabCom.Location = New System.Drawing.Point(4, 33)
        Me.TabCom.Name = "TabCom"
        Me.TabCom.Size = New System.Drawing.Size(1426, 1323)
        Me.TabCom.TabIndex = 3
        Me.TabCom.Text = "Communication"
        Me.TabCom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIpAddrs)
        Me.GroupBox1.Controls.Add(Me.lblIPAddrs)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1373, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'lblIPAddrs
        '
        Me.lblIPAddrs.AutoSize = True
        Me.lblIPAddrs.Location = New System.Drawing.Point(51, 45)
        Me.lblIPAddrs.Name = "lblIPAddrs"
        Me.lblIPAddrs.Size = New System.Drawing.Size(36, 25)
        Me.lblIPAddrs.TabIndex = 0
        Me.lblIPAddrs.Text = "IP:"
        '
        'txtIpAddrs
        '
        Me.txtIpAddrs.Location = New System.Drawing.Point(137, 40)
        Me.txtIpAddrs.Name = "txtIpAddrs"
        Me.txtIpAddrs.Size = New System.Drawing.Size(131, 29)
        Me.txtIpAddrs.TabIndex = 1
        Me.txtIpAddrs.Text = "127.0.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port : "
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(137, 92)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(131, 29)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "502"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(312, 28)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(136, 55)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(312, 92)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(136, 55)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "DisConnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(495, 43)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(91, 25)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status : -"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtxWriteValue)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtAddrs)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnWriteModbus)
        Me.GroupBox2.Controls.Add(Me.lstRegValues)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLengthRead)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtStartRead)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnReadModbus)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1373, 1034)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Holding Register"
        '
        'btnReadModbus
        '
        Me.btnReadModbus.Enabled = False
        Me.btnReadModbus.Location = New System.Drawing.Point(169, 142)
        Me.btnReadModbus.Name = "btnReadModbus"
        Me.btnReadModbus.Size = New System.Drawing.Size(99, 36)
        Me.btnReadModbus.TabIndex = 0
        Me.btnReadModbus.Text = "Read"
        Me.btnReadModbus.UseVisualStyleBackColor = True
        '
        'txtStartRead
        '
        Me.txtStartRead.Location = New System.Drawing.Point(137, 56)
        Me.txtStartRead.Name = "txtStartRead"
        Me.txtStartRead.Size = New System.Drawing.Size(131, 29)
        Me.txtStartRead.TabIndex = 3
        Me.txtStartRead.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start :"
        '
        'txtLengthRead
        '
        Me.txtLengthRead.Location = New System.Drawing.Point(137, 101)
        Me.txtLengthRead.Name = "txtLengthRead"
        Me.txtLengthRead.Size = New System.Drawing.Size(131, 29)
        Me.txtLengthRead.TabIndex = 5
        Me.txtLengthRead.Text = "10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Length : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Register"
        '
        'lstRegValues
        '
        Me.lstRegValues.FormattingEnabled = True
        Me.lstRegValues.ItemHeight = 24
        Me.lstRegValues.Location = New System.Drawing.Point(39, 201)
        Me.lstRegValues.Name = "lstRegValues"
        Me.lstRegValues.Size = New System.Drawing.Size(229, 796)
        Me.lstRegValues.TabIndex = 8
        '
        'btnWriteModbus
        '
        Me.btnWriteModbus.Enabled = False
        Me.btnWriteModbus.Location = New System.Drawing.Point(500, 142)
        Me.btnWriteModbus.Name = "btnWriteModbus"
        Me.btnWriteModbus.Size = New System.Drawing.Size(110, 36)
        Me.btnWriteModbus.TabIndex = 9
        Me.btnWriteModbus.Text = "Write"
        Me.btnWriteModbus.UseVisualStyleBackColor = True
        '
        'txtxWriteValue
        '
        Me.txtxWriteValue.Location = New System.Drawing.Point(479, 101)
        Me.txtxWriteValue.Name = "txtxWriteValue"
        Me.txtxWriteValue.Size = New System.Drawing.Size(131, 29)
        Me.txtxWriteValue.TabIndex = 13
        Me.txtxWriteValue.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Value :"
        '
        'txtAddrs
        '
        Me.txtAddrs.Location = New System.Drawing.Point(479, 56)
        Me.txtAddrs.Name = "txtAddrs"
        Me.txtAddrs.Size = New System.Drawing.Size(131, 29)
        Me.txtAddrs.TabIndex = 11
        Me.txtAddrs.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Reg Addrs :"
        '
        'TimerModbus
        '
        Me.TimerModbus.Interval = 500
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 1360)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Spring Insert"
        Me.TabControl1.ResumeLayout(False)
        Me.TabCom.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabReport As TabPage
    Friend WithEvents TabRejectRate As TabPage
    Friend WithEvents TabCom As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIpAddrs As TextBox
    Friend WithEvents lblIPAddrs As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReadModbus As Button
    Friend WithEvents txtLengthRead As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStartRead As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstRegValues As ListBox
    Friend WithEvents txtxWriteValue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddrs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnWriteModbus As Button
    Friend WithEvents TimerModbus As Timer
End Class
