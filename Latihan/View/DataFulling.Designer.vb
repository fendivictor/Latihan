<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataFulling
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
        Me.DGVFulling = New System.Windows.Forms.DataGridView()
        Me.T_startdate = New System.Windows.Forms.DateTimePicker()
        Me.T_enddate = New System.Windows.Forms.DateTimePicker()
        Me.B_cari = New System.Windows.Forms.Button()
        Me.B_hapus = New System.Windows.Forms.Button()
        CType(Me.DGVFulling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVFulling
        '
        Me.DGVFulling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFulling.Location = New System.Drawing.Point(36, 100)
        Me.DGVFulling.Name = "DGVFulling"
        Me.DGVFulling.Size = New System.Drawing.Size(723, 300)
        Me.DGVFulling.TabIndex = 0
        '
        'T_startdate
        '
        Me.T_startdate.CustomFormat = "dd/MM/yyyy"
        Me.T_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.T_startdate.Location = New System.Drawing.Point(36, 60)
        Me.T_startdate.Name = "T_startdate"
        Me.T_startdate.Size = New System.Drawing.Size(200, 20)
        Me.T_startdate.TabIndex = 1
        '
        'T_enddate
        '
        Me.T_enddate.CustomFormat = "dd/MM/yyyy"
        Me.T_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.T_enddate.Location = New System.Drawing.Point(242, 60)
        Me.T_enddate.Name = "T_enddate"
        Me.T_enddate.Size = New System.Drawing.Size(200, 20)
        Me.T_enddate.TabIndex = 2
        '
        'B_cari
        '
        Me.B_cari.Location = New System.Drawing.Point(457, 58)
        Me.B_cari.Name = "B_cari"
        Me.B_cari.Size = New System.Drawing.Size(75, 23)
        Me.B_cari.TabIndex = 3
        Me.B_cari.Text = "Tampilkan"
        Me.B_cari.UseVisualStyleBackColor = True
        '
        'B_hapus
        '
        Me.B_hapus.Location = New System.Drawing.Point(538, 58)
        Me.B_hapus.Name = "B_hapus"
        Me.B_hapus.Size = New System.Drawing.Size(75, 23)
        Me.B_hapus.TabIndex = 4
        Me.B_hapus.Text = "Hapus"
        Me.B_hapus.UseVisualStyleBackColor = True
        '
        'DataFulling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.B_hapus)
        Me.Controls.Add(Me.B_cari)
        Me.Controls.Add(Me.T_enddate)
        Me.Controls.Add(Me.T_startdate)
        Me.Controls.Add(Me.DGVFulling)
        Me.Name = "DataFulling"
        Me.Text = "DataFulling"
        CType(Me.DGVFulling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVFulling As DataGridView
    Friend WithEvents T_startdate As DateTimePicker
    Friend WithEvents T_enddate As DateTimePicker
    Friend WithEvents B_cari As Button
    Friend WithEvents B_hapus As Button
End Class
