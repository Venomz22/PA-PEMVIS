<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiUser
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
        Me.txtIDUser = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.terjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIDUser
        '
        Me.txtIDUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtIDUser.Location = New System.Drawing.Point(248, 143)
        Me.txtIDUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIDUser.Name = "txtIDUser"
        Me.txtIDUser.ReadOnly = True
        Me.txtIDUser.Size = New System.Drawing.Size(267, 38)
        Me.txtIDUser.TabIndex = 119
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtPayment.Location = New System.Drawing.Point(785, 230)
        Me.txtPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.Size = New System.Drawing.Size(233, 38)
        Me.txtPayment.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 18.0!)
        Me.Label10.Location = New System.Drawing.Point(380, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(290, 35)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Detail Transaksi"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtJumlah.Location = New System.Drawing.Point(785, 148)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.ReadOnly = True
        Me.txtJumlah.Size = New System.Drawing.Size(233, 38)
        Me.txtJumlah.TabIndex = 110
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtID.Location = New System.Drawing.Point(248, 54)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(267, 38)
        Me.txtID.TabIndex = 107
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtHarga.Location = New System.Drawing.Point(785, 54)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(233, 38)
        Me.txtHarga.TabIndex = 105
        '
        'txtjudul
        '
        Me.txtjudul.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtjudul.Location = New System.Drawing.Point(248, 215)
        Me.txtjudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjudul.Multiline = True
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.ReadOnly = True
        Me.txtjudul.Size = New System.Drawing.Size(267, 121)
        Me.txtjudul.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnprofile)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnBook)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 751)
        Me.Panel2.TabIndex = 138
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
        Me.btnTransaksi.Location = New System.Drawing.Point(53, 524)
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
        Me.btnBook.Location = New System.Drawing.Point(53, 354)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(96, 85)
        Me.btnBook.TabIndex = 90
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_buku, Me.Judul, Me.TahunTerbit, Me.Jumlah, Me.harga, Me.terjual, Me.Tanggal})
        Me.dgv1.Location = New System.Drawing.Point(307, 108)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1063, 210)
        Me.dgv1.TabIndex = 140
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(213, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1300, 86)
        Me.Panel3.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(359, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(542, 67)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "DAFTAR TRANSAKSI"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1220, 14)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 49)
        Me.Button3.TabIndex = 119
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtTanggal)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtIDUser)
        Me.Panel4.Controls.Add(Me.txtPayment)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtJumlah)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.txtjudul)
        Me.Panel4.Controls.Add(Me.txtHarga)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel4.Location = New System.Drawing.Point(307, 354)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1063, 364)
        Me.Panel4.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(565, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 34)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Tanggal"
        '
        'txtTanggal
        '
        Me.txtTanggal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtTanggal.Location = New System.Drawing.Point(785, 298)
        Me.txtTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.ReadOnly = True
        Me.txtTanggal.Size = New System.Drawing.Size(233, 38)
        Me.txtTanggal.TabIndex = 155
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(11, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(197, 34)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "ID Transaksi"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(565, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 34)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "Payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(565, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 34)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "Total Jumlah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(565, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 34)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Total Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 34)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Nama User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(11, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 34)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Judul Buku"
        '
        'ID_buku
        '
        Me.ID_buku.HeaderText = "ID Transaksi"
        Me.ID_buku.MinimumWidth = 6
        Me.ID_buku.Name = "ID_buku"
        Me.ID_buku.Width = 125
        '
        'Judul
        '
        Me.Judul.HeaderText = "Nama User"
        Me.Judul.MinimumWidth = 6
        Me.Judul.Name = "Judul"
        Me.Judul.Width = 125
        '
        'TahunTerbit
        '
        Me.TahunTerbit.HeaderText = "Judul Buku"
        Me.TahunTerbit.MinimumWidth = 6
        Me.TahunTerbit.Name = "TahunTerbit"
        Me.TahunTerbit.Width = 125
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Total Jumlah"
        Me.Jumlah.MinimumWidth = 6
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 125
        '
        'harga
        '
        Me.harga.HeaderText = "Total Harga"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        Me.harga.Width = 125
        '
        'terjual
        '
        Me.terjual.HeaderText = "Payment"
        Me.terjual.MinimumWidth = 6
        Me.terjual.Name = "terjual"
        Me.terjual.Width = 125
        '
        'Tanggal
        '
        Me.Tanggal.HeaderText = "Tanggal Transaksi"
        Me.Tanggal.MinimumWidth = 6
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Width = 125
        '
        'TransaksiUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1513, 751)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TransaksiUser"
        Me.Text = "TransaksiUser"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIDUser As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBook As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents ID_buku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents terjual As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As DataGridViewTextBoxColumn
End Class
