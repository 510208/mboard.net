Imports System.Diagnostics
Imports Markdig
Imports System.IO

Public Class frmUpdate

    Dim latestVer As String = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}{My.Application.Info.Version.Revision}"
    Private Sub frmUpdate_Actived(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' 调用Python脚本并获取更新日志和最新版本
        Dim i As String = RunPythonScript()
    End Sub

    Private Function RunPythonScript() As String
        Dim owner As String = "510208"
        Dim repo As String = "mboard.net"
        Dim pythonScript As String = "update.exe"

        Dim processInfo As New ProcessStartInfo("update.exe")
        processInfo.CreateNoWindow = True
        processInfo.UseShellExecute = False
        processInfo.RedirectStandardOutput = True

        Dim result As String = ""
        Using process As Process = Process.Start(processInfo)
            Using reader As System.IO.StreamReader = process.StandardOutput
                result = reader.ReadToEnd()
            End Using
        End Using

        ' 切分返回值的第一行和其余部分
        Dim lines As String() = result.Split(Environment.NewLine.ToCharArray(), 2)

        ' 获取最新版本
        If lines(0) > latestVer Then ' 需要更新
            latestVer = lines(0)
            lblVersion.Text = $"最新版本：{latestVer}"
            lblVersion.ForeColor = ColorTranslator.FromOle(QBColor(4))
            btnUpdate.Enabled = True
        Else                          ' 不需更新
            lblVersion.Text = $"最新版本：{latestVer}(不需更新)"
            lblVersion.ForeColor = ColorTranslator.FromOle(QBColor(2))
            btnUpdate.Enabled = False
        End If

        lblNowVersion.Text = My.Application.Info.Version.ToString

        ' 获取HTML文本
        Dim htmlText As String = lines(1)

        ' 将HTML文本加载到WebBrowser控件中
        WebBrowser1.DocumentText = htmlText

        Return "True"

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Shell("explorer https://github.com/510208/mboard.net/releases/latest ", vbNormalFocus)
    End Sub

    Private Sub btnNoUpdate_Click(sender As Object, e As EventArgs) Handles btnNoUpdate.Click
        Me.Close()
    End Sub
End Class
