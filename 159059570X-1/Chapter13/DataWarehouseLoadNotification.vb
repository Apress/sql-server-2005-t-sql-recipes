Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server
Imports System.IO
Public Class DW_Trigger
Public Shared Sub ExportFile()
Dim DWTrigger As SqlTriggerContext
DWTrigger = SqlContext.TriggerContext
If (DWTrigger.TriggerAction = _
TriggerAction.Insert) Then
Dim DWsw As StreamWriter = New _
StreamWriter("C:\DataWarehouseLoadTrigger.txt")
DWsw.WriteLine(Now())
DWsw.Close()
End If
End Sub
End Class