Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Cls_Mysql
    Protected CN As MySqlConnection
    Protected CMD As MySqlCommand
    Protected DA As MySqlDataAdapter
    Protected DS As DataSet
    Protected DT As DataTable

    Public Function OpenConn_Mysql() As Boolean
        CN = New MySqlConnection(SQL_MYSQL_KONEKSI)
        If CN.State = ConnectionState.Closed Then
            CN.Close()
            CN = Nothing
            CN = New MySqlConnection(SQL_MYSQL_KONEKSI)
            CN.Open()
        End If
        If CN.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn_Mysql()
        If Not IsNothing(CN) Then
            CN.Close()
            CN.Dispose()
            CN = Nothing
        End If
    End Sub

    Public Function ExecuteQuery_Mysql(ByVal Query As String) As DataTable
        Try
            If Not OpenConn_Mysql() Then
                MsgBox("Koneksi Gagal....!!", vbCritical, "Error")
                Return Nothing
                Exit Function
            End If

            CMD = New MySqlCommand(Query, CN)
            DA = New MySqlDataAdapter
            DA.SelectCommand = CMD
            DA.SelectCommand.CommandTimeout = 0
            DS = New Data.DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)

            Return DT
            DT = Nothing
            DS = Nothing
            DA = Nothing
            CMD = Nothing

        Catch ex As Exception
            MsgBox("Error Parsing " & Query & " : ", ex.Message, "Error")
        Finally
            CloseConn_Mysql()
        End Try

    End Function

    Public Sub mysqlTrans(QUERY() As Array)
        For i = 0 To QUERY.Count
            MsgBox(QUERY(i).ToString)
        Next i

        Exit Sub

        Dim myConnection As New MySqlConnection(SQL_MYSQL_KONEKSI)
        myConnection.Open()

        Dim myCommand As MySqlCommand = myConnection.CreateCommand()
        Dim myTrans As MySqlTransaction

        myTrans = myConnection.BeginTransaction()
        myCommand.Connection = myConnection
        myCommand.Transaction = myTrans

        Try
            For i = 0 To QUERY.Count
                myCommand.CommandText = QUERY(i).ToString
                myCommand.ExecuteNonQuery()
            Next i

            myTrans.Commit()
        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox(ex.Message)
                End If
            End Try
        Finally
            myConnection.Close()
        End Try
    End Sub

    Public Sub ExecuteNonQuery_Mysql(ByVal Query As String)
        Try
            If Not OpenConn_Mysql() Then
                MsgBox("Koneksi Gagal...!!", vbCritical, "Error")
                Exit Sub
            End If
            CMD = New MySqlCommand
            CMD.Connection = CN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = Query
            CMD.ExecuteNonQuery()

            CMD = Nothing

        Catch ex As Exception

        Finally
            CloseConn_Mysql()
        End Try

    End Sub
End Class
