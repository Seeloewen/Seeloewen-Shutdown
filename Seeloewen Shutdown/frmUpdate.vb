Imports System.Net
Public Class frmUpdate
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim githubToken = My.Settings.GithubToken
        Dim request = CType(WebRequest.Create("https://api.github.com/repos/Seeloewen/Seeloewen-Shutdown/contents/latest_version_news.txt"), HttpWebRequest)
        request.Headers.Add(HttpRequestHeader.Authorization, String.Concat("token ", githubToken))
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
        Dim githubToken = My.Settings.GithubToken
        Dim latest_download_link As String
        Dim request = CType(WebRequest.Create("https://api.github.com/repos/Seeloewen/Seeloewen-Shutdown/contents/latest_download_link.txt"), HttpWebRequest)
        request.Headers.Add(HttpRequestHeader.Authorization, String.Concat("token ", githubToken))
        request.Accept = "application/vnd.github.v3.raw"
        request.UserAgent = "Seeloewen Shutdown"

        Using response = request.GetResponse()
            Dim encoding = System.Text.ASCIIEncoding.UTF8

            Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                latest_download_link = reader.ReadToEnd()
            End Using
        End Using

        Process.Start(latest_download_link)

        frmMain.Close()
    End Sub

    Private Sub btnIgnore_Click(sender As Object, e As EventArgs) Handles btnIgnore.Click
        Me.Close()
    End Sub
End Class