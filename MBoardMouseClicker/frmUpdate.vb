Imports System.Diagnostics
Imports Markdig
#Disable Warning BC40056 ' Imports 陳述式中指定的命名空間或類型，不包含任何 Public 成員，或找不到該命名空間或類型
Imports TheArtOfDev.HtmlRenderer.WinForms
#Enable Warning BC40056 ' Imports 陳述式中指定的命名空間或類型，不包含任何 Public 成員，或找不到該命名空間或類型
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
        Dim pythonScript As String = "update.py"

        Dim processInfo As New ProcessStartInfo("python.exe", $"{pythonScript} {owner} {repo}")
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
        If lines(0) > latestVer Then
            latestVer = lines(0)
            lblVersion.Text = $"最新版本：{latestVer}"
            lblVersion.ForeColor = ColorTranslator.FromOle(QBColor(4))
        Else
            lblVersion.Text = $"最新版本：{latestVer}(不需更新)"
            lblVersion.ForeColor = ColorTranslator.FromOle(QBColor(2))
        End If

        lblNowVersion.Text = My.Application.Info.Version.ToString

        ' 获取HTML文本
        Dim htmlText As String = lines(1)

        ' 将HTML文本加载到WebBrowser控件中
        WebBrowser1.DocumentText = htmlText

        Return "True"

    End Function

End Class
