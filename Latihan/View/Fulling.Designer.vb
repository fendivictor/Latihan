<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fulling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.T_nomor = New System.Windows.Forms.TextBox()
        Me.T_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_keterangan = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T_kodebrg = New System.Windows.Forms.TextBox()
        Me.T_namabarang = New System.Windows.Forms.TextBox()
        Me.T_jumlah = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.B_delete = New System.Windows.Forms.Button()
        Me.DGVdetail = New System.Windows.Forms.DataGridView()
        Me.T_satuan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T_iddetail = New System.Windows.Forms.TextBox()
        CType(Me.DGVdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_nomor
        '
        Me.T_nomor.Location = New System.Drawing.Point(106, 63)
        Me.T_nomor.Name = "T_nomor"
        Me.T_nomor.ReadOnly = True
        Me.T_nomor.Size = New System.Drawing.Size(128, 20)
        Me.T_nomor.TabIndex = 0
        '
        'T_tanggal
        '
        Me.T_tanggal.CustomFormat = "dd/MM/yyyy"
        Me.T_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.T_tanggal.Location = New System.Drawing.Point(106, 28)
        Me.T_tanggal.Name = "T_tanggal"
        Me.T_tanggal.Size = New System.Drawing.Size(128, 20)
        Me.T_tanggal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nomor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keterangan"
        '
        'T_keterangan
        '
        Me.T_keterangan.Location = New System.Drawing.Point(106, 99)
        Me.T_keterangan.Name = "T_keterangan"
        Me.T_keterangan.Size = New System.Drawing.Size(243, 75)
        Me.T_keterangan.TabIndex = 6
        Me.T_keterangan.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jumlah"
        '
        'T_kodebrg
        '
        Me.T_kodebrg.Location = New System.Drawing.Point(106, 197)
        Me.T_kodebrg.Name = "T_kodebrg"
        Me.T_kodebrg.ReadOnly = True
        Me.T_kodebrg.Size = New System.Drawing.Size(128, 20)
        Me.T_kodebrg.TabIndex = 10
        '
        'T_namabarang
        '
        Me.T_namabarang.Location = New System.Drawing.Point(106, 235)
        Me.T_namabarang.Name = "T_namabarang"
        Me.T_namabarang.ReadOnly = True
        Me.T_namabarang.Size = New System.Drawing.Size(128, 20)
        Me.T_namabarang.TabIndex = 11
        '
        'T_jumlah
        '
        Me.T_jumlah.Location = New System.Drawing.Point(106, 274)
        Me.T_jumlah.Name = "T_jumlah"
        Me.T_jumlah.Size = New System.Drawing.Size(128, 20)
        Me.T_jumlah.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(106, 314)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 14
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'B_delete
        '
        Me.B_delete.Location = New System.Drawing.Point(198, 314)
        Me.B_delete.Name = "B_delete"
        Me.B_delete.Size = New System.Drawing.Size(75, 23)
        Me.B_delete.TabIndex = 15
        Me.B_delete.Text = "Hapus"
        Me.B_delete.UseVisualStyleBackColor = True
        '
        'DGVdetail
        '
        Me.DGVdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdetail.Location = New System.Drawing.Point(29, 364)
        Me.DGVdetail.Name = "DGVdetail"
        Me.DGVdetail.Size = New System.Drawing.Size(768, 150)
        Me.DGVdetail.TabIndex = 16
        '
        'T_satuan
        '
        Me.T_satuan.Location = New System.Drawing.Point(310, 274)
        Me.T_satuan.Name = "T_satuan"
        Me.T_satuan.ReadOnly = True
        Me.T_satuan.Size = New System.Drawing.Size(128, 20)
        Me.T_satuan.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Satuan"
        '
        'T_iddetail
        '
        Me.T_iddetail.Location = New System.Drawing.Point(296, 197)
        Me.T_iddetail.Name = "T_iddetail"
        Me.T_iddetail.Size = New System.Drawing.Size(25, 20)
        Me.T_iddetail.TabIndex = 19
        Me.T_iddetail.Visible = False
        '
        'Fulling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 544)
        Me.Controls.Add(Me.T_iddetail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.T_satuan)
        Me.Controls.Add(Me.DGVdetail)
        Me.Controls.Add(Me.B_delete)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.T_jumlah)
        Me.Controls.Add(Me.T_namabarang)
        Me.Controls.Add(Me.T_kodebrg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.T_keterangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_tanggal)
        Me.Controls.Add(Me.T_nomor)
        Me.Name = "Fulling"
        Me.Text = "Fulling"
        CType(Me.DGVdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents T_nomor As TextBox
    Friend WithEvents T_tanggal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_keterangan As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents T_kodebrg As TextBox
    Friend WithEvents T_namabarang As TextBox
    Friend WithEvents T_jumlah As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents simpan As Button
    Friend WithEvents B_delete As Button
    Friend WithEvents DGVdetail As DataGridView
    Friend WithEvents T_satuan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents T_iddetail As TextBox
End Class
