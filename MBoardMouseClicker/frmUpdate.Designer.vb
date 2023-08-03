<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNoUpdate = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblNowVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 49)
        Me.Panel1.TabIndex = 1
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("微軟正黑體", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.Location = New System.Drawing.Point(12, 9)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(491, 37)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Label1"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Controls.Add(Me.btnNoUpdate)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 57)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.WebBrowser1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(515, 287)
        Me.Panel3.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(515, 287)
        Me.WebBrowser1.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(363, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 24)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "更新到最新版本(&U)"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNoUpdate
        '
        Me.btnNoUpdate.Location = New System.Drawing.Point(255, 6)
        Me.btnNoUpdate.Name = "btnNoUpdate"
        Me.btnNoUpdate.Size = New System.Drawing.Size(102, 24)
        Me.btnNoUpdate.TabIndex = 1
        Me.btnNoUpdate.Text = "暫不更新(&N)"
        Me.btnNoUpdate.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNowVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 35)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(515, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblNowVersion
        '
        Me.lblNowVersion.Name = "lblNowVersion"
        Me.lblNowVersion.Size = New System.Drawing.Size(90, 17)
        Me.lblNowVersion.Text = "當前版本：N/A"
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 393)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpdate"
        Me.Text = "更新檢查器 GUI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblVersion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnNoUpdate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblNowVersion As ToolStripStatusLabel
End Class
