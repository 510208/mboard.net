Imports System.Drawing.Drawing2D

Public Class frmLaunch
    Dim fadeStep As Integer = 0
    Dim fadeDuration As Integer = 100 ' 总共的时间步数，即 1 秒内的 50 毫秒间隔数
    Dim fadeDelay As Integer = 80 ' 2 秒的间隔时间，即 40 * 50 毫秒

    Private Sub frmLaunch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True ' 启用双缓冲以避免闪烁
        Me.Opacity = 0 ' 将表单的透明度设置为0，开始时表单是隐藏的
        fadeTimer.Start() ' 启动 Timer 控件
    End Sub

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        ' 淡入效果
        If fadeStep < fadeDuration Then
            fadeStep += 1
            Me.Opacity = fadeStep / fadeDuration
        ElseIf fadeStep = fadeDuration Then
            ' 等待2秒
            fadeStep += 1
        ElseIf fadeStep < fadeDuration + fadeDelay Then
            ' 淡出效果
            fadeStep += 1
            Me.Opacity = 1 - (fadeStep - fadeDuration - fadeDelay) / fadeDuration
        Else
            For i = 1 To 50
                ' 淡出效果
                fadeStep += 1
                Me.Opacity = 1 - (fadeStep - fadeDuration - fadeDelay) / fadeDuration
            Next

            fadeTimer.Stop() ' 停止 Timer 控件
            Form1.Show()

            Me.Close() ' 关闭表单
        End If
    End Sub
End Class
