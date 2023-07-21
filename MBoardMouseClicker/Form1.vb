Imports System.ComponentModel

Public Class Form1

    Dim nOldWndLeft, nOldWndTop, nClickX, nClickY As Integer
    Dim clickButton As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs)
        btnEnd.ForeColor = Color.FromArgb(255, 128, 128)
        End
    End Sub

    Private Sub pnlTitleBar_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDown
        '紀錄滑鼠點選時的視窗位置與滑鼠點選位置
        nOldWndLeft = Me.Left
        nOldWndTop = Me.Top
        nClickX = e.X
        nClickY = e.Y
    End Sub

    Private Sub pnlTitleBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
        If pnlTitleBar.Capture = True Then        '如果滑鼠按著拖曳
            '設定新的視窗位置
            Me.Top = e.Y + nOldWndTop - nClickY
            Me.Left = e.X + nOldWndLeft - nClickX
            '更新紀錄的視窗位置
            nOldWndLeft = Me.Left
            nOldWndTop = Me.Top
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        tmrClicker.Enabled = False
    End Sub

    Private Sub cbbButton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbButton.SelectedIndexChanged
        clickButton = cbbButton.SelectedIndex
    End Sub

    Private Sub tmrClicker_Tick(sender As Object, e As EventArgs) Handles tmrClicker.Tick
        Select Case clickButton
            Case 0
                LeftClick()
            Case 1
                MiddleClick()
            Case 2
                RightClick()
        End Select
    End Sub

    Private Sub pudPauseDown_ValueChanged(sender As Object, e As EventArgs) Handles pudPauseDown.ValueChanged
        tmrClicker.Interval = pudPauseDown.Value
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrClicker.Enabled = True
        btnStop.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrClicker.Enabled = False
        btnStop.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub btnEnd_MouseEnter(sender As Object, e As EventArgs)
        btnEnd.ForeColor = Color.Red
    End Sub

    Private Sub btnEnd_MouseLeave(sender As Object, e As EventArgs)
        btnEnd.ForeColor = Color.Maroon
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cbbButton.SelectedIndex = 0
        Me.TopMost = True
    End Sub
End Class
