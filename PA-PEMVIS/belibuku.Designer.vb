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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(belibuku))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtthun = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnbeli = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBatal = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.btnbeli)
        Me.Panel4.Controls.Add(Me.btnBatal)
        Me.Panel4.Controls.Add(Me.btnBack)
        Me.Panel4.Controls.Add(Me.txtjenis)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.Controls.Add(Me.txtthun)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.txtjudul)
        Me.Panel4.Controls.Add(Me.txtPengarang)
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.txtPenerbit)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel4.Location = New System.Drawing.Point(176, 252)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(734, 351)
        Me.Panel4.TabIndex = 138
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(511, 84)
        Me.txtjenis.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.ReadOnly = True
        Me.txtjenis.Size = New System.Drawing.Size(136, 20)
        Me.txtjenis.TabIndex = 140
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(286, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 26)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Detail Buku"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(511, 202)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(136, 20)
        Me.txtHarga.TabIndex = 112
        '
        'txtthun
        '
        Me.txtthun.Location = New System.Drawing.Point(186, 202)
        Me.txtthun.Margin = New System.Windows.Forms.Padding(2)
        Me.txtthun.Name = "txtthun"
        Me.txtthun.ReadOnly = True
        Me.txtthun.Size = New System.Drawing.Size(136, 20)
        Me.txtthun.TabIndex = 110
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(186, 78)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(136, 20)
        Me.txtID.TabIndex = 107
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(186, 136)
        Me.txtjudul.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.ReadOnly = True
        Me.txtjudul.Size = New System.Drawing.Size(136, 20)
        Me.txtjudul.TabIndex = 97
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(186, 255)
        Me.txtPengarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.ReadOnly = True
        Me.txtPengarang.Size = New System.Drawing.Size(136, 20)
        Me.txtPengarang.TabIndex = 105
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(511, 150)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.ReadOnly = True
        Me.txtjumlah.Size = New System.Drawing.Size(136, 20)
        Me.txtjumlah.TabIndex = 104
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(186, 310)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.ReadOnly = True
        Me.txtPenerbit.Size = New System.Drawing.Size(136, 20)
        Me.txtPenerbit.TabIndex = 102
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_buku, Me.Judul, Me.TahunTerbit, Me.Pengarang, Me.Penerbit, Me.JenisBuku, Me.Jumlah, Me.harga, Me.Gambar})
        Me.dgv1.Location = New System.Drawing.Point(176, 89)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(960, 128)
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
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnProfile)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnbook)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(154, 643)
        Me.Panel2.TabIndex = 134
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(154, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(993, 72)
        Me.Panel3.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(317, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(319, 53)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "DAFTAR BUKU"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(51, 78)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 22)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "ID Buku"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(49, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Judul Buku"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(49, 198)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 22)
        Me.Label9.TabIndex = 195
        Me.Label9.Text = "Tahun Terbit"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(51, 253)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 22)
        Me.Label13.TabIndex = 196
        Me.Label13.Text = "Pengarang"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(51, 306)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 22)
        Me.Label14.TabIndex = 197
        Me.Label14.Text = "Penerbit"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(375, 80)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 22)
        Me.Label15.TabIndex = 198
        Me.Label15.Text = "Jenis Buku"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(375, 148)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 22)
        Me.Label16.TabIndex = 199
        Me.Label16.Text = "Stok Buku"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(375, 198)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 22)
        Me.Label17.TabIndex = 200
        Me.Label17.Text = "Harga Buku"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(924, 252)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 351)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 140
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(926, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 40)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnbeli
        '
        Me.btnbeli.ActiveBorderThickness = 1
        Me.btnbeli.ActiveCornerRadius = 20
        Me.btnbeli.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnbeli.ActiveForecolor = System.Drawing.Color.White
        Me.btnbeli.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnbeli.BackColor = System.Drawing.Color.LightSalmon
        Me.btnbeli.BackgroundImage = CType(resources.GetObject("btnbeli.BackgroundImage"), System.Drawing.Image)
        Me.btnbeli.ButtonText = "Beli"
        Me.btnbeli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbeli.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbeli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnbeli.IdleBorderThickness = 1
        Me.btnbeli.IdleCornerRadius = 20
        Me.btnbeli.IdleFillColor = System.Drawing.Color.White
        Me.btnbeli.IdleForecolor = System.Drawing.Color.Black
        Me.btnbeli.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnbeli.Location = New System.Drawing.Point(392, 292)
        Me.btnbeli.Margin = New System.Windows.Forms.Padding(5)
        Me.btnbeli.Name = "btnbeli"
        Me.btnbeli.Size = New System.Drawing.Size(103, 53)
        Me.btnbeli.TabIndex = 192
        Me.btnbeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBatal
        '
        Me.btnBatal.ActiveBorderThickness = 1
        Me.btnBatal.ActiveCornerRadius = 20
        Me.btnBatal.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnBatal.ActiveForecolor = System.Drawing.Color.White
        Me.btnBatal.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnBatal.BackColor = System.Drawing.Color.LightSalmon
        Me.btnBatal.BackgroundImage = CType(resources.GetObject("btnBatal.BackgroundImage"), System.Drawing.Image)
        Me.btnBatal.ButtonText = "Batal"
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBatal.IdleBorderThickness = 1
        Me.btnBatal.IdleCornerRadius = 20
        Me.btnBatal.IdleFillColor = System.Drawing.Color.White
        Me.btnBatal.IdleForecolor = System.Drawing.Color.Black
        Me.btnBatal.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnBatal.Location = New System.Drawing.Point(622, 292)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(98, 53)
        Me.btnBatal.TabIndex = 190
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 1
        Me.btnBack.ActiveCornerRadius = 20
        Me.btnBack.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnBack.ActiveForecolor = System.Drawing.Color.White
        Me.btnBack.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnBack.BackColor = System.Drawing.Color.LightSalmon
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Selesai"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 20
        Me.btnBack.IdleFillColor = System.Drawing.Color.White
        Me.btnBack.IdleForecolor = System.Drawing.Color.Black
        Me.btnBack.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnBack.Location = New System.Drawing.Point(511, 292)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(101, 53)
        Me.btnBack.TabIndex = 189
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop2
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(42, 64)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(72, 67)
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
        Me.btnProfile.Location = New System.Drawing.Point(42, 208)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(72, 67)
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
        Me.btnTransaksi.Location = New System.Drawing.Point(42, 505)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(72, 71)
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
        Me.btnbook.Location = New System.Drawing.Point(42, 353)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(72, 69)
        Me.btnbook.TabIndex = 13
        Me.btnbook.UseVisualStyleBackColor = True
        '
        'belibuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 643)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "belibuku"
        Me.Text = "belibuku"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtthun As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
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
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBatal As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnbeli As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
End Class
