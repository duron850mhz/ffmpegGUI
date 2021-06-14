Public Class frmMain
    Private Enum rw
        read
        write
    End Enum

    Private Sub I_Init()
        lstTarget.Items.Clear()
        pgb.Value = 0
        pgb.Visible = False
    End Sub

    Private Sub I_DataSet(ByVal rw As rw)
        Select Case rw
            Case rw.read
                Try
                    txtExtract.Text = API_ReadINI(ZZV_INI_Section_Setting, ZZV_INI_Entry_Extract)
                    txtFfmpegPath.Text = API_ReadINI(ZZV_INI_Section_Setting, ZZV_INI_Entry_FfmpegPath)
                    txtFfmpegOption.Text = API_ReadINI(ZZV_INI_Section_Setting, ZZV_INI_Entry_FfmpegOption)
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        Call I_DataSet(rw.read)
    End Sub

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
            If System.IO.Directory.Exists(strFN) = True Then
                'ぽいぽい
                Call I_AddFiles(strFN)
            Else
                'ファイルやわ
                lstTarget.Items.Add(strFN)
            End If
        Next

        lstTarget.Sorted = True
    End Sub

    Private Sub I_AddFiles(ByVal strDirectory As String)
        'ファイルをいれるで
        Dim strFs As String() = System.IO.Directory.GetFiles(strDirectory)
        'くるりんぱ～
        For Each strF In strFs
            lstTarget.Items.Add(strF)
        Next

        'フォルダもあるんかいな
        Dim strDs As String() = System.IO.Directory.GetDirectories(strDirectory)
        'さいきよびだしやで～
        For Each strD In strDs
            Call I_AddFiles(strD)
        Next
    End Sub

    Private Sub txtExtract_DragEnter(sender As Object, e As DragEventArgs) Handles txtExtract.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub txtExtract_DragDrop(sender As Object, e As DragEventArgs) Handles txtExtract.DragDrop
        Dim strFileNames As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If System.IO.Directory.Exists(strFileNames(0)) = True Then
            txtExtract.Text = strFileNames(0)
        End If
    End Sub

    Private Sub btnExtractRef_Click(sender As Object, e As EventArgs) Handles btnExtractRef.Click

    End Sub

    Private Sub btnFfmpegPathRef_Click(sender As Object, e As EventArgs) Handles btnFfmpegPathRef.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If lstTarget.Items.Count > 0 Then

        End If
    End Sub
End Class
