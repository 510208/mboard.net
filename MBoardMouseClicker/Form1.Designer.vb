﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.pnlTitleBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblClickTurn = New System.Windows.Forms.Label()
        Me.btnInfo = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.lblSettingInfo = New System.Windows.Forms.Label()
        Me.lblClickEnabled = New System.Windows.Forms.Label()
        Me.imgTrafficLight = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbButton = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnEnd = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pudPauseDown = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnStop = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.tmrClicker = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ColorTransition1 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.imgTrafficLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pudPauseDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.BorderRadius = 30
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.Controls.Add(Me.lblClickTurn)
        Me.pnlTitleBar.Controls.Add(Me.btnInfo)
        Me.pnlTitleBar.Controls.Add(Me.lblSettingInfo)
        Me.pnlTitleBar.Controls.Add(Me.lblClickEnabled)
        Me.pnlTitleBar.Controls.Add(Me.imgTrafficLight)
        Me.pnlTitleBar.Controls.Add(Me.Label3)
        Me.pnlTitleBar.Controls.Add(Me.Label2)
        Me.pnlTitleBar.Controls.Add(Me.cbbButton)
        Me.pnlTitleBar.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlTitleBar.Controls.Add(Me.pnlHeader)
        Me.pnlTitleBar.Controls.Add(Me.Label1)
        Me.pnlTitleBar.Controls.Add(Me.pudPauseDown)
        Me.pnlTitleBar.Controls.Add(Me.btnStop)
        Me.pnlTitleBar.Controls.Add(Me.btnStart)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(274, 284)
        Me.pnlTitleBar.TabIndex = 2
        '
        'lblClickTurn
        '
        Me.lblClickTurn.BackColor = System.Drawing.Color.Transparent
        Me.lblClickTurn.Font = New System.Drawing.Font("微軟正黑體", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblClickTurn.Location = New System.Drawing.Point(92, 98)
        Me.lblClickTurn.Name = "lblClickTurn"
        Me.lblClickTurn.Size = New System.Drawing.Size(170, 16)
        Me.lblClickTurn.TabIndex = 19
        Me.lblClickTurn.Text = "連點次數：0"
        Me.lblClickTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnInfo
        '
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnInfo.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnInfo.Image = Global.MBoardMouseClicker.My.Resources.Resources.info
        Me.btnInfo.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnInfo.ImageRotate = 0!
        Me.btnInfo.Location = New System.Drawing.Point(222, 237)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnInfo.Size = New System.Drawing.Size(40, 35)
        Me.btnInfo.TabIndex = 18
        '
        'lblSettingInfo
        '
        Me.lblSettingInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingInfo.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSettingInfo.Location = New System.Drawing.Point(92, 76)
        Me.lblSettingInfo.Name = "lblSettingInfo"
        Me.lblSettingInfo.Size = New System.Drawing.Size(170, 22)
        Me.lblSettingInfo.TabIndex = 17
        Me.lblSettingInfo.Text = "N/A"
        Me.lblSettingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClickEnabled
        '
        Me.lblClickEnabled.Font = New System.Drawing.Font("微軟正黑體", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblClickEnabled.Location = New System.Drawing.Point(92, 45)
        Me.lblClickEnabled.Name = "lblClickEnabled"
        Me.lblClickEnabled.Size = New System.Drawing.Size(115, 31)
        Me.lblClickEnabled.TabIndex = 16
        Me.lblClickEnabled.Text = "中斷連點"
        Me.lblClickEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgTrafficLight
        '
        Me.imgTrafficLight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgTrafficLight.Image = Global.MBoardMouseClicker.My.Resources.Resources.redLight
        Me.imgTrafficLight.ImageRotate = 0!
        Me.imgTrafficLight.Location = New System.Drawing.Point(16, 45)
        Me.imgTrafficLight.Name = "imgTrafficLight"
        Me.imgTrafficLight.Size = New System.Drawing.Size(69, 69)
        Me.imgTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTrafficLight.TabIndex = 15
        Me.imgTrafficLight.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 33)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ms"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 36)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "連點按鍵(&B)："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbbButton
        '
        Me.cbbButton.BackColor = System.Drawing.Color.Transparent
        Me.cbbButton.BorderRadius = 15
        Me.cbbButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbButton.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbButton.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbButton.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbbButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbbButton.ItemHeight = 30
        Me.cbbButton.Items.AddRange(New Object() {"左鍵", "中鍵", "右鍵"})
        Me.cbbButton.Location = New System.Drawing.Point(127, 156)
        Me.cbbButton.Name = "cbbButton"
        Me.cbbButton.Size = New System.Drawing.Size(135, 36)
        Me.cbbButton.TabIndex = 12
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.MBoardMouseClicker.My.Resources.Resources.MBoard
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 11
        Me.Guna2PictureBox1.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlHeader.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlHeader.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlHeader.Controls.Add(Me.btnEnd)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(274, 25)
        Me.pnlHeader.TabIndex = 10
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(30, 7)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(138, 13)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "MBoard Mouse Clicker NET"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Navy
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(174, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox2.TabIndex = 12
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox1.Enabled = False
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Navy
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(207, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox1.TabIndex = 11
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.FillColor = System.Drawing.Color.Maroon
        Me.btnEnd.IconColor = System.Drawing.Color.White
        Me.btnEnd.Location = New System.Drawing.Point(240, 0)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(33, 25)
        Me.btnEnd.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "連點間隔(&P)："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pudPauseDown
        '
        Me.pudPauseDown.BackColor = System.Drawing.Color.Transparent
        Me.pudPauseDown.BorderRadius = 15
        Me.pudPauseDown.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pudPauseDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pudPauseDown.Location = New System.Drawing.Point(127, 117)
        Me.pudPauseDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.pudPauseDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pudPauseDown.Name = "pudPauseDown"
        Me.pudPauseDown.Size = New System.Drawing.Size(99, 33)
        Me.pudPauseDown.TabIndex = 6
        Me.pudPauseDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pudPauseDown.UpDownButtonForeColor = System.Drawing.Color.White
        Me.pudPauseDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnStop
        '
        Me.btnStop.BorderRadius = 15
        Me.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStop.Enabled = False
        Me.btnStop.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStop.Font = New System.Drawing.Font("微軟正黑體", 11.25!)
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(12, 237)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(184, 33)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "停止(&T)"
        '
        'btnStart
        '
        Me.btnStart.BorderRadius = 15
        Me.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStart.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("微軟正黑體", 11.25!)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(12, 198)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(250, 33)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "開始(&S)"
        '
        'tmrClicker
        '
        Me.tmrClicker.Interval = 5
        '
        'Guna2ColorTransition1
        '
        Me.Guna2ColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 284)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MBoard Main GUI"
        Me.pnlTitleBar.ResumeLayout(False)
        CType(Me.imgTrafficLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.pudPauseDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents pnlTitleBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStop As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tmrClicker As Timer
    Friend WithEvents pudPauseDown As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnEnd As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ColorTransition1 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents cbbButton As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSettingInfo As Label
    Friend WithEvents lblClickEnabled As Label
    Friend WithEvents imgTrafficLight As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnInfo As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lblClickTurn As Label
End Class
