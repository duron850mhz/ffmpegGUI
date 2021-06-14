<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstTarget = New System.Windows.Forms.ListBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblExtract = New System.Windows.Forms.Label()
        Me.txtExtract = New System.Windows.Forms.TextBox()
        Me.btnExtractRef = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.pgb = New System.Windows.Forms.ProgressBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblFfmpegPath = New System.Windows.Forms.Label()
        Me.txtFfmpegPath = New System.Windows.Forms.TextBox()
        Me.btnFfmpegPathRef = New System.Windows.Forms.Button()
        Me.lblFfmpegOption = New System.Windows.Forms.Label()
        Me.txtFfmpegOption = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTarget
        '
        Me.lstTarget.AllowDrop = True
        Me.lstTarget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTarget.FormattingEnabled = True
        Me.lstTarget.ItemHeight = 12
        Me.lstTarget.Location = New System.Drawing.Point(3, 15)
        Me.lstTarget.Name = "lstTarget"
        Me.lstTarget.Size = New System.Drawing.Size(280, 244)
        Me.lstTarget.TabIndex = 0
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Location = New System.Drawing.Point(3, 0)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(116, 12)
        Me.lblTarget.TabIndex = 1
        Me.lblTarget.Text = "対象ファイル or フォルダ"
        '
        'lblExtract
        '
        Me.lblExtract.AutoSize = True
        Me.lblExtract.Location = New System.Drawing.Point(3, 0)
        Me.lblExtract.Name = "lblExtract"
        Me.lblExtract.Size = New System.Drawing.Size(41, 12)
        Me.lblExtract.TabIndex = 2
        Me.lblExtract.Text = "出力先"
        '
        'txtExtract
        '
        Me.txtExtract.AllowDrop = True
        Me.txtExtract.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExtract.Location = New System.Drawing.Point(5, 15)
        Me.txtExtract.Name = "txtExtract"
        Me.txtExtract.Size = New System.Drawing.Size(255, 19)
        Me.txtExtract.TabIndex = 3
        '
        'btnExtractRef
        '
        Me.btnExtractRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExtractRef.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExtractRef.Location = New System.Drawing.Point(260, 15)
        Me.btnExtractRef.Name = "btnExtractRef"
        Me.btnExtractRef.Size = New System.Drawing.Size(19, 19)
        Me.btnExtractRef.TabIndex = 4
        Me.btnExtractRef.Text = "..."
        Me.btnExtractRef.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(509, 278)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "実行"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(12, 278)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "終了"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'pgb
        '
        Me.pgb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgb.Location = New System.Drawing.Point(93, 278)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(410, 23)
        Me.pgb.Step = 1
        Me.pgb.TabIndex = 7
        Me.pgb.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTarget)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstTarget)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblFfmpegOption)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFfmpegOption)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnFfmpegPathRef)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblFfmpegPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFfmpegPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblExtract)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtExtract)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExtractRef)
        Me.SplitContainer1.Size = New System.Drawing.Size(572, 260)
        Me.SplitContainer1.SplitterDistance = 286
        Me.SplitContainer1.TabIndex = 8
        '
        'lblFfmpegPath
        '
        Me.lblFfmpegPath.AutoSize = True
        Me.lblFfmpegPath.Location = New System.Drawing.Point(3, 37)
        Me.lblFfmpegPath.Name = "lblFfmpegPath"
        Me.lblFfmpegPath.Size = New System.Drawing.Size(94, 12)
        Me.lblFfmpegPath.TabIndex = 5
        Me.lblFfmpegPath.Text = "ffmpeg.exeの場所"
        '
        'txtFfmpegPath
        '
        Me.txtFfmpegPath.AllowDrop = True
        Me.txtFfmpegPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFfmpegPath.Location = New System.Drawing.Point(5, 52)
        Me.txtFfmpegPath.Name = "txtFfmpegPath"
        Me.txtFfmpegPath.Size = New System.Drawing.Size(255, 19)
        Me.txtFfmpegPath.TabIndex = 6
        '
        'btnFfmpegPathRef
        '
        Me.btnFfmpegPathRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFfmpegPathRef.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFfmpegPathRef.Location = New System.Drawing.Point(260, 52)
        Me.btnFfmpegPathRef.Name = "btnFfmpegPathRef"
        Me.btnFfmpegPathRef.Size = New System.Drawing.Size(19, 19)
        Me.btnFfmpegPathRef.TabIndex = 7
        Me.btnFfmpegPathRef.Text = "..."
        Me.btnFfmpegPathRef.UseVisualStyleBackColor = True
        '
        'lblFfmpegOption
        '
        Me.lblFfmpegOption.AutoSize = True
        Me.lblFfmpegOption.Location = New System.Drawing.Point(3, 74)
        Me.lblFfmpegOption.Name = "lblFfmpegOption"
        Me.lblFfmpegOption.Size = New System.Drawing.Size(113, 12)
        Me.lblFfmpegOption.TabIndex = 8
        Me.lblFfmpegOption.Text = "ffmpeg.exeのオプション"
        '
        'txtFfmpegOption
        '
        Me.txtFfmpegOption.AllowDrop = True
        Me.txtFfmpegOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFfmpegOption.Location = New System.Drawing.Point(5, 89)
        Me.txtFfmpegOption.Name = "txtFfmpegOption"
        Me.txtFfmpegOption.Size = New System.Drawing.Size(274, 19)
        Me.txtFfmpegOption.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(596, 313)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pgb)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmMain"
        Me.Text = "ffmepgGUI"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTarget As ListBox
    Friend WithEvents lblTarget As Label
    Friend WithEvents lblExtract As Label
    Friend WithEvents txtExtract As TextBox
    Friend WithEvents btnExtractRef As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents pgb As ProgressBar
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnFfmpegPathRef As Button
    Friend WithEvents lblFfmpegPath As Label
    Friend WithEvents txtFfmpegPath As TextBox
    Friend WithEvents lblFfmpegOption As Label
    Friend WithEvents txtFfmpegOption As TextBox
End Class
