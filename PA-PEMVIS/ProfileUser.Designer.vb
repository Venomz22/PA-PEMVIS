<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileUser
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.txtid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAlamat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtnomorHp = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttglLahir = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtjk = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(160, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(975, 70)
        Me.Panel3.TabIndex = 132
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(275, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox1.TabIndex = 183
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(340, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 53)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "PROFILE DIRI"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(907, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 40)
        Me.Button3.TabIndex = 120
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.logout
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1064, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 40)
        Me.Button1.TabIndex = 119
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnprofile)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnBook)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 610)
        Me.Panel2.TabIndex = 131
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop1
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(40, 58)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(78, 75)
        Me.btnHome.TabIndex = 88
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnprofile
        '
        Me.btnprofile.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.btnprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprofile.FlatAppearance.BorderSize = 0
        Me.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprofile.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofile.Location = New System.Drawing.Point(40, 212)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(72, 67)
        Me.btnprofile.TabIndex = 87
        Me.btnprofile.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Location = New System.Drawing.Point(40, 495)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(72, 71)
        Me.btnTransaksi.TabIndex = 86
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.open_book
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(40, 366)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(72, 69)
        Me.btnBook.TabIndex = 85
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtid.HintForeColor = System.Drawing.Color.Empty
        Me.txtid.HintText = ""
        Me.txtid.isPassword = False
        Me.txtid.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtid.LineIdleColor = System.Drawing.Color.Gray
        Me.txtid.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtid.LineThickness = 5
        Me.txtid.Location = New System.Drawing.Point(582, 80)
        Me.txtid.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(288, 57)
        Me.txtid.TabIndex = 153
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtAlamat
        '
        Me.txtAlamat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlamat.Enabled = False
        Me.txtAlamat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txtAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAlamat.HintForeColor = System.Drawing.Color.Empty
        Me.txtAlamat.HintText = ""
        Me.txtAlamat.isPassword = False
        Me.txtAlamat.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtAlamat.LineIdleColor = System.Drawing.Color.Gray
        Me.txtAlamat.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtAlamat.LineThickness = 5
        Me.txtAlamat.Location = New System.Drawing.Point(582, 521)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(288, 56)
        Me.txtAlamat.TabIndex = 152
        Me.txtAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(369, 544)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 28)
        Me.Label13.TabIndex = 145
        Me.Label13.Text = "Alamat"
        '
        'txtnomorHp
        '
        Me.txtnomorHp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnomorHp.Enabled = False
        Me.txtnomorHp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txtnomorHp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnomorHp.HintForeColor = System.Drawing.Color.Empty
        Me.txtnomorHp.HintText = ""
        Me.txtnomorHp.isPassword = False
        Me.txtnomorHp.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtnomorHp.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnomorHp.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtnomorHp.LineThickness = 5
        Me.txtnomorHp.Location = New System.Drawing.Point(582, 434)
        Me.txtnomorHp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnomorHp.Name = "txtnomorHp"
        Me.txtnomorHp.Size = New System.Drawing.Size(288, 59)
        Me.txtnomorHp.TabIndex = 151
        Me.txtnomorHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(370, 459)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 28)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "Nomor HP"
        '
        'txttglLahir
        '
        Me.txttglLahir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttglLahir.Enabled = False
        Me.txttglLahir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txttglLahir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txttglLahir.HintForeColor = System.Drawing.Color.Empty
        Me.txttglLahir.HintText = ""
        Me.txttglLahir.isPassword = False
        Me.txttglLahir.LineFocusedColor = System.Drawing.Color.Blue
        Me.txttglLahir.LineIdleColor = System.Drawing.Color.Gray
        Me.txttglLahir.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txttglLahir.LineThickness = 5
        Me.txttglLahir.Location = New System.Drawing.Point(582, 358)
        Me.txttglLahir.Margin = New System.Windows.Forms.Padding(4)
        Me.txttglLahir.Name = "txttglLahir"
        Me.txttglLahir.Size = New System.Drawing.Size(288, 55)
        Me.txttglLahir.TabIndex = 150
        Me.txttglLahir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = ""
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUsername.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUsername.LineThickness = 5
        Me.txtUsername.Location = New System.Drawing.Point(582, 288)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(288, 62)
        Me.txtUsername.TabIndex = 149
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(369, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 28)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(368, 379)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 28)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "Tanggal Lahir"
        '
        'txtjk
        '
        Me.txtjk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjk.Enabled = False
        Me.txtjk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txtjk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtjk.HintForeColor = System.Drawing.Color.Empty
        Me.txtjk.HintText = ""
        Me.txtjk.isPassword = False
        Me.txtjk.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtjk.LineIdleColor = System.Drawing.Color.Gray
        Me.txtjk.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtjk.LineThickness = 5
        Me.txtjk.Location = New System.Drawing.Point(582, 230)
        Me.txtjk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtjk.Name = "txtjk"
        Me.txtjk.Size = New System.Drawing.Size(288, 50)
        Me.txtjk.TabIndex = 148
        Me.txtjk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(369, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnama.Enabled = False
        Me.txtnama.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.txtnama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnama.HintForeColor = System.Drawing.Color.Empty
        Me.txtnama.HintText = ""
        Me.txtnama.isPassword = False
        Me.txtnama.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtnama.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnama.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtnama.LineThickness = 5
        Me.txtnama.Location = New System.Drawing.Point(582, 160)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(288, 50)
        Me.txtnama.TabIndex = 147
        Me.txtnama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(369, 246)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 28)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(369, 316)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 28)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Username"
        '
        'ProfileUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1135, 610)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtnomorHp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txttglLahir)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtjk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProfileUser"
        Me.Text = "ProfileUser"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAlamat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtnomorHp As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents txttglLahir As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtjk As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnama As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
