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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtFPYield = New System.Windows.Forms.TextBox()
        Me.txtFail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.btn_connect_PLC = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_PLC_Connect = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGV_Logger = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TXT_LOG_PROCESS = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabReport = New System.Windows.Forms.TabPage()
        Me.TabRejectRate = New System.Windows.Forms.TabPage()
        Me.TabCom = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtxWriteValue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddrs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnWriteModbus = New System.Windows.Forms.Button()
        Me.lstRegValues = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLengthRead = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStartRead = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReadModbus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIpAddrs = New System.Windows.Forms.TextBox()
        Me.lblIPAddrs = New System.Windows.Forms.Label()
        Me.TimerModbus = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGV_Logger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabCom.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(1849, 1360)
        Me.TabControl1.TabIndex = 0
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.btnRefresh)
        Me.TabHome.Controls.Add(Me.StatusStrip1)
        Me.TabHome.Controls.Add(Me.GroupBox8)
        Me.TabHome.Controls.Add(Me.GroupBox7)
        Me.TabHome.Controls.Add(Me.GroupBox6)
        Me.TabHome.Controls.Add(Me.GroupBox5)
        Me.TabHome.Controls.Add(Me.GroupBox4)
        Me.TabHome.Controls.Add(Me.GroupBox3)
        Me.TabHome.Location = New System.Drawing.Point(4, 33)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(1841, 1323)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1402, 846)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(118, 46)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLogin})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 1281)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1835, 39)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLogin
        '
        Me.ToolStripStatusLogin.Name = "ToolStripStatusLogin"
        Me.ToolStripStatusLogin.Size = New System.Drawing.Size(110, 30)
        Me.ToolStripStatusLogin.Text = "Login As : "
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.txtFPYield)
        Me.GroupBox8.Controls.Add(Me.txtFail)
        Me.GroupBox8.Controls.Add(Me.txtPass)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Location = New System.Drawing.Point(388, 898)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1132, 311)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Performance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(392, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 50)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "FP Yeild"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(238, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 50)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "FAIL"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TextBox3)
        Me.GroupBox9.Location = New System.Drawing.Point(649, 72)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(432, 202)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Result"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 20.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(113, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(191, 70)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "PASS"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFPYield
        '
        Me.txtFPYield.Font = New System.Drawing.Font("Segoe UI", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFPYield.Location = New System.Drawing.Point(401, 142)
        Me.txtFPYield.Name = "txtFPYield"
        Me.txtFPYield.Size = New System.Drawing.Size(130, 51)
        Me.txtFPYield.TabIndex = 2
        Me.txtFPYield.Text = "100%"
        Me.txtFPYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFail
        '
        Me.txtFail.Font = New System.Drawing.Font("Segoe UI", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFail.Location = New System.Drawing.Point(230, 142)
        Me.txtFail.Name = "txtFail"
        Me.txtFail.Size = New System.Drawing.Size(130, 51)
        Me.txtFail.TabIndex = 1
        Me.txtFail.Text = "123456"
        Me.txtFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(66, 142)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(130, 51)
        Me.txtPass.TabIndex = 0
        Me.txtPass.Text = "123456"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(75, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 50)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "PASS"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btn_disconnect)
        Me.GroupBox7.Controls.Add(Me.btn_connect_PLC)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.lbl_PLC_Connect)
        Me.GroupBox7.Location = New System.Drawing.Point(26, 898)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(335, 311)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Status"
        '
        'btn_disconnect
        '
        Me.btn_disconnect.Enabled = False
        Me.btn_disconnect.Location = New System.Drawing.Point(153, 264)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(132, 41)
        Me.btn_disconnect.TabIndex = 3
        Me.btn_disconnect.Text = "Disconnect"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'btn_connect_PLC
        '
        Me.btn_connect_PLC.Location = New System.Drawing.Point(18, 264)
        Me.btn_connect_PLC.Name = "btn_connect_PLC"
        Me.btn_connect_PLC.Size = New System.Drawing.Size(115, 41)
        Me.btn_connect_PLC.TabIndex = 2
        Me.btn_connect_PLC.Text = "Connect"
        Me.btn_connect_PLC.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 38)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "PLC :"
        '
        'lbl_PLC_Connect
        '
        Me.lbl_PLC_Connect.AutoSize = True
        Me.lbl_PLC_Connect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PLC_Connect.Location = New System.Drawing.Point(132, 128)
        Me.lbl_PLC_Connect.Name = "lbl_PLC_Connect"
        Me.lbl_PLC_Connect.Size = New System.Drawing.Size(28, 38)
        Me.lbl_PLC_Connect.TabIndex = 0
        Me.lbl_PLC_Connect.Text = "-"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGV_Logger)
        Me.GroupBox6.Location = New System.Drawing.Point(26, 391)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1494, 457)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Logger Data"
        '
        'DGV_Logger
        '
        Me.DGV_Logger.AllowUserToAddRows = False
        Me.DGV_Logger.AllowUserToDeleteRows = False
        Me.DGV_Logger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Logger.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Logger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Logger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Logger.Location = New System.Drawing.Point(3, 25)
        Me.DGV_Logger.Name = "DGV_Logger"
        Me.DGV_Logger.ReadOnly = True
        Me.DGV_Logger.RowHeadersWidth = 72
        Me.DGV_Logger.RowTemplate.Height = 31
        Me.DGV_Logger.Size = New System.Drawing.Size(1488, 429)
        Me.DGV_Logger.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TXT_LOG_PROCESS)
        Me.GroupBox5.Location = New System.Drawing.Point(851, 57)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(669, 311)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Logger Process"
        '
        'TXT_LOG_PROCESS
        '
        Me.TXT_LOG_PROCESS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_LOG_PROCESS.Location = New System.Drawing.Point(27, 43)
        Me.TXT_LOG_PROCESS.Multiline = True
        Me.TXT_LOG_PROCESS.Name = "TXT_LOG_PROCESS"
        Me.TXT_LOG_PROCESS.Size = New System.Drawing.Size(611, 241)
        Me.TXT_LOG_PROCESS.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(387, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(438, 311)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vision String"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(26, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 311)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Image Product"
        '
        'TabReport
        '
        Me.TabReport.Location = New System.Drawing.Point(4, 33)
        Me.TabReport.Name = "TabReport"
        Me.TabReport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReport.Size = New System.Drawing.Size(1841, 1323)
        Me.TabReport.TabIndex = 1
        Me.TabReport.Text = "Report"
        Me.TabReport.UseVisualStyleBackColor = True
        '
        'TabRejectRate
        '
        Me.TabRejectRate.Location = New System.Drawing.Point(4, 33)
        Me.TabRejectRate.Name = "TabRejectRate"
        Me.TabRejectRate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRejectRate.Size = New System.Drawing.Size(1841, 1323)
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
        Me.TabCom.Size = New System.Drawing.Size(1841, 1323)
        Me.TabCom.TabIndex = 3
        Me.TabCom.Text = "Communication"
        Me.TabCom.UseVisualStyleBackColor = True
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
        'lstRegValues
        '
        Me.lstRegValues.FormattingEnabled = True
        Me.lstRegValues.ItemHeight = 24
        Me.lstRegValues.Location = New System.Drawing.Point(39, 201)
        Me.lstRegValues.Name = "lstRegValues"
        Me.lstRegValues.Size = New System.Drawing.Size(229, 796)
        Me.lstRegValues.TabIndex = 8
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
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(495, 43)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(91, 25)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status : -"
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
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(312, 28)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(136, 55)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(137, 92)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(131, 29)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "502"
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
        'txtIpAddrs
        '
        Me.txtIpAddrs.Location = New System.Drawing.Point(137, 40)
        Me.txtIpAddrs.Name = "txtIpAddrs"
        Me.txtIpAddrs.Size = New System.Drawing.Size(131, 29)
        Me.txtIpAddrs.TabIndex = 1
        Me.txtIpAddrs.Text = "127.0.0.1"
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
        'TimerModbus
        '
        Me.TimerModbus.Interval = 500
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1849, 1360)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Spring Insert"
        Me.TabControl1.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TabHome.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGV_Logger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabCom.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLogin As ToolStripStatusLabel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGV_Logger As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TXT_LOG_PROCESS As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtFPYield As TextBox
    Friend WithEvents txtFail As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_PLC_Connect As Label
    Friend WithEvents btn_disconnect As Button
    Friend WithEvents btn_connect_PLC As Button
End Class
