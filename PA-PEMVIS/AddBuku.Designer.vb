<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBuku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBuku))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtthun = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtterjual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.txtGambar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnTambah = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Button1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button32)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(160, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(975, 70)
        Me.Panel3.TabIndex = 134
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
        Me.Label11.Size = New System.Drawing.Size(330, 53)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "TAMBAH BUKU"
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
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 610)
        Me.Panel2.TabIndex = 133
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(186, 345)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(136, 20)
        Me.txtPenerbit.TabIndex = 102
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(511, 114)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(136, 20)
        Me.txtjumlah.TabIndex = 104
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(186, 267)
        Me.txtPengarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(136, 20)
        Me.txtPengarang.TabIndex = 105
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(186, 114)
        Me.txtjudul.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(136, 20)
        Me.txtjudul.TabIndex = 97
        '
        'txtthun
        '
        Me.txtthun.Location = New System.Drawing.Point(186, 189)
        Me.txtthun.Margin = New System.Windows.Forms.Padding(2)
        Me.txtthun.Name = "txtthun"
        Me.txtthun.Size = New System.Drawing.Size(136, 20)
        Me.txtthun.TabIndex = 110
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(511, 189)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(136, 20)
        Me.txtHarga.TabIndex = 112
        '
        'txtterjual
        '
        Me.txtterjual.Location = New System.Drawing.Point(511, 265)
        Me.txtterjual.Margin = New System.Windows.Forms.Padding(2)
        Me.txtterjual.Name = "txtterjual"
        Me.txtterjual.ReadOnly = True
        Me.txtterjual.Size = New System.Drawing.Size(136, 20)
        Me.txtterjual.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(314, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 26)
        Me.Label10.TabIndex = 73
        '
        'cmbjenis
        '
        Me.cmbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"Horor", "Misteri", "Petualangan", "Musik", "Sejarah", "Drama", "Fiksi", "Fiksi Ilmiah", "Romansa", "Ensiklopedia"})
        Me.cmbjenis.Location = New System.Drawing.Point(511, 35)
        Me.cmbjenis.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(136, 21)
        Me.cmbjenis.TabIndex = 115
        '
        'txtGambar
        '
        Me.txtGambar.Location = New System.Drawing.Point(511, 349)
        Me.txtGambar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGambar.Name = "txtGambar"
        Me.txtGambar.ReadOnly = True
        Me.txtGambar.Size = New System.Drawing.Size(136, 20)
        Me.txtGambar.TabIndex = 142
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(51, 36)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 22)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "ID Buku"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(186, 36)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(136, 20)
        Me.txtID.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(51, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 22)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "Judul Buku"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(51, 187)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 22)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "Tahun Terbit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(51, 343)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 22)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "Penerbit"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.txtGambar)
        Me.Panel4.Controls.Add(Me.cmbjenis)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtterjual)
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.Controls.Add(Me.txtthun)
        Me.Panel4.Controls.Add(Me.txtjudul)
        Me.Panel4.Controls.Add(Me.txtPengarang)
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.txtPenerbit)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel4.Location = New System.Drawing.Point(265, 109)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(734, 420)
        Me.Panel4.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(365, 345)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "Pilih File"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(363, 263)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 22)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Jumlah Terjual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(365, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 22)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Jenis Buku"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(365, 185)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 22)
        Me.Label15.TabIndex = 190
        Me.Label15.Text = "Harga Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(365, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 22)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(51, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Pengarang"
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
        Me.btnClear.Location = New System.Drawing.Point(472, 536)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 53)
        Me.btnClear.TabIndex = 188
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnTambah.ButtonText = "Simpan"
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnTambah.IdleBorderThickness = 1
        Me.btnTambah.IdleCornerRadius = 20
        Me.btnTambah.IdleFillColor = System.Drawing.Color.White
        Me.btnTambah.IdleForecolor = System.Drawing.Color.Black
        Me.btnTambah.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnTambah.Location = New System.Drawing.Point(678, 536)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(107, 53)
        Me.btnTambah.TabIndex = 187
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.ActiveBorderThickness = 1
        Me.Button1.ActiveCornerRadius = 20
        Me.Button1.ActiveFillColor = System.Drawing.Color.Lime
        Me.Button1.ActiveForecolor = System.Drawing.Color.White
        Me.Button1.ActiveLineColor = System.Drawing.Color.Cyan
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.ButtonText = "FILE"
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.IdleBorderThickness = 1
        Me.Button1.IdleCornerRadius = 20
        Me.Button1.IdleFillColor = System.Drawing.Color.White
        Me.Button1.IdleForecolor = System.Drawing.Color.Black
        Me.Button1.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.Button1.Location = New System.Drawing.Point(653, 343)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 34)
        Me.Button1.TabIndex = 189
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button32
        '
        Me.Button32.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button32.FlatAppearance.BorderSize = 0
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(915, 12)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(38, 40)
        Me.Button32.TabIndex = 30
        Me.Button32.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop1
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(40, 21)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(78, 75)
        Me.btnHome.TabIndex = 83
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnprofile
        '
        Me.btnprofile.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.btnprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprofile.FlatAppearance.BorderSize = 0
        Me.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprofile.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofile.Location = New System.Drawing.Point(40, 145)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(72, 67)
        Me.btnprofile.TabIndex = 82
        Me.btnprofile.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Location = New System.Drawing.Point(40, 518)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(72, 71)
        Me.btnTransaksi.TabIndex = 81
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.open_book
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(40, 405)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(72, 69)
        Me.btnBook.TabIndex = 80
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.recruitment
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(40, 268)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(72, 78)
        Me.btnUser.TabIndex = 79
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'AddBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1135, 610)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddBuku"
        Me.Text = "Form3"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button32 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents BukaFile As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents btnTambah As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtthun As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtterjual As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents txtGambar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Bunifu.Framework.UI.BunifuThinButton2
End Class
