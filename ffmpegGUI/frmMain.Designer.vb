<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstTarget = New System.Windows.Forms.ListBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblExtract = New System.Windows.Forms.Label()
        Me.txtExtract = New System.Windows.Forms.TextBox()
        Me.btnExtractRef = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblFfmpegOption = New System.Windows.Forms.Label()
        Me.txtFfmpegOption = New System.Windows.Forms.TextBox()
        Me.btnFfmpegPathRef = New System.Windows.Forms.Button()
        Me.lblFfmpegPath = New System.Windows.Forms.Label()
        Me.txtFfmpegPath = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.rbFront = New System.Windows.Forms.RadioButton()
        Me.rbRear = New System.Windows.Forms.RadioButton()
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
        Me.lstTarget.TabIndex = 1
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Location = New System.Drawing.Point(3, 0)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(116, 12)
        Me.lblTarget.TabIndex = 0
        Me.lblTarget.Text = "対象ファイル or フォルダ"
        '
        'lblExtract
        '
        Me.lblExtract.AutoSize = True
        Me.lblExtract.Location = New System.Drawing.Point(3, 0)
        Me.lblExtract.Name = "lblExtract"
        Me.lblExtract.Size = New System.Drawing.Size(41, 12)
        Me.lblExtract.TabIndex = 0
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
        Me.txtExtract.TabIndex = 1
        '
        'btnExtractRef
        '
        Me.btnExtractRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExtractRef.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExtractRef.Location = New System.Drawing.Point(260, 15)
        Me.btnExtractRef.Name = "btnExtractRef"
        Me.btnExtractRef.Size = New System.Drawing.Size(19, 19)
        Me.btnExtractRef.TabIndex = 2
        Me.btnExtractRef.Text = "..."
        Me.btnExtractRef.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(509, 278)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
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
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "終了"
        Me.btnQuit.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbRear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbFront)
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
        Me.SplitContainer1.TabIndex = 0
        '
        'lblFfmpegOption
        '
        Me.lblFfmpegOption.AutoSize = True
        Me.lblFfmpegOption.Location = New System.Drawing.Point(3, 130)
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
        Me.txtFfmpegOption.Location = New System.Drawing.Point(5, 145)
        Me.txtFfmpegOption.Name = "txtFfmpegOption"
        Me.txtFfmpegOption.Size = New System.Drawing.Size(274, 19)
        Me.txtFfmpegOption.TabIndex = 9
        '
        'btnFfmpegPathRef
        '
        Me.btnFfmpegPathRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFfmpegPathRef.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFfmpegPathRef.Location = New System.Drawing.Point(260, 108)
        Me.btnFfmpegPathRef.Name = "btnFfmpegPathRef"
        Me.btnFfmpegPathRef.Size = New System.Drawing.Size(19, 19)
        Me.btnFfmpegPathRef.TabIndex = 7
        Me.btnFfmpegPathRef.Text = "..."
        Me.btnFfmpegPathRef.UseVisualStyleBackColor = True
        '
        'lblFfmpegPath
        '
        Me.lblFfmpegPath.AutoSize = True
        Me.lblFfmpegPath.Location = New System.Drawing.Point(3, 93)
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
        Me.txtFfmpegPath.Location = New System.Drawing.Point(5, 108)
        Me.txtFfmpegPath.Name = "txtFfmpegPath"
        Me.txtFfmpegPath.Size = New System.Drawing.Size(255, 19)
        Me.txtFfmpegPath.TabIndex = 6
        '
        'btnLog
        '
        Me.btnLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLog.Location = New System.Drawing.Point(428, 278)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 2
        Me.btnLog.Text = "ログ表示"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(347, 278)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "初期化"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'rbFront
        '
        Me.rbFront.AutoSize = True
        Me.rbFront.Checked = True
        Me.rbFront.Location = New System.Drawing.Point(5, 40)
        Me.rbFront.Name = "rbFront"
        Me.rbFront.Size = New System.Drawing.Size(47, 16)
        Me.rbFront.TabIndex = 3
        Me.rbFront.TabStop = True
        Me.rbFront.Text = "前方"
        Me.rbFront.UseVisualStyleBackColor = True
        '
        'rbRear
        '
        Me.rbRear.AutoSize = True
        Me.rbRear.Location = New System.Drawing.Point(58, 40)
        Me.rbRear.Name = "rbRear"
        Me.rbRear.Size = New System.Drawing.Size(47, 16)
        Me.rbRear.TabIndex = 4
        Me.rbRear.Text = "後方"
        Me.rbRear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(596, 313)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.SplitContainer1)
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
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnFfmpegPathRef As Button
    Friend WithEvents lblFfmpegPath As Label
    Friend WithEvents txtFfmpegPath As TextBox
    Friend WithEvents lblFfmpegOption As Label
    Friend WithEvents txtFfmpegOption As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents rbRear As RadioButton
    Friend WithEvents rbFront As RadioButton
End Class
