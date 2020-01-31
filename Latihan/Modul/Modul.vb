Imports MySql.Data
Imports MySql.Data.MySqlClient

Module Modul

    Public warna1 As String = "#1C7EC7" ' Biru pAnel Atas
    Public warna2 As String = "#474747" ' panel Kiri Mdi
    Public warna3 As String = "#2298F0" ' Button Panel Atas
    Public warna4 As String = "#595959" ' Button Kiri Mdi
    Public warna5 As String = "#4FADED" ' Button All
    Public warna6 As String = "#F2F0F0" ' Warna panel input
    Public warnafont1 As String = "#ffffff" ' Warna Font buton Atas
    Public warnafont2 As String = "#ffffff" ' Warna Font buton kiri
    Public warnaform As String = "#ffffff" ' Warna Font buton kiri

    Public Servername As String
    Public UserServer As String
    Public PassServer As String
    Public Database As String

    Public SQL_Koneksi As String
    Public SQL_SAGE_KONEKSI As String
    Public SQL_HRD_KONEKSI As String
    Public SQL_MYSQL_KONEKSI As String

    Public Conn_Sage As New Cls_Sage
    'Public Conn_HRD As New Cls_Hrd
    'Public Conn As New Cls_Koneksi
    Public Conn_Mysql As New Cls_Mysql

    Public Tabel As DataTable
    Public Tabel2 As DataTable
    Public Tabel3 As DataTable
    Public SQL As String
    Public userid As String
    Public ID_USER As String

    Dim barisx, dat, s1, s As String
    Dim Baris As Double

    Public show_from As String = ""
    Public ConnReportString As String
    Public Confirm As String = ""
    Public lokasi_path_file As String = ""
    Public kategori_dokumen As String = ""
    Public DB_TABEL As String = "SAMLTD"
    Public IP_SERVER As String = "10.7.10.12"
    Public IP_SERVER_SAGE As String = "10.7.10.12"
    Public DB_SAGE_TRIAL As String = ""
    Public DB_SAM As String = "SAMLTD.dbo."

    Public nilai_roolback As Boolean

    Public Sub Selected_all(ByVal T As TextBox)
        T.SelectionStart = 0
        T.SelectionLength = Len(T.Text)
        T.Focus()
    End Sub

    Public Sub Load_koneksi()
        Try
            Dim i As Integer
            barisx = 0
            i = FreeFile()
            FileOpen(i, Application.StartupPath & "\Config.ini", OpenMode.Input) ' ambil file dari direktori open file
            Do Until EOF(i)
                s1 = ""
                Input(i, s) 'tiap baris d tampung d variabel "s"
                s1 = s1 & s & IIf(EOF(i), "", vbCrLf)
                Baris = Baris + 1
                If Baris = 2 Then
                    Servername = Strings.Mid(s1, 14, 50)
                ElseIf Baris = 4 Then
                    Database = Strings.Mid(s1, 10, 50)
                ElseIf Baris = 5 Then
                    Database = Strings.Mid(s1, 10, 50)
                ElseIf Baris = 7 Then
                    IP_SERVER = Trim(Replace(s1, vbCrLf, ""))
                ElseIf Baris = 8 Then
                    IP_SERVER_SAGE = Trim(Replace(s1, vbCrLf, ""))
                ElseIf Baris = 9 Then
                    DB_SAGE_TRIAL = Trim(Replace(s1, vbCrLf, ""))
                End If
            Loop
            FileClose(i)
            'UserServer = "sa"
            'PassServer = "Wuryanto1"
            UserServer = "admin"
            PassServer = "fukuryo"
            Database = "general_affair"

            SQL_Koneksi = "Provider=SQLOLEDB.1;Password=" & PassServer & ";Persist Security Info=True;User ID=" & UserServer & ";Initial Catalog=" & Database & ";Data Source=" & Servername & ""
            ConnReportString = "Provider=SQLOLEDB;Data Source=" & Trim(Servername) & ";PWD=" & Trim(PassServer) & ";User ID=" & Trim(UserServer) & ";Initial Catalog=" & Trim(Database) & ""

            IP_SERVER = "127.0.0.1"

            ''LIVE SAGE 
            'server_sage = "10.7.10.3"
            'UserServer = "sa"
            'PassServer = "Accpac2012"
            'Database = "FKRDT"

            'Frm_Login.Label4.Text = "LOCAL DB " & Servername
            'Frm_Login.Label5.Text = "LOCAL " & IP_SERVER
            'Frm_Login.Label6.Text = "SAGE " & IP_SERVER_SAGE

            'FUKURYOSERVER\MSSQLSERVER2014
            'SQL_SAGE_KONEKSI = "Provider=SQLOLEDB.1;Password=Accpac2012;Persist Security Info=True;User ID=sa;Initial Catalog=FKRDT;Data Source=" & IP_SERVER_SAGE & ""
            'Live            
            'SQL_HRD_KONEKSI = "Provider=SQLOLEDB.1;Password=Accpac2012;Persist Security Info=True;User ID=fukuryo;Initial Catalog=SPISY_FUKURYO;Data Source=DESKTOP-QCEK3DS"
            'SQL_HRD_KONEKSI = "Provider=SQLOLEDB.1;Password=Accpac2012;Persist Security Info=True;User ID=fukuryo;Initial Catalog=SPISY_FUKURYO;Data Source=" & IP_SERVER_SAGE & "\MSSQLSERVER2014"

            'LOCALHOST
            SQL_MYSQL_KONEKSI = "Server=" & IP_SERVER & ";user id=root;password=;database=fk_produksi" 'tpbdb

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GridView(ByVal grid As DataGridView)
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        grid.BackgroundColor = Color.Gainsboro
        grid.GridColor = Color.LightGray
        grid.DefaultCellStyle.BackColor = Color.White
        grid.DefaultCellStyle.SelectionBackColor = Color.SkyBlue
        grid.DefaultCellStyle.SelectionForeColor = Color.Black
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.RowHeadersWidth = 25
        grid.ColumnHeadersHeightSizeMode = 1
        grid.AllowUserToAddRows = False
    End Sub

    Public Sub number_off_grid(sender As Object, e As DataGridViewRowPostPaintEventArgs, ByVal DGV As DataGridView)
        Dim strRowNumber As String = (e.RowIndex + 1).ToString

        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, DGV.Font)

        If DGV.RowHeadersWidth < CInt((size.Width + 20)) Then
            DGV.RowHeadersWidth = CInt((size.Width + 20))
        End If

        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, DGV.Font, b, e.RowBounds.Location.X + 15,
                              e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) _
                                                        / 2))
    End Sub

    Public Function mysqlTrans_modul(QUERY() As Object) As Boolean
        Dim myConnection As New MySqlConnection(SQL_MYSQL_KONEKSI)
        myConnection.Open()
        Dim nilai As Boolean
        Dim myCommand As MySqlCommand = myConnection.CreateCommand()
        Dim myTrans As MySqlTransaction

        myTrans = myConnection.BeginTransaction()
        myCommand.Connection = myConnection
        myCommand.Transaction = myTrans

        Try
            For i = 0 To QUERY.Count - 1
                myCommand.CommandText = QUERY(i).ToString
                myCommand.ExecuteNonQuery()
            Next i

            myTrans.Commit()

            nilai = True
            Return nilai
        Catch e As Exception
            Try
                myTrans.Rollback()
                nilai = False
                Return nilai
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox(ex.Message)
                End If
            End Try
        Finally
            myConnection.Close()
        End Try
    End Function

    Public Sub sub_combobox_mysql(ByVal cmb_nama As ComboBox, ByVal cmb_kode As ComboBox,
                           ByVal query As String, ByVal kolom_kode As String, ByVal kolom_nama As String,
                           ByVal tambah_semua As Boolean)
        Dim tabelx As DataTable
        Try
            tabelx = Conn_Mysql.ExecuteQuery_Mysql(query)
            If tabelx.Rows.Count > 0 Then
                cmb_nama.Items.Clear()
                cmb_kode.Items.Clear()
                If tambah_semua = True Then
                    cmb_nama.Items.Add("SEMUA DATA")
                    cmb_kode.Items.Add("")
                End If
                For i As Integer = 0 To tabelx.Rows.Count - 1
                    cmb_nama.Items.Add(tabelx.Rows(i).Item(kolom_nama))
                    cmb_kode.Items.Add(tabelx.Rows(i).Item(kolom_kode))
                Next
                cmb_nama.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Load combobox function error " & ex.Message)
        Finally
            tabelx = Nothing
        End Try
    End Sub

    'Public Sub WarnaGrid(ByVal grid As Janus.Windows.GridEX.GridEX)
    '    '  grid.Font = New System.Drawing.Font("Arial", 10)
    '    'grid.Font = New System.Drawing.Font("Arial", 9)
    '    grid.Font = New System.Drawing.Font("Tahoma", 8)
    '    grid.AlternatingColors = True
    '    grid.AlternatingRowFormatStyle.BackColor = Color.AliceBlue
    '    grid.GridLines = Janus.Windows.GridEX.GridLines.Both
    '    grid.AlternatingColors = True
    '    grid.GroupByBoxVisible = True
    '    grid.RowHeaders = 1
    '    grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
    '    grid.RecordNavigator = True
    '    grid.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
    '    grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
    '    grid.ExternalImageList = Menu_Utama.ImageList1
    '    '============ Group box Tabel =========
    '    'grid.GroupByBoxFormatStyle.BackColor = Color.SkyBlue
    '    'grid.GroupByBoxFormatStyle.BackColorGradient = Color.WhiteSmoke
    '    grid.GroupByBoxFormatStyle.BackColor = Color.Gainsboro
    '    grid.GroupByBoxFormatStyle.BackColorGradient = Color.Gainsboro
    '    grid.GroupByBoxFormatStyle.BackgroundGradientMode = 2

    '    '============ Header Tabel =========
    '    grid.HeaderFormatStyle.BackColor = Color.SkyBlue
    '    grid.HeaderFormatStyle.BackColorGradient = Color.WhiteSmoke
    '    grid.HeaderFormatStyle.BackgroundGradientMode = 2

    '    ''============ Gropu row Tabel =========
    '    grid.GroupRowFormatStyle.BackColor = Color.WhiteSmoke
    '    grid.GroupRowFormatStyle.BackColorGradient = Color.WhiteSmoke
    '    'grid.GroupRowFormatStyle.BackgroundGradientMode = 2
    'End Sub

    Public Sub nomor_keluar(ByVal t_nobukti As TextBox, ByVal tgl As DateTime, ByVal inisial As String, ByVal kolom As String)
        Dim Nobukti As String
        Try
            Nobukti = inisial & "/" & Format(tgl, "yyyyMM") & "/"
            Tabel = Conn_Mysql.ExecuteQuery_Mysql("select id, " & kolom & " from tbl_konter where periode='" & Format(tgl, "yyyyMM") & "' order by id desc ")
            If Tabel.Rows.Count > 0 Then

                ' MsgBox(Tabel.Rows(0).Item("id"))
                Dim id As String = Tabel.Rows(0).Item("id")

                t_nobukti.Text = Val(Tabel.Rows(0).Item(kolom)) + 1
                t_nobukti.Text = Nobukti & t_nobukti.Text
                Conn_Mysql.ExecuteNonQuery_Mysql(" update tbl_konter set " & kolom & "=" & kolom & "+1 where id=" & id & "")
            Else
                t_nobukti.Text = Nobukti & "1"
                Conn_Mysql.ExecuteNonQuery_Mysql(" insert into tbl_konter (" & kolom & ",periode) values (1,'" & Format(tgl, "yyyyMM") & "')")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
