Imports System.Data
Imports System.Data.OleDb

Public Class Cls_Sage

    Protected CN As OleDb.OleDbConnection
    Protected CMD As OleDb.OleDbCommand
    Protected DA As OleDb.OleDbDataAdapter
    Protected DS As DataSet
    Protected DT As DataTable

    Public Function OpenConn() As Boolean
        CN = New OleDb.OleDbConnection(SQL_SAGE_KONEKSI)
        CN.Open()
        If CN.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn()
        If Not IsNothing(CN) Then
            CN.Close()
            CN = Nothing
        End If
    End Sub

    Public Function ExecuteQuery_Sage(ByVal Query As String) As DataTable
        Try
            If Not OpenConn() Then
                MsgBox("Koneksi Gagal....!!", vbCritical, "Error")
                Return Nothing
                Exit Function
            End If
            CMD = New OleDb.OleDbCommand(Query, CN)
            DA = New OleDb.OleDbDataAdapter
            DA.SelectCommand = CMD
            DS = New Data.DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)
            Return DT
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DT = Nothing
            DS = Nothing
            DA = Nothing
            CMD = Nothing
            CloseConn()
        End Try
    End Function

    Public Sub ExecuteNonQuery_Sage(ByVal Query As String)
        Try
            If Not OpenConn() Then
                MsgBox("Koneksi Gagal...!!", vbCritical, "Error")
                Exit Sub
            End If
            CMD = New OleDb.OleDbCommand
            CMD.Connection = CN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = Query
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CMD = Nothing
            CloseConn()
        End Try
    End Sub
End Class
