Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Form1

    Dim nOldWndLeft, nOldWndTop, nClickX, nClickY As Integer
    Dim clickButton As Integer
    Dim hookButton As Keys = Keys.F6

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
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
        cbbButton.Text = cbbButton.SelectedItem
        lblSettingInfo.Text = $"{tmrClicker.Interval.ToString}/{cbbButton.SelectedItem}/SingleClick/F6"
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
        lblClickEnabled.Text = "運行連點"
    End Sub

    Private Sub pudPauseDown_ValueChanged(sender As Object, e As EventArgs) Handles pudPauseDown.ValueChanged
        tmrClicker.Interval = pudPauseDown.Value
        lblSettingInfo.Text = $"{tmrClicker.Interval.ToString}/{cbbButton.Text}/SingleClick/F6"
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrClicker.Enabled = True
        btnStop.Enabled = True
        btnStart.Enabled = False
        imgTrafficLight.Image = My.Resources.greenLight
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrClicker.Enabled = False
        btnStop.Enabled = False
        btnStart.Enabled = True
        lblClickEnabled.Text = "中斷連點"
        imgTrafficLight.Image = My.Resources.redLight
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
        imgTrafficLight.Image = My.Resources.redLight
        lblClickEnabled.Text = "中斷連點"
        lblSettingInfo.Text = $"{tmrClicker.Interval.ToString}/左鍵/SingleClick/F6"
    End Sub

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        '紀錄滑鼠點選時的視窗位置與滑鼠點選位置
        nOldWndLeft = Me.Left
        nOldWndTop = Me.Top
        nClickX = e.X
        nClickY = e.Y
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        If pnlHeader.Capture = True Then        '如果滑鼠按著拖曳
            '設定新的視窗位置
            Me.Top = e.Y + nOldWndTop - nClickY
            Me.Left = e.X + nOldWndLeft - nClickX
            '更新紀錄的視窗位置
            nOldWndLeft = Me.Left
            nOldWndTop = Me.Top
        End If
    End Sub

    ' Hook

    ' 委派類型
    Private Delegate Function KeyboardHookDelegate(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer

    ' 鉤子ID和委派實例
    Private Shared HookID As IntPtr = IntPtr.Zero
    Private KeyboardHook As KeyboardHookDelegate

    ' 鍵盤事件代碼
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_SYSKEYDOWN As Integer = &H104

    ' 鍵盤鉤子資料結構
    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As IntPtr
    End Structure

    ' 設置鍵盤鉤子
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As KeyboardHookDelegate, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function

    ' 解除鍵盤鉤子
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As Boolean
    End Function

    ' 呼叫下一個鉤子
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    End Function

    ' 處理鍵盤事件
    Private Function KeyboardHookProc(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
        ' 檢查是否按下F6鍵
        If nCode = 0 AndAlso (wParam = WM_KEYDOWN OrElse wParam = WM_SYSKEYDOWN) AndAlso lParam.vkCode = Keys.F6 Then
            ' 執行 checkClick 函數
            checkClick()
        End If

        ' 呼叫下一個鉤子
        Return CallNextHookEx(HookID, nCode, wParam, lParam)
    End Function

    ' F1鍵被按下時執行的函數
    Private Sub checkClick()
        ' 在這裡實現按下F1鍵時的操作
        btnStart.Enabled = Not (btnStart.Enabled)
        btnStop.Enabled = Not (btnStop.Enabled)
        tmrClicker.Enabled = Not (tmrClicker.Enabled)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        frmInfobox.show
    End Sub

    ' 啟動鍵盤鉤子
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 建立委派實例
        KeyboardHook = New KeyboardHookDelegate(AddressOf KeyboardHookProc)

        ' 取得目前執行緒ID
        Dim threadId As UInteger = GetCurrentThreadId()

        ' 設置鍵盤鉤子
        HookID = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHook, IntPtr.Zero, 0)
    End Sub

    ' 停止鍵盤鉤子
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 解除鍵盤鉤子
        UnhookWindowsHookEx(HookID)
    End Sub

    ' 取得目前執行的執行緒ID
    Private Function GetCurrentThreadId() As UInteger
        Return CUInt(System.Threading.Thread.CurrentThread.ManagedThreadId)
    End Function
End Class
