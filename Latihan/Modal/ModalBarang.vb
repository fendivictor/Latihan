Public Class ModalBarang
    Private Sub ModalBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView(DGVBarang)
        tampilkan("")
    End Sub

    Sub tampilkan(keyword)
        Try
            SQL = "SELECT kodebrg AS KODE, namabrg AS NAMA, satuan AS SATUAN FROM dat_barang"
            If keyword <> "" Then
                SQL = SQL & " WHERE namabrg LIKE '%" & Replace(keyword, "'", "''") & "%'"
            End If

            Tabel = Conn_Mysql.ExecuteQuery_Mysql(SQL)

            DGVBarang.DataSource = Tabel
            DGVBarang.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBarang.CellContentClick

    End Sub

    Private Sub DGVBarang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBarang.CellDoubleClick
        Try
            Fulling.T_kodebrg.Text = DGVBarang.SelectedCells(0).Value
            Fulling.T_namabarang.Text = DGVBarang.SelectedCells(1).Value
            Fulling.T_satuan.Text = DGVBarang.SelectedCells(2).Value
            Fulling.T_iddetail.Text = ""

            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword = T_keyword.Text
        tampilkan(keyword)
    End Sub
End Class