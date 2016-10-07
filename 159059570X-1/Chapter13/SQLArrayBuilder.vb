Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Text.RegularExpressions
Public Class SQLArrayBuilder
Public Shared Function ChooseValueFromArray(ArrayString as String, ArrayDelimiter as String, ArrayItemSelection as SqlInt16) as SqlString
Dim NewArrayString as String() = Regex.Split(ArrayString, ArrayDelimiter)
Dim NewArrayItemSelection as SqlInt16=ArrayItemSelection-1
Dim ReturnString as SQLString = NewArrayString(NewArrayItemSelection)
Return ReturnString
End Function
End Class