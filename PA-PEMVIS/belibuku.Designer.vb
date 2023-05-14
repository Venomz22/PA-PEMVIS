<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class belibuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtthun = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbeli = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ID_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pengarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnBack)
        Me.Panel4.Controls.Add(Me.txtjenis)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtthun)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.btnbeli)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtjudul)
        Me.Panel4.Controls.Add(Me.txtPengarang)
        Me.Panel4.Controls.Add(Me.Nama)
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtPenerbit)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel4.Location = New System.Drawing.Point(234, 310)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(979, 432)
        Me.Panel4.TabIndex = 138
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(681, 103)
        Me.txtjenis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.ReadOnly = True
        Me.txtjenis.Size = New System.Drawing.Size(180, 22)
        Me.txtjenis.TabIndex = 140
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(419, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 33)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Detail Buku"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(681, 249)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(180, 22)
        Me.txtHarga.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(499, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 31)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Harga Buku"
        '
        'txtthun
        '
        Me.txtthun.Location = New System.Drawing.Point(248, 249)
        Me.txtthun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtthun.Name = "txtthun"
        Me.txtthun.ReadOnly = True
        Me.txtthun.Size = New System.Drawing.Size(180, 22)
        Me.txtthun.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 31)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Pengarang"
        '
        'btnbeli
        '
        Me.btnbeli.BackColor = System.Drawing.Color.SkyBlue
        Me.btnbeli.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbeli.Location = New System.Drawing.Point(600, 381)
        Me.btnbeli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbeli.Name = "btnbeli"
        Me.btnbeli.Size = New System.Drawing.Size(117, 37)
        Me.btnbeli.TabIndex = 139
        Me.btnbeli.Text = "BELI"
        Me.btnbeli.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(248, 96)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(180, 22)
        Me.txtID.TabIndex = 107
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 31)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "ID Buku"
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(248, 167)
        Me.txtjudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.ReadOnly = True
        Me.txtjudul.Size = New System.Drawing.Size(180, 22)
        Me.txtjudul.TabIndex = 97
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(248, 314)
        Me.txtPengarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.ReadOnly = True
        Me.txtPengarang.Size = New System.Drawing.Size(180, 22)
        Me.txtPengarang.TabIndex = 105
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(67, 160)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(130, 31)
        Me.Nama.TabIndex = 96
        Me.Nama.Text = "Judul Buku"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(681, 185)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.ReadOnly = True
        Me.txtjumlah.Size = New System.Drawing.Size(180, 22)
        Me.txtjumlah.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 31)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Jenis Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(499, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 31)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Stok Buku"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(248, 382)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.ReadOnly = True
        Me.txtPenerbit.Size = New System.Drawing.Size(180, 22)
        Me.txtPenerbit.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 31)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 31)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Penerbit"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_buku, Me.Judul, Me.TahunTerbit, Me.Pengarang, Me.Penerbit, Me.JenisBuku, Me.Jumlah, Me.harga, Me.Gambar})
        Me.dgv1.Location = New System.Drawing.Point(234, 110)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1063, 158)
        Me.dgv1.TabIndex = 137
        '
        'ID_buku
        '
        Me.ID_buku.HeaderText = "ID Buku"
        Me.ID_buku.MinimumWidth = 6
        Me.ID_buku.Name = "ID_buku"
        Me.ID_buku.Width = 125
        '
        'Judul
        '
        Me.Judul.HeaderText = "Judul Buku"
        Me.Judul.MinimumWidth = 6
        Me.Judul.Name = "Judul"
        Me.Judul.Width = 125
        '
        'TahunTerbit
        '
        Me.TahunTerbit.HeaderText = "Tahun Terbit"
        Me.TahunTerbit.MinimumWidth = 6
        Me.TahunTerbit.Name = "TahunTerbit"
        Me.TahunTerbit.Width = 125
        '
        'Pengarang
        '
        Me.Pengarang.HeaderText = "Pengarang"
        Me.Pengarang.MinimumWidth = 6
        Me.Pengarang.Name = "Pengarang"
        Me.Pengarang.Width = 125
        '
        'Penerbit
        '
        Me.Penerbit.HeaderText = "Penerbit"
        Me.Penerbit.MinimumWidth = 6
        Me.Penerbit.Name = "Penerbit"
        Me.Penerbit.Width = 125
        '
        'JenisBuku
        '
        Me.JenisBuku.HeaderText = "Jenis Buku"
        Me.JenisBuku.MinimumWidth = 6
        Me.JenisBuku.Name = "JenisBuku"
        Me.JenisBuku.Width = 125
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Stok Buku"
        Me.Jumlah.MinimumWidth = 6
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 125
        '
        'harga
        '
        Me.harga.HeaderText = "Harga Buku"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        Me.harga.Width = 125
        '
        'Gambar
        '
        Me.Gambar.HeaderText = "Gambar"
        Me.Gambar.MinimumWidth = 6
        Me.Gambar.Name = "Gambar"
        Me.Gambar.Width = 125
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnProfile)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnbook)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 791)
        Me.Panel2.TabIndex = 134
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop2
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(56, 126)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(96, 82)
        Me.btnHome.TabIndex = 17
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(56, 272)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(96, 82)
        Me.btnProfile.TabIndex = 15
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Location = New System.Drawing.Point(56, 528)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(96, 87)
        Me.btnTransaksi.TabIndex = 14
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnbook
        '
        Me.btnbook.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.open_book
        Me.btnbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbook.FlatAppearance.BorderSize = 0
        Me.btnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbook.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbook.Location = New System.Drawing.Point(56, 395)
        Me.btnbook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(96, 85)
        Me.btnbook.TabIndex = 13
        Me.btnbook.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button30)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(205, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1324, 88)
        Me.Panel3.TabIndex = 139
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.logout
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1235, 20)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(51, 49)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.FlatAppearance.BorderSize = 0
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Location = New System.Drawing.Point(267, 7)
        Me.Button30.Margin = New System.Windows.Forms.Padding(4)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(751, 73)
        Me.Button30.TabIndex = 29
        Me.Button30.Text = "DAFTAR BUKU"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1232, 310)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 140
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(759, 382)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 37)
        Me.btnBack.TabIndex = 141
        Me.btnBack.Text = "Selesai"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'belibuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1529, 791)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "belibuku"
        Me.Text = "belibuku"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtthun As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbeli As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents Nama As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnbook As Button
    Friend WithEvents txtjenis As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ID_buku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents Pengarang As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents JenisBuku As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents Gambar As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
End Class
