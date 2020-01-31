Public Class Fulling
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModalBarang.ShowDialog()
        T_jumlah.Focus()
    End Sub

    Private Sub Fulling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView(DGVdetail)
    End Sub

    Sub clear_form()
        T_nomor.Text = ""
        T_keterangan.Text = ""
        show_detail()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        simpan_data()
    End Sub

    Sub simpan_data()
        Dim tgl = Format(T_tanggal.Value, "yyyy-MM-dd")
        Dim nomor As String = T_nomor.Text
        Dim keterangan = T_keterangan.Text
        Dim kodebrg = T_kodebrg.Text
        Dim namabrg = Replace(T_namabarang.Text, "'", "''")
        Dim jumlah = T_jumlah.Text
        Dim satuan = T_satuan.Text

        Try
            If Trim(kodebrg) = "" Then
                MsgBox("Barang tidak ditemukan")
                Exit Sub
            End If

            If nomor = "" Then
                nomor_keluar(T_nomor, T_tanggal.Value, "TR", "fulling")
                nomor = T_nomor.Text
                Dim INSERT_H = "INSERT INTO fulling_h (nobukti, tgl, keterangan, status) VALUES ('" & nomor & "', '" & tgl & "', '" & keterangan & "', '5')"

                Conn_Mysql.ExecuteNonQuery_Mysql(INSERT_H)
            Else
                Dim UPDATE_H = "UPDATE fulling_h SET tgl = '" & tgl & "', keterangan = '" & keterangan & "' WHERE nobukti = '" & nomor & "'"

                Conn_Mysql.ExecuteNonQuery_Mysql(UPDATE_H)
            End If

            Dim INSERT_D = "INSERT INTO fulling_d (nobukti, kodebrg, namabrg, jumlah, satuan) VALUES ('" & nomor & "', '" & kodebrg & "', '" & namabrg & "', '" & jumlah & "', '" & satuan & "')"

            Conn_Mysql.ExecuteNonQuery_Mysql(INSERT_D)

            T_iddetail.Text = ""
            T_kodebrg.Text = ""
            T_namabarang.Text = ""
            T_jumlah.Text = ""
            T_satuan.Text = ""

            MsgBox("Data berhasil disimpan", vbInformation, "Hapus Data")
            show_detail()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub show_detail()
        Try
            Dim nomor = T_nomor.Text
            SQL = "SELECT id, nobukti AS NOBUKTI, kodebrg AS KODE, namabrg AS NAMA, jumlah AS JUMLAH, satuan AS SATUAN FROM fulling_d WHERE nobukti = '" & nomor & "'"

            Tabel = Conn_Mysql.ExecuteQuery_Mysql(SQL)

            DGVdetail.DataSource = Tabel
            DGVdetail.Columns(0).Visible = False
            DGVdetail.AutoResizeColumns()
            DGVdetail.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVdetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdetail.CellContentClick

    End Sub

    Private Sub DGVdetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdetail.CellDoubleClick
        Try
            Me.T_iddetail.Text = DGVdetail.SelectedCells(0).Value
            Me.T_kodebrg.Text = DGVdetail.SelectedCells(2).Value
            Me.T_namabarang.Text = DGVdetail.SelectedCells(3).Value
            Me.T_jumlah.Text = DGVdetail.SelectedCells(4).Value
            Me.T_satuan.Text = DGVdetail.SelectedCells(5).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub B_delete_Click(sender As Object, e As EventArgs) Handles B_delete.Click
        Try
            Dim confirm As String
            confirm = MsgBox("Yakin Hapus Data ?", vbYesNo + vbQuestion, "Hapus Data")

            If (confirm = vbNo) Then
                Exit Sub
            End If

            Dim id_detail = T_iddetail.Text
            SQL = "DELETE FROM fulling_d WHERE id = '" & id_detail & "'"

            Conn_Mysql.ExecuteNonQuery_Mysql(SQL)

            T_iddetail.Text = ""
            T_kodebrg.Text = ""
            T_namabarang.Text = ""
            T_jumlah.Text = ""
            T_satuan.Text = ""

            MsgBox("Data berhasil dihapus")
            show_detail()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class