<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoices
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nota = New System.Windows.Forms.Label()
        Me.metode = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.Label()
        Me.judul = New System.Windows.Forms.Label()
        Me.pemesan = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(941, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(101, 31)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "id nota"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "nama pembeli"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "judul buku"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "jumlah"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "total harga"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "tanggal pembelian"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.pemesan)
        Me.Panel1.Controls.Add(Me.judul)
        Me.Panel1.Controls.Add(Me.jumlah)
        Me.Panel1.Controls.Add(Me.harga)
        Me.Panel1.Controls.Add(Me.metode)
        Me.Panel1.Controls.Add(Me.nota)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Location = New System.Drawing.Point(243, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 501)
        Me.Panel1.TabIndex = 1
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BackColor = System.Drawing.Color.Transparent
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.id.Location = New System.Drawing.Point(61, 69)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(177, 29)
        Me.id.TabIndex = 2
        Me.id.Text = "id pemesanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(61, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "nama pemesan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(61, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "judul buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(61, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(61, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "pembayaran via"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(61, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "total harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(279, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(279, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(279, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 29)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(279, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 29)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(279, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 29)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(279, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 29)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = ":"
        '
        'nota
        '
        Me.nota.AutoSize = True
        Me.nota.BackColor = System.Drawing.Color.Transparent
        Me.nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nota.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nota.Location = New System.Drawing.Point(320, 69)
        Me.nota.Name = "nota"
        Me.nota.Size = New System.Drawing.Size(20, 29)
        Me.nota.TabIndex = 13
        Me.nota.Text = ","
        '
        'metode
        '
        Me.metode.AutoSize = True
        Me.metode.BackColor = System.Drawing.Color.Transparent
        Me.metode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.metode.Location = New System.Drawing.Point(320, 359)
        Me.metode.Name = "metode"
        Me.metode.Size = New System.Drawing.Size(20, 29)
        Me.metode.TabIndex = 14
        Me.metode.Text = ","
        '
        'harga
        '
        Me.harga.AutoSize = True
        Me.harga.BackColor = System.Drawing.Color.Transparent
        Me.harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.harga.Location = New System.Drawing.Point(320, 299)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(20, 29)
        Me.harga.TabIndex = 15
        Me.harga.Text = ","
        '
        'jumlah
        '
        Me.jumlah.AutoSize = True
        Me.jumlah.BackColor = System.Drawing.Color.Transparent
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.jumlah.Location = New System.Drawing.Point(320, 243)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(20, 29)
        Me.jumlah.TabIndex = 16
        Me.jumlah.Text = ","
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.BackColor = System.Drawing.Color.Transparent
        Me.judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.judul.Location = New System.Drawing.Point(320, 180)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(20, 29)
        Me.judul.TabIndex = 17
        Me.judul.Text = ","
        '
        'pemesan
        '
        Me.pemesan.AutoSize = True
        Me.pemesan.BackColor = System.Drawing.Color.Transparent
        Me.pemesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pemesan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pemesan.Location = New System.Drawing.Point(320, 129)
        Me.pemesan.Name = "pemesan"
        Me.pemesan.Size = New System.Drawing.Size(20, 29)
        Me.pemesan.TabIndex = 18
        Me.pemesan.Text = ","
        '
        'invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 811)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "invoices"
        Me.Text = "invoices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents id As Label
    Friend WithEvents pemesan As Label
    Friend WithEvents judul As Label
    Friend WithEvents jumlah As Label
    Friend WithEvents harga As Label
    Friend WithEvents metode As Label
    Friend WithEvents nota As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
