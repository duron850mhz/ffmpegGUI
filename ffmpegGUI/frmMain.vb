Imports System.IO

Public Class frmMain
    Private Enum rw
        read
        write
    End Enum

    ''' <summary>
    ''' 初期化
    ''' </summary>
    Private Sub I_Init()
        lstTarget.Items.Clear()
        pgb.Value = 0
        pgb.Visible = False
    End Sub

    ''' <summary>
    ''' でーたせっと
    ''' </summary>
    ''' <param name="rw"></param>
    Private Sub I_DataSet(ByVal rw As rw)
        Select Case rw
            Case rw.read
                Try
                    txtExtract.Text = API_ReadINI(ZZV_INI_Section_Setting, ZZV_INI_Entry_Extract)
                    txtFfmpegPath.Text = API_ReadINI(ZZV_INI_Section_Setting, ZZV_INI_Entry_FfmpegPath)
                    txtFfmpegOption.Text = API_ReadINI(ZZV_INI_Section_Setting, ZZV_INI_Entry_FfmpegOption)

                    If txtFfmpegOption.Text = "" Then
                        txtFfmpegOption.Text = " -c:v hevc -pix_fmt yuvj420p -s 640x360"
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Case rw.write
                Try
                    Call API_WriteIni(ZZV_INI_Section_Setting, ZZV_INI_Entry_Extract, txtExtract.Text)
                    Call API_WriteIni(ZZV_INI_Section_Setting, ZZV_INI_Entry_FfmpegPath, txtFfmpegPath.Text)
                    Call API_WriteIni(ZZV_INI_Section_Setting, ZZV_INI_Entry_FfmpegOption, txtFfmpegOption.Text)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
        End Select
    End Sub

    ''' <summary>
    ''' れっつ　えんこーど
    ''' </summary>
    Private Function I_Encode(ByVal strTarget As String) As Boolean
        Dim bRet As Boolean = True

        Try
            'ファイルのフルパス取得
            Dim strEnc As String = Path.Combine(txtExtract.Text, Path.ChangeExtension(Path.GetFileName(strTarget), ".mp4"))
            '元ファイルの日時覚えましょ
            Dim dtOrg As Date = File.GetLastWriteTime(strTarget)
            'あったら削除
            If File.Exists(strEnc) = True Then
                File.Delete(strEnc)
            End If
            'れっつごー
            Dim psi As New System.Diagnostics.ProcessStartInfo()
            psi.FileName = txtFfmpegPath.Text
            psi.Arguments = " -i " & """" & strTarget & """ " & txtFfmpegOption.Text & " """ & strEnc & """"
            psi.WindowStyle = ProcessWindowStyle.Minimized
            Dim p As Process = Process.Start(psi)
            p.WaitForExit()
            '元ファイルの日時にあわせるで
            File.SetLastWriteTime(strEnc, dtOrg)
        Catch ex As Exception
            bRet = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return bRet
    End Function

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        Call I_DataSet(rw.read)
    End Sub

    ''' <summary>
    ''' Form Closing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call I_DataSet(rw.write)
    End Sub

    ''' <summary>
    ''' lstTargetにDragしてみる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstTarget_DragEnter(sender As Object, e As DragEventArgs) Handles lstTarget.DragEnter
        'ファイルかフォルダかな
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'せやで
            e.Effect = DragDropEffects.Copy
        Else
            'せやろか
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ''' <summary>
    ''' lstTargetにDropしてみる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstTarget_DragDrop(sender As Object, e As DragEventArgs) Handles lstTarget.DragDrop
        'なにいれたん
        Dim strFileNames As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        'くるくる～
        For Each strFN In strFileNames
            'フォルダかいな
            If Directory.Exists(strFN) = True Then
                'ぽいぽい
                Call I_AddFiles(strFN)
            Else
                'ファイルやわ
                lstTarget.Items.Add(strFN)
            End If
        Next

        lstTarget.Sorted = True
    End Sub

    ''' <summary>
    ''' ふぁいるついかやで
    ''' </summary>
    ''' <param name="strDirectory"></param>
    Private Sub I_AddFiles(ByVal strDirectory As String)
        'ファイルをいれるで
        Dim strFs As String() = Directory.GetFiles(strDirectory)
        'くるりんぱ～
        For Each strF In strFs
            If lstTarget.Items.Contains(strF) = False Then
                lstTarget.Items.Add(strF)
            Else
                'もうあるやんけ
            End If
        Next

        'フォルダもあるんかいな
        Dim strDs As String() = Directory.GetDirectories(strDirectory)
        'さいきよびだしやで～
        For Each strD In strDs
            If lstTarget.Items.Contains(strD) = False Then
                Call I_AddFiles(strD)
            Else
                'もうあるやんけ
            End If
        Next
    End Sub

    ''' <summary>
    ''' 出力先にポイしようとしているやで
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtExtract_DragEnter(sender As Object, e As DragEventArgs) Handles txtExtract.DragEnter
        e.Effect = DragDropEffects.None
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ''' <summary>
    ''' 出力先にポイしたやで
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtExtract_DragDrop(sender As Object, e As DragEventArgs) Handles txtExtract.DragDrop
        Dim strFileNames As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        '存在するフォルダ限定やで
        If Directory.Exists(strFileNames(0)) = True Then
            txtExtract.Text = strFileNames(0)
        End If
    End Sub

    ''' <summary>
    ''' 出力先参照やで
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExtractRef_Click(sender As Object, e As EventArgs) Handles btnExtractRef.Click
        Using fbd As New FolderBrowserDialog
            fbd.Description = "出力先フォルダを指定してください。"
            fbd.RootFolder = Environment.SpecialFolder.Desktop
            If txtExtract.Text <> "" Then
                fbd.SelectedPath = txtExtract.Text
            Else
                fbd.SelectedPath = Environment.SpecialFolder.MyDocuments
            End If

            If fbd.ShowDialog(Me) = DialogResult.OK Then
                txtExtract.Text = fbd.SelectedPath
            End If
        End Using
    End Sub

    ''' <summary>
    ''' ffmpeg.exe参照やで
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFfmpegPathRef_Click(sender As Object, e As EventArgs) Handles btnFfmpegPathRef.Click
        Using ofd As New OpenFileDialog()
            If txtFfmpegPath.Text <> "" Then
                ofd.InitialDirectory = Path.GetDirectoryName(txtFfmpegPath.Text)
                ofd.FileName = Path.GetFileName(txtFfmpegPath.Text)
            Else
                ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments
                ofd.FileName = "ffmpeg.exe"
            End If

            ofd.Filter = "実行ファイル(*.exe)|*.exe|すべてのファイル(*.*)|*.*"
            ofd.FilterIndex = 1
            ofd.Title = "ffmpeg.exeを選択してください"
            ofd.RestoreDirectory = True

            If ofd.ShowDialog() = DialogResult.OK Then
                txtFfmpegPath.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strMsg As String = ""

        If lstTarget.Items.Count > 0 Then
            'るーぷ
            lstTarget.ClearSelected()
            For ii = 0 To lstTarget.Items.Count - 1
                lstTarget.SelectedIndex = ii
                If File.Exists(lstTarget.Items(ii)) = True Then
                    If I_Encode(lstTarget.Items(ii)) = False Then
                        strMsg = lstTarget.Items(ii)
                        Exit For
                    End If
                End If
            Next

            If strMsg <> "" Then
                MessageBox.Show(strMsg & "で失敗...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                strMsg = "変換終了"
                MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class
