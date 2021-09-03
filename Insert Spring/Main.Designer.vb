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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.TabReport = New System.Windows.Forms.TabPage()
        Me.TabRejectRate = New System.Windows.Forms.TabPage()
        Me.TabCom = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
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
        Me.TabCom.Location = New System.Drawing.Point(4, 33)
        Me.TabCom.Name = "TabCom"
        Me.TabCom.Size = New System.Drawing.Size(1426, 1323)
        Me.TabCom.TabIndex = 3
        Me.TabCom.Text = "Communication"
        Me.TabCom.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 1360)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.Text = "Auto Spring Insert"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabReport As TabPage
    Friend WithEvents TabRejectRate As TabPage
    Friend WithEvents TabCom As TabPage
End Class
