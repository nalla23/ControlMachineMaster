Imports System.Runtime.InteropServices
Imports System.Text
Module Mod_Ini
    <DllImport("kernel32.dll", SetLastError:=True)> Public Function WritePrivateProfileString _
              (ByVal lpApplicationName As String,
              ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> Public Function GetPrivateProfileString(
          ByVal lpAppName As String,
          ByVal lpKeyName As String,
          ByVal lpDefault As String,
          ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function

    Public Function lerINI(ByVal strIniFile As String, ByVal strKey As String, ByVal strItem As String) As String
        Dim strValue As StringBuilder = New StringBuilder(255)
        Dim intSize As Integer
        intSize = GetPrivateProfileString(strKey, strItem, "", strValue, 255, strIniFile)
        Return strValue.ToString
    End Function

    Public Function escreveINI(ByVal strIniFile As String, ByVal strKey As String,
                                ByVal strItem As String, ByVal strValue As String) _
                                    As Boolean
        Return WritePrivateProfileString(strKey, strItem, strValue, strIniFile)
    End Function
End Module
