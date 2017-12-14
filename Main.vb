
Imports System.Runtime.InteropServices

Public Class Main

  Private Const SPI_SETDESKWALLPAPER As Integer = &H14
  Private Const SPIF_SENDCHANGE As Integer = &H2
  Private Const SPIF_UPDATEINIFILE As Integer = &H1

  Private m_listPics As List(Of String)
  Private m_strNextFile As String
  Private m_strApp As String = "Backgrounds"
  Private m_strSettings As String = "Settings"

  Dim nRes

  Sub New()
    Dim t As Integer

    InitializeComponent()

    txtPath.Text = GetSetting(m_strApp, m_strSettings, "Path", "")
    txtMinutes.Text = GetSetting(m_strApp, m_strSettings, "Minutes", "30")

    If Integer.TryParse(txtMinutes.Text, t) = True Then
      SetTime(t)
    Else
      MsgBox("Unable to parse previously saved minutes.", MsgBoxStyle.Information)
      Return
    End If

    If LoadFiles() = True Then
      m_strNextFile = GetSetting(m_strApp, m_strSettings, "NextPicture", "")
      If m_strNextFile = "" Then
        m_strNextFile = m_listPics(0)
      End If
      ChangeBackground()
      timerStartupMinimize.Enabled = True
    End If

  End Sub

  Private Function LoadFiles() As Boolean
    Dim file As IO.FileInfo
    Dim dir As IO.DirectoryInfo

    If txtPath.Text.Trim = "" Then
      MsgBox("Image path is blank", MsgBoxStyle.Information)
      Return False
    End If

    If IO.Directory.Exists(txtPath.Text) = False Then
      MsgBox("Directory does not exist, " & txtPath.Text, MsgBoxStyle.Information)
      Return False
    End If

    m_listPics = New List(Of String)
    dir = New IO.DirectoryInfo(txtPath.Text)
    For Each file In dir.GetFiles("*.jpg")
      m_listPics.Add(file.FullName)
    Next
    m_listPics.Sort()
    If m_listPics.Count = 0 Then MsgBox("No 'jpg' images found in " & txtPath.Text, MsgBoxStyle.Information) : Return False
    Return True
  End Function


  Private Sub ChangeBackground()
    Dim s As String
    Dim bNext As Boolean

    If m_strNextFile = "" Then MsgBox("Next file variable is empty", MsgBoxStyle.Information) : Return
    If m_listPics.Count = 0 Then MsgBox("List of files is empty", MsgBoxStyle.Information) : Return

    SubmitWallpaper(m_strNextFile)
    txtCurrent.Text = m_strNextFile

    bNext = False
    For Each s In m_listPics
      If bNext = True Then
        m_strNextFile = s
        SaveSetting(m_strApp, m_strSettings, "NextPicture", m_strNextFile)
        Return
      End If
      If s.ToLower = m_strNextFile.ToLower Then bNext = True
    Next
    m_strNextFile = m_listPics(0)
    SaveSetting(m_strApp, m_strSettings, "NextPicture", m_strNextFile)

  End Sub

  Private Sub timerBG_Tick(sender As Object, e As EventArgs) Handles timerBG.Tick
    Dim i As Integer

    pgb.Value += 1
    If pgb.Value = pgb.Maximum Then
      ChangeBackground()
      pgb.Value = 0
    End If

  End Sub

  Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
    Dim dlg As FolderBrowserDialog
    Dim ret As DialogResult

    dlg = New FolderBrowserDialog
    ret = dlg.ShowDialog()
    If ret = DialogResult.OK Then
      txtPath.Text = dlg.SelectedPath
      If LoadFiles() = True Then
        SaveSetting(m_strApp, m_strSettings, "Path", txtPath.Text)
        m_strNextFile = m_listPics(0)
      End If
      ChangeBackground()
    End If
    dlg.Dispose()

  End Sub

  <DllImport("user32.dll", CharSet:=CharSet.Auto)> Shared Function SystemParametersInfo(ByVal uiAction As Integer, ByVal uiParam As Integer, ByVal strParam As String, ByVal intWinINIFlag As Integer) As Integer
  End Function

  Private Sub btnToTray_Click(sender As Object, e As EventArgs) Handles btnToTray.Click
    Me.Visible = False
  End Sub

  Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
    Me.Visible = True
  End Sub

  Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
    Dim n As Integer

    If Integer.TryParse(txtMinutes.Text, n) = False Then
      MsgBox("Minutes not an integer", MsgBoxStyle.Information)
      Return
    End If

    If n < 1 Or n > 60 * 24 * 7 Then
      MsgBox("Minutes is out of range, try within 1 and a few days", MsgBoxStyle.Information)
      Return
    End If

    SaveSetting(m_strApp, m_strSettings, "Minutes", n.ToString)
    SetTime(n)

  End Sub

  Private Sub SetTime(ByVal t As Integer)

    timerBG.Interval = 1000 * 60  ' 30 minutes
    pgb.Maximum = t

  End Sub

  Private Sub SubmitWallpaper(ByVal strFile As String)
    Dim ret As Integer
    Dim img As Image
    Dim strImg As String = txtPath.Text & "\Background.bmp"

    img = Image.FromFile(strFile)
    img.Save(strImg, Imaging.ImageFormat.Bmp)
    img.Dispose()
    img = Nothing


    ret = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, strImg, SPIF_SENDCHANGE Or SPIF_UPDATEINIFILE)

  End Sub

  Private Sub btnResend_Click(sender As Object, e As EventArgs) Handles btnResend.Click
    If txtCurrent.Text = "" Then MsgBox("No current picture", MsgBoxStyle.Information) : Return

    SubmitWallpaper(txtCurrent.Text)

  End Sub

  Private Sub timerStartupMinimize_Tick(sender As Object, e As EventArgs) Handles timerStartupMinimize.Tick
    Me.Visible = False
    timerStartupMinimize.Enabled = False
  End Sub

End Class
