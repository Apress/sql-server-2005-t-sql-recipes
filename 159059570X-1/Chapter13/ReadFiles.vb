Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.IO
Public Class ReadFiles
Public Shared Sub Main(ByVal sFile As SqlString)
Dim sReader As StreamReader = New StreamReader(sFile)
Dim sLine As String
Dim sPipe As SqlPipe = SqlContext.Pipe
Do
sLine = sReader.ReadLine()
If Not sLine Is Nothing Then
sPipe.Send(sLine)
End If
Loop Until sLine Is Nothing
sReader.Close()
End Sub
End Class