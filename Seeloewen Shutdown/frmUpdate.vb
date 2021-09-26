Imports System.Net
Public Class frmUpdate
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/latest_version_news.txt"), HttpWebRequest)
        request.Accept = "application/vnd.github.v3.raw"
        request.UserAgent = "Seeloewen Shutdown"

        Using response = request.GetResponse()
                Dim encoding = System.Text.ASCIIEncoding.UTF8

                Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                    rtbLatestVersionNews.Text = reader.ReadToEnd()
                End Using
            End Using
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
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
        If My.Computer.FileSystem.FileExists("SeeloewenShutdownUpdate.exe") Then
            My.Computer.FileSystem.DeleteFile("SeeloewenShutdownUpdate.exe")
        End If

        wc.DownloadFile(latest_download_link, "SeeloewenShutdownUpdate.exe")

        Process.Start("SeeloewenShutdownUpdate.exe")
        frmMain.Close()
    End Sub

    Private Sub btnIgnore_Click(sender As Object, e As EventArgs) Handles btnIgnore.Click
        Me.Close()
    End Sub
End Class