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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    Me.timerBG = New System.Windows.Forms.Timer(Me.components)
    Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtPath = New System.Windows.Forms.TextBox()
    Me.btnPath = New System.Windows.Forms.Button()
    Me.txtMinutes = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnToTray = New System.Windows.Forms.Button()
    Me.txtCurrent = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.pgb = New System.Windows.Forms.ProgressBar()
    Me.btnTime = New System.Windows.Forms.Button()
    Me.btnResend = New System.Windows.Forms.Button()
    Me.timerStartupMinimize = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'timerBG
    '
    Me.timerBG.Enabled = True
    '
    'NotifyIcon1
    '
    Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
    Me.NotifyIcon1.Text = "Wallpaper Changer"
    Me.NotifyIcon1.Visible = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(70, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Pictures Path"
    '
    'txtPath
    '
    Me.txtPath.Location = New System.Drawing.Point(12, 25)
    Me.txtPath.Name = "txtPath"
    Me.txtPath.ReadOnly = True
    Me.txtPath.Size = New System.Drawing.Size(492, 20)
    Me.txtPath.TabIndex = 1
    '
    'btnPath
    '
    Me.btnPath.Location = New System.Drawing.Point(519, 23)
    Me.btnPath.Name = "btnPath"
    Me.btnPath.Size = New System.Drawing.Size(75, 23)
    Me.btnPath.TabIndex = 2
    Me.btnPath.Text = "Pick Dir"
    Me.btnPath.UseVisualStyleBackColor = True
    '
    'txtMinutes
    '
    Me.txtMinutes.Location = New System.Drawing.Point(12, 75)
    Me.txtMinutes.Name = "txtMinutes"
    Me.txtMinutes.Size = New System.Drawing.Size(70, 20)
    Me.txtMinutes.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 59)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Minutes"
    '
    'btnToTray
    '
    Me.btnToTray.Location = New System.Drawing.Point(519, 72)
    Me.btnToTray.Name = "btnToTray"
    Me.btnToTray.Size = New System.Drawing.Size(75, 23)
    Me.btnToTray.TabIndex = 5
    Me.btnToTray.Text = "To Tray"
    Me.btnToTray.UseVisualStyleBackColor = True
    '
    'txtCurrent
    '
    Me.txtCurrent.Location = New System.Drawing.Point(12, 124)
    Me.txtCurrent.Name = "txtCurrent"
    Me.txtCurrent.ReadOnly = True
    Me.txtCurrent.Size = New System.Drawing.Size(492, 20)
    Me.txtCurrent.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 108)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(60, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Current File"
    '
    'pgb
    '
    Me.pgb.Location = New System.Drawing.Point(147, 73)
    Me.pgb.Name = "pgb"
    Me.pgb.Size = New System.Drawing.Size(357, 23)
    Me.pgb.TabIndex = 8
    '
    'btnTime
    '
    Me.btnTime.Location = New System.Drawing.Point(89, 73)
    Me.btnTime.Name = "btnTime"
    Me.btnTime.Size = New System.Drawing.Size(52, 23)
    Me.btnTime.TabIndex = 9
    Me.btnTime.Text = "Set"
    Me.btnTime.UseVisualStyleBackColor = True
    '
    'btnResend
    '
    Me.btnResend.Location = New System.Drawing.Point(519, 122)
    Me.btnResend.Name = "btnResend"
    Me.btnResend.Size = New System.Drawing.Size(75, 23)
    Me.btnResend.TabIndex = 10
    Me.btnResend.Text = "Re-Send"
    Me.btnResend.UseVisualStyleBackColor = True
    '
    'timerStartupMinimize
    '
    Me.timerStartupMinimize.Interval = 5000
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(617, 170)
    Me.Controls.Add(Me.btnResend)
    Me.Controls.Add(Me.btnTime)
    Me.Controls.Add(Me.pgb)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtCurrent)
    Me.Controls.Add(Me.btnToTray)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtMinutes)
    Me.Controls.Add(Me.btnPath)
    Me.Controls.Add(Me.txtPath)
    Me.Controls.Add(Me.Label1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Main"
    Me.Text = "Wallpaper Changer"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents timerBG As Timer
  Friend WithEvents NotifyIcon1 As NotifyIcon
  Friend WithEvents Label1 As Label
  Friend WithEvents txtPath As TextBox
  Friend WithEvents btnPath As Button
  Friend WithEvents txtMinutes As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents btnToTray As Button
  Friend WithEvents txtCurrent As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents pgb As ProgressBar
  Friend WithEvents btnTime As Button
  Friend WithEvents btnResend As Button
  Friend WithEvents timerStartupMinimize As Timer
End Class
