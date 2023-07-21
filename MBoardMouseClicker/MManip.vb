Option Explicit On

Imports System.Runtime.InteropServices

Module MouseClick

    'API 定義
    Public Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32,
ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)

    '點擊程式 mouse_event MOUSEEVENTF_LEFTDOWN Or MOUSEEVENTF_LEFTUP, 0, 0, 0, 0
    '右鍵點擊程式 mouse_event MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0
    Const MOUSEEVENTF_LEFTDOWN = &H2 '左鍵按下
    Const MOUSEEVENTF_LEFTUP = &H4 '左鍵彈起
    Const MOUSEEVENTF_MIDDLEDOWN = &H20 '中鍵按下
    Const MOUSEEVENTF_MIDDLEUP = &H40 '中鍵彈起
    Const MOUSEEVENTF_MOVE = &H1 '移動鼠標
    Const MOUSEEVENTF_ABSOLUTE = &H8000 '鼠標指定絕對座標
    Const MOUSEEVENTF_RIGHTDOWN = &H8 '右鍵按下
    Const MOUSEEVENTF_RIGHTUP = &H10 '右鍵彈起

    Sub LeftClick()
        mouse_event(MOUSEEVENTF_LEFTDOWN Or MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) '左鍵按下,彈起
    End Sub

    Sub MiddleClick()
        mouse_event(MOUSEEVENTF_MIDDLEDOWN Or MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0) '中鍵按下，彈起
    End Sub

    Sub RightClick()
        mouse_event(MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0) '右鍵按下，彈起
    End Sub
End Module