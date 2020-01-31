Public Class DataFulling
    Private Sub DataFulling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView(DGVFulling)
        tampilkan()
    End Sub

    Sub tampilkan()
        Dim datestart = Format(T_startdate.Value, "yyyy-MM-dd")
        Dim dateend = Format(T_enddate.Value, "yyyy-MM-dd")

        SQL = "SELECT nobukti AS NOBUKTI, tgl AS TANGGAL, keterangan AS KETERANGAN FROM fulling_h WHERE tgl BETWEEN '" & datestart & "' AND '" & dateend & "'"

        Tabel = Conn_Mysql.ExecuteQuery_Mysql(SQL)

        DGVFulling.DataSource = Tabel
        DGVFulling.AutoResizeColumns()
    End Sub

    Private Sub B_cari_Click(sender As Object, e As EventArgs) Handles B_cari.Click
        tampilkan()
    End Sub

    Private Sub DGVFulling_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFulling.CellContentClick

    End Sub

    Private Sub DGVFulling_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFulling.CellDoubleClick
        Fulling.T_nomor.Text = DGVFulling.SelectedCells(0).Value
        Fulling.T_tanggal.Value = DGVFulling.SelectedCells(1).Value
        Fulling.T_keterangan.Text = DGVFulling.SelectedCells(2).Value

        Fulling.MdiParent = Dashboard
        Fulling.WindowState = 2
        Fulling.Show()
        Fulling.show_detail()
    End Sub

    Private Sub B_hapus_Click(sender As Object, e As EventArgs) Handles B_hapus.Click
        Try
            Dim nobukti = DGVFulling.SelectedCells(0).Value
            Dim confirm As String
            confirm = MsgBox("Yakin Hapus Data ?", vbYesNo + vbQuestion, "Hapus Data")

            If (confirm = vbNo) Then
                Exit Sub
            End If

            Dim DELETE_H = "DELETE FROM fulling_h WHERE fulling_h.nobukti = '" & nobukti & "'"
            Dim DELETE_D = "DELETE FROM fulling_d WHERE fulling_d.nobukti = '" & nobukti & "'"

            Dim QUERY() As Object = {DELETE_H, DELETE_D}
            Dim result As Boolean
            result = mysqlTrans_modul(QUERY)

            If result = True Then
                MsgBox("Data berhasil dihapus")
                tampilkan()
                Exit Sub
            End If

            MsgBox("Gagal menghapus data")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class