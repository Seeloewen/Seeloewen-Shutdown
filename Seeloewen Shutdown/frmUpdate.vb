Imports System.Net
Imports System.Environment

Public Class frmUpdate

    Dim Changelog As String
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Private Async Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Design = "dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            rtbLatestVersionNews.BackColor = Color.FromArgb(41, 41, 41)
            pbBackground.BackColor = Color.FromArgb(30, 30, 30)
            rtbLatestVersionNews.ForeColor = Color.White
            lblHeader.ForeColor = Color.White
        End If

        If My.Settings.Language = "English" Then
            lblHeader.Text = "An update is available!"
            btnIgnore.Text = "Ignore"
            btnDownload.Text = "Download"
            Text = "Update"
        End If

        Await Task.Run(Sub() GetUpdateNews())

        rtbLatestVersionNews.Text = Changelog
    End Sub

    Private Async Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If My.Settings.Language = "German" Then
            btnDownload.Text = "Herunterladen..."
        ElseIf My.Settings.Language = "English" Then
            btnDownload.Text = "Downloading..."
        End If

        btnDownload.Enabled = False

        Await Task.Run(Sub() DownloadUpdate())

        Process.Start(AppData + "/Seeloewen Shutdown/SeeloewenShutdownUpdate.exe")
        frmMain.Close()
        btnDownload.Enabled = True

        If My.Settings.Language = "German" Then
            btnDownload.Text = "Herunterladen"
        ElseIf My.Settings.Language = "English" Then
            btnDownload.Text = "Download"
        End If
    End Sub

    Private Sub DownloadUpdate()
        Dim latest_download_link As String
        Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/latest_download_link.txt"), HttpWebRequest)

        request.Accept = "application/vnd.github.v3.raw"
        request.UserAgent = "Seeloewen Shutdown"

        Using response = request.GetResponse()
            Dim encoding = System.Text.ASCIIEncoding.UTF8

            Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                latest_download_link = reader.ReadToEnd()
            End Using
        End Using

        Dim wc As New WebClient()
        If My.Computer.FileSystem.DirectoryExists(AppData + "/Seeloewen Shutdown") = False Then
            My.Computer.FileSystem.CreateDirectory(AppData + "/Seeloewen Shutdown")
        End If

        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/SeeloewenShutdownUpdate.exe") Then
            My.Computer.FileSystem.DeleteFile(AppData + "/Seeloewen Shutdown/SeeloewenShutdownUpdate.exe")
        End If

        wc.DownloadFile(latest_download_link, AppData + "/Seeloewen Shutdown/SeeloewenShutdownUpdate.exe")
        frmMain.Close()
    End Sub
    Private Sub GetUpdateNews()
        If My.Settings.Language = "English" Then
            Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/latest_version_news.txt"), HttpWebRequest)
            request.Accept = "application/vnd.github.v3.raw"
            request.UserAgent = "Seeloewen Shutdown"

            Using response = request.GetResponse()
                Dim encoding = System.Text.ASCIIEncoding.UTF8

                Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                    Changelog = reader.ReadToEnd()
                End Using
            End Using
        ElseIf My.Settings.Language = "German" Then
            Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/latest_version_news_german.txt"), HttpWebRequest)
            request.Accept = "application/vnd.github.v3.raw"
            request.UserAgent = "Seeloewen Shutdown"

            Using response = request.GetResponse()
                Dim encoding = System.Text.ASCIIEncoding.UTF8

                Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                    Changelog = reader.ReadToEnd()
                End Using
            End Using
        End If
    End Sub

    Private Sub btnIgnore_Click(sender As Object, e As EventArgs) Handles btnIgnore.Click
        Me.Close()
    End Sub

    Private Sub btnIgnore_MouseDown(sender As Object, e As MouseEventArgs) Handles btnIgnore.MouseDown
        btnIgnore.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnIgnore_MouseHover(sender As Object, e As EventArgs) Handles btnIgnore.MouseHover
        btnIgnore.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnIgnore_MouseLeave(sender As Object, e As EventArgs) Handles btnIgnore.MouseLeave
        btnIgnore.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnIgnore_MouseUp(sender As Object, e As MouseEventArgs) Handles btnIgnore.MouseUp
        btnIgnore.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnDownload_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDownload.MouseDown
        btnDownload.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnDownload_MouseHover(sender As Object, e As EventArgs) Handles btnDownload.MouseHover
        btnDownload.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnDownload_MouseLeave(sender As Object, e As EventArgs) Handles btnDownload.MouseLeave
        btnDownload.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnDownload_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDownload.MouseUp
        btnDownload.BackgroundImage = My.Resources.button
    End Sub
End Class