Public Class frmLaunchInfo
    Private Sub frmLaunchInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        rtbThanks.Text = My.Resources.thanks
    End Sub


    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Form1.Show()
        My.Settings.ShowInfobox = False
        Me.Close()
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        Me.Close()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("Rundll32.exe url.dll, FileProtocolHandler HTTPS://github.com/510208", vbNormalFocus)
    End Sub
End Class