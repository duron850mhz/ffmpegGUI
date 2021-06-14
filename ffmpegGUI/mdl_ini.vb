Module mdl_ini

    '===============================================================================

    Public Const ZZV_INI_Section_Setting = "Setting"
    Public Const ZZV_INI_Entry_Extract = "Extract"
    Public Const ZZV_INI_Entry_FfmpegPath = "FfmpegPat"
    Public Const ZZV_INI_Entry_FfmpegOption = "FfmpegOption"

    '===============================================================================

    Declare Function WritePrivateProfileString _
            Lib "KERNEL32.DLL" Alias "WritePrivateProfileStringA" ( _
                ByVal lpAppName As String, _
                ByVal lpKeyName As String, _
                ByVal lpString As String, _
                ByVal lpFileName As String) As Integer

    Declare Function GetPrivateProfileString _
            Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" ( _
                ByVal lpAppName As String, _
                ByVal lpKeyName As String, _
                ByVal lpDefault As String, _
                ByVal lpReturnedString As String, _
                ByVal nSize As Integer, _
                ByVal lpFileName As String) As Integer

    '===============================================================================

    ''' <summary>
    ''' API_WriteIni
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="Entry"></param>
    ''' <param name="WriteData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function API_WriteIni(Section As String, Entry As String, WriteData As String) As Long
        Dim strPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim strIniFile As String = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileNameWithoutExtension(strPath) & ".ini")

        Return WritePrivateProfileString(Section, Entry, WriteData, strIniFile)
    End Function

    ''' <summary>
    ''' API_ReadINI
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="Entry"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function API_ReadINI(Section As String, Entry As String) As String
        Dim strPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim strIniFile As String = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileNameWithoutExtension(strPath) & ".ini")

        If (System.IO.File.Exists(strIniFile) = False) Then
            Return vbNullString
        Else
            Dim strParam As String = Space(255)
            Dim lRet As Long = GetPrivateProfileString(Section, Entry, "", strParam, 255, strIniFile)
            Return Left(strParam, InStr(strParam, Chr(0)) - 1)
        End If
    End Function

End Module
