<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class belibuku
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtterjual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.terjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ID_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pengarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel4.Location = New System.Drawing.Point(265, 244)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(734, 351)
        Me.Panel4.TabIndex = 138
        '
        'cmbjenis
        '
        Me.cmbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"Horor", "Misteri", "Petualangan", "Musik", "Sejarah", "Drama", "Fiksi", "Fiksi Ilmiah", "Romansa", "Ensiklopedia"})
        Me.cmbjenis.Location = New System.Drawing.Point(511, 84)
        Me.cmbjenis.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(136, 21)
        Me.cmbjenis.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(314, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 26)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Detail Buku"
        '
        'txtterjual
        '
        Me.txtterjual.Location = New System.Drawing.Point(511, 262)
        Me.txtterjual.Margin = New System.Windows.Forms.Padding(2)
        Me.txtterjual.Name = "txtterjual"
        Me.txtterjual.Size = New System.Drawing.Size(136, 20)
        Me.txtterjual.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(374, 254)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 26)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Jumlah Terjual"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(511, 202)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(136, 20)
        Me.txtHarga.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(374, 195)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 26)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Harga Buku"
        '
        'txtthun
        '
        Me.txtthun.Location = New System.Drawing.Point(186, 202)
        Me.txtthun.Margin = New System.Windows.Forms.Padding(2)
        Me.txtthun.Name = "txtthun"
        Me.txtthun.Size = New System.Drawing.Size(136, 20)
        Me.txtthun.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 255)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 26)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Pengarang"
        '
        'btnbeli
        '
        Me.btnbeli.BackColor = System.Drawing.Color.SkyBlue
        Me.btnbeli.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbeli.Location = New System.Drawing.Point(530, 310)
        Me.btnbeli.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbeli.Name = "btnbeli"
        Me.btnbeli.Size = New System.Drawing.Size(88, 30)
        Me.btnbeli.TabIndex = 139
        Me.btnbeli.Text = "BELI"
        Me.btnbeli.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(186, 78)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(136, 20)
        Me.txtID.TabIndex = 107
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "ID Buku"
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(186, 136)
        Me.txtjudul.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(136, 20)
        Me.txtjudul.TabIndex = 97
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(186, 255)
        Me.txtPengarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(136, 20)
        Me.txtPengarang.TabIndex = 105
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(50, 130)
        Me.Nama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(107, 26)
        Me.Nama.TabIndex = 96
        Me.Nama.Text = "Judul Buku"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(511, 150)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(136, 20)
        Me.txtjumlah.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 26)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Jenis Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 26)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Jumlah"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(186, 310)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(136, 20)
        Me.txtPenerbit.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 26)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 303)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 26)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Penerbit"
        '
        'terjual
        '
        Me.terjual.HeaderText = "Jumlah Terjual"
        Me.terjual.MinimumWidth = 6
        Me.terjual.Name = "terjual"
        Me.terjual.Width = 125
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_buku, Me.Judul, Me.TahunTerbit, Me.Pengarang, Me.Penerbit, Me.JenisBuku, Me.Jumlah, Me.harga, Me.terjual})
        Me.dgv1.Location = New System.Drawing.Point(230, 90)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(797, 128)
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
        'Button5
        '
        Me.Button5.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.home
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(41, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 74)
        Me.Button5.TabIndex = 16
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(234, 6)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(563, 59)
        Me.Button12.TabIndex = 118
        Me.Button12.Text = "HI Admin !"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button32
        '
        Me.Button32.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.logout
        Me.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button32.FlatAppearance.BorderSize = 0
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(920, 7)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(48, 50)
        Me.Button32.TabIndex = 30
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button31)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 608)
        Me.Panel2.TabIndex = 134
        '
        'Button31
        '
        Me.Button31.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button31.FlatAppearance.BorderSize = 0
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Location = New System.Drawing.Point(41, 138)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(72, 67)
        Me.Button31.TabIndex = 15
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(41, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 71)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.open_book
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(41, 398)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 69)
        Me.Button4.TabIndex = 13
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.recruitment
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(41, 262)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 78)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1079, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 35)
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
        Me.Button1.Location = New System.Drawing.Point(1113, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.minimize_sign
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(1073, -3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(35, 36)
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
        Me.Button8.Location = New System.Drawing.Point(1113, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 36)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1147, 35)
        Me.Panel1.TabIndex = 133
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Button12)
        Me.Panel3.Controls.Add(Me.Button32)
        Me.Panel3.Location = New System.Drawing.Point(160, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(988, 70)
        Me.Panel3.TabIndex = 135
        '
        'belibuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 643)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "belibuku"
        Me.Text = "belibuku"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtterjual As TextBox
    Friend WithEvents Label9 As Label
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
    Friend WithEvents terjual As DataGridViewTextBoxColumn
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents ID_buku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents Pengarang As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents JenisBuku As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button31 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
