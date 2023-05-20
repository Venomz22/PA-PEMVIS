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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadBuku))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtterjual = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtthun = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuThinButton2()
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
        Me.Gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHapus = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnTambah = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnClear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1318, 86)
        Me.Panel3.TabIndex = 126
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(420, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(398, 67)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "DAFTAR BUKU"
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1227, 15)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(51, 49)
        Me.btnLogout.TabIndex = 119
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
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
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop1
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(53, 50)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnprofile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(96, 96)
        Me.btnUser.TabIndex = 89
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.cmbjenis)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtterjual)
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.Controls.Add(Me.txtthun)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.txtjudul)
        Me.Panel4.Controls.Add(Me.txtPengarang)
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.txtPenerbit)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel4.Location = New System.Drawing.Point(251, 286)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(948, 432)
        Me.Panel4.TabIndex = 129
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(484, 320)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(184, 28)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "Jumlah Terjual"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(484, 238)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(149, 28)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "Harga Buku"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(484, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 28)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "Jumlah"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(484, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 28)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Jenis Buku"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(27, 385)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 28)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "Penerbit"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(27, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 28)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "Pengarang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(27, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 28)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 28)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Judul Buku"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(27, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 28)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "ID Buku"
        '
        'cmbjenis
        '
        Me.cmbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjenis.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"Horor", "Misteri", "Petualangan", "Musik", "Sejarah", "Drama", "Fiksi", "Fiksi Ilmiah", "Romansa", "Ensiklopedia"})
        Me.cmbjenis.Location = New System.Drawing.Point(696, 94)
        Me.cmbjenis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(216, 36)
        Me.cmbjenis.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(256, 44)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Detail Buku"
        '
        'txtterjual
        '
        Me.txtterjual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtterjual.Location = New System.Drawing.Point(696, 320)
        Me.txtterjual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtterjual.Name = "txtterjual"
        Me.txtterjual.ReadOnly = True
        Me.txtterjual.Size = New System.Drawing.Size(216, 35)
        Me.txtterjual.TabIndex = 114
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtHarga.Location = New System.Drawing.Point(696, 238)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(216, 35)
        Me.txtHarga.TabIndex = 112
        '
        'txtthun
        '
        Me.txtthun.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtthun.Location = New System.Drawing.Point(223, 238)
        Me.txtthun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtthun.Name = "txtthun"
        Me.txtthun.Size = New System.Drawing.Size(216, 35)
        Me.txtthun.TabIndex = 110
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtID.Location = New System.Drawing.Point(223, 94)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(216, 35)
        Me.txtID.TabIndex = 107
        '
        'txtjudul
        '
        Me.txtjudul.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtjudul.Location = New System.Drawing.Point(223, 167)
        Me.txtjudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(216, 35)
        Me.txtjudul.TabIndex = 97
        '
        'txtPengarang
        '
        Me.txtPengarang.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtPengarang.Location = New System.Drawing.Point(223, 314)
        Me.txtPengarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(216, 35)
        Me.txtPengarang.TabIndex = 105
        '
        'txtjumlah
        '
        Me.txtjumlah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtjumlah.Location = New System.Drawing.Point(696, 167)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(216, 35)
        Me.txtjumlah.TabIndex = 104
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.txtPenerbit.Location = New System.Drawing.Point(223, 382)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(216, 35)
        Me.txtPenerbit.TabIndex = 102
        '
        'btnEdit
        '
        Me.btnEdit.ActiveBorderThickness = 1
        Me.btnEdit.ActiveCornerRadius = 20
        Me.btnEdit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEdit.ActiveForecolor = System.Drawing.Color.White
        Me.btnEdit.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.ButtonText = "Edit"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnEdit.IdleBorderThickness = 1
        Me.btnEdit.IdleCornerRadius = 20
        Me.btnEdit.IdleFillColor = System.Drawing.Color.White
        Me.btnEdit.IdleForecolor = System.Drawing.Color.Black
        Me.btnEdit.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnEdit.Location = New System.Drawing.Point(605, 726)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(148, 65)
        Me.btnEdit.TabIndex = 189
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_buku, Me.Judul, Me.TahunTerbit, Me.Pengarang, Me.Penerbit, Me.JenisBuku, Me.Jumlah, Me.harga, Me.terjual, Me.Gambar})
        Me.dgv1.Location = New System.Drawing.Point(251, 106)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1264, 158)
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
        'Gambar
        '
        Me.Gambar.HeaderText = "Gambar"
        Me.Gambar.MinimumWidth = 6
        Me.Gambar.Name = "Gambar"
        Me.Gambar.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1229, 286)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 133
        Me.PictureBox1.TabStop = False
        '
        'btnHapus
        '
        Me.btnHapus.ActiveBorderThickness = 1
        Me.btnHapus.ActiveCornerRadius = 20
        Me.btnHapus.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnHapus.ActiveForecolor = System.Drawing.Color.White
        Me.btnHapus.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.ButtonText = "Hapus"
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnHapus.IdleBorderThickness = 1
        Me.btnHapus.IdleCornerRadius = 20
        Me.btnHapus.IdleFillColor = System.Drawing.Color.White
        Me.btnHapus.IdleForecolor = System.Drawing.Color.Black
        Me.btnHapus.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnHapus.Location = New System.Drawing.Point(795, 726)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(148, 65)
        Me.btnHapus.TabIndex = 190
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTambah
        '
        Me.btnTambah.ActiveBorderThickness = 1
        Me.btnTambah.ActiveCornerRadius = 20
        Me.btnTambah.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnTambah.ActiveForecolor = System.Drawing.Color.White
        Me.btnTambah.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.ButtonText = "Tambah"
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnTambah.IdleBorderThickness = 1
        Me.btnTambah.IdleCornerRadius = 20
        Me.btnTambah.IdleFillColor = System.Drawing.Color.White
        Me.btnTambah.IdleForecolor = System.Drawing.Color.Black
        Me.btnTambah.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnTambah.Location = New System.Drawing.Point(416, 726)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(148, 65)
        Me.btnTambah.TabIndex = 191
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.ActiveBorderThickness = 1
        Me.btnClear.ActiveCornerRadius = 20
        Me.btnClear.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnClear.ActiveForecolor = System.Drawing.Color.White
        Me.btnClear.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.ButtonText = "Clear"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnClear.IdleBorderThickness = 1
        Me.btnClear.IdleCornerRadius = 20
        Me.btnClear.IdleFillColor = System.Drawing.Color.White
        Me.btnClear.IdleForecolor = System.Drawing.Color.Black
        Me.btnClear.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnClear.Location = New System.Drawing.Point(989, 726)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 65)
        Me.btnClear.TabIndex = 192
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReadBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1531, 798)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ReadBuku"
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtterjual As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtthun As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents ID_buku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents Pengarang As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents JenisBuku As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents terjual As DataGridViewTextBoxColumn
    Friend WithEvents Gambar As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnHapus As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnTambah As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuThinButton2
End Class
