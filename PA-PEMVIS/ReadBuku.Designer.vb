<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReadBuku
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtterjual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtthun = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.terjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(213, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1318, 43)
        Me.Panel1.TabIndex = 124
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1228, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1273, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button12)
        Me.Panel3.Location = New System.Drawing.Point(213, 43)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1317, 86)
        Me.Panel3.TabIndex = 126
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(312, 7)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(751, 73)
        Me.Button12.TabIndex = 118
        Me.Button12.Text = "HI Admin !"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnprofile)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnBook)
        Me.Panel2.Controls.Add(Me.btnUser)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 798)
        Me.Panel2.TabIndex = 125
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.SkyBlue
        Me.btnTambah.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(1375, 649)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(117, 37)
        Me.btnTambah.TabIndex = 131
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.SkyBlue
        Me.btnHapus.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(1375, 574)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(117, 37)
        Me.btnHapus.TabIndex = 130
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEdit.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1375, 492)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 37)
        Me.btnEdit.TabIndex = 127
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cmbjenis)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtterjual)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtthun)
        Me.Panel4.Controls.Add(Me.Label7)
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
        Me.Panel4.Location = New System.Drawing.Point(353, 346)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(979, 432)
        Me.Panel4.TabIndex = 129
        '
        'cmbjenis
        '
        Me.cmbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"Horor", "Misteri", "Petualangan", "Musik", "Sejarah", "Drama", "Fiksi", "Fiksi Ilmiah", "Romansa", "Ensiklopedia"})
        Me.cmbjenis.Location = New System.Drawing.Point(681, 103)
        Me.cmbjenis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(180, 24)
        Me.cmbjenis.TabIndex = 116
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
        'txtterjual
        '
        Me.txtterjual.Location = New System.Drawing.Point(681, 322)
        Me.txtterjual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtterjual.Name = "txtterjual"
        Me.txtterjual.Size = New System.Drawing.Size(180, 22)
        Me.txtterjual.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(499, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 31)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Jumlah Terjual"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(681, 249)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
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
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(248, 96)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
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
        Me.txtjudul.Size = New System.Drawing.Size(180, 22)
        Me.txtjudul.TabIndex = 97
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(248, 314)
        Me.txtPengarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPengarang.Name = "txtPengarang"
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
        Me.Label3.Size = New System.Drawing.Size(88, 31)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Jumlah"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(248, 382)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPenerbit.Name = "txtPenerbit"
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
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_buku, Me.Judul, Me.TahunTerbit, Me.Pengarang, Me.Penerbit, Me.JenisBuku, Me.Jumlah, Me.harga, Me.terjual})
        Me.dgv1.Location = New System.Drawing.Point(307, 156)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1063, 158)
        Me.dgv1.TabIndex = 128
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
        Me.Jumlah.HeaderText = "Jumlah"
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
        'terjual
        '
        Me.terjual.HeaderText = "Jumlah Terjual"
        Me.terjual.MinimumWidth = 6
        Me.terjual.Name = "terjual"
        Me.terjual.Width = 125
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1375, 713)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 37)
        Me.btnClear.TabIndex = 132
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.minimize_sign
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(1431, -4)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(47, 44)
        Me.Button9.TabIndex = 12
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources._exit
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1484, 0)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 44)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.logout
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1251, 7)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 49)
        Me.Button3.TabIndex = 119
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop1
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(53, 50)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(104, 92)
        Me.btnHome.TabIndex = 93
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnprofile
        '
        Me.btnprofile.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.btnprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprofile.FlatAppearance.BorderSize = 0
        Me.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprofile.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofile.Location = New System.Drawing.Point(53, 201)
        Me.btnprofile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(96, 82)
        Me.btnprofile.TabIndex = 92
        Me.btnprofile.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Location = New System.Drawing.Point(53, 631)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(96, 87)
        Me.btnTransaksi.TabIndex = 91
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.open_book
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(53, 492)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(96, 85)
        Me.btnBook.TabIndex = 90
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.recruitment
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(53, 353)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(96, 96)
        Me.btnUser.TabIndex = 89
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'ReadBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1531, 798)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ReadBuku"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtterjual As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtthun As TextBox
    Friend WithEvents Label7 As Label
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
    Friend WithEvents ID_buku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents Pengarang As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents JenisBuku As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents terjual As DataGridViewTextBoxColumn
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
