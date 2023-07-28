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
End Class