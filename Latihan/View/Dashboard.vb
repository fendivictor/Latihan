Public Class Dashboard
    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        MasterBarang.MdiParent = Me
        MasterBarang.WindowState = 2
        MasterBarang.Show()
    End Sub

    Private Sub FullingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullingToolStripMenuItem.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Conn_Mysql.ExecuteQuery_Mysql("SELECT * FROM dat_barang LIMIT 1")
    End Sub

    Private Sub LihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataToolStripMenuItem.Click
        DataFulling.MdiParent = Me
        DataFulling.WindowState = 2
        DataFulling.Show()
    End Sub

    Private Sub TambahDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataToolStripMenuItem.Click
        Fulling.MdiParent = Me
        Fulling.WindowState = 2
        Fulling.Show()
        Fulling.clear_form()
    End Sub

    Private Sub TesToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub
End Class