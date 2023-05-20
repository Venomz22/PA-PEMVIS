<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadUser))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtjk = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtnomorHp = New System.Windows.Forms.TextBox()
        Me.txttglLahir = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnprev = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnNext = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(160, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(975, 70)
        Me.Panel3.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 53)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "DAFTAR USER"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(915, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 40)
        Me.Button1.TabIndex = 119
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.txtjk)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.txtnama)
        Me.Panel4.Controls.Add(Me.txtUsername)
        Me.Panel4.Controls.Add(Me.txtAlamat)
        Me.Panel4.Controls.Add(Me.txtnomorHp)
        Me.Panel4.Controls.Add(Me.txttglLahir)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel4.Location = New System.Drawing.Point(229, 109)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(828, 422)
        Me.Panel4.TabIndex = 124
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(416, 241)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 28)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "Alamat"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(416, 134)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 28)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Nomor HP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(416, 49)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 28)
        Me.Label11.TabIndex = 149
        Me.Label11.Text = "Tanggal Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(19, 337)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 28)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(19, 245)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 24)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(18, 139)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 28)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Nama"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(19, 45)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 28)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "ID"
        '
        'txtjk
        '
        Me.txtjk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtjk.Location = New System.Drawing.Point(186, 239)
        Me.txtjk.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjk.Name = "txtjk"
        Me.txtjk.ReadOnly = True
        Me.txtjk.Size = New System.Drawing.Size(182, 32)
        Me.txtjk.TabIndex = 110
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(186, 42)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(182, 32)
        Me.txtID.TabIndex = 107
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtnama.Location = New System.Drawing.Point(186, 136)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(182, 32)
        Me.txtnama.TabIndex = 97
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtUsername.Location = New System.Drawing.Point(186, 337)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(182, 32)
        Me.txtUsername.TabIndex = 105
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtAlamat.Location = New System.Drawing.Point(604, 241)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(191, 32)
        Me.txtAlamat.TabIndex = 104
        '
        'txtnomorHp
        '
        Me.txtnomorHp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txtnomorHp.Location = New System.Drawing.Point(604, 141)
        Me.txtnomorHp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnomorHp.Name = "txtnomorHp"
        Me.txtnomorHp.ReadOnly = True
        Me.txtnomorHp.Size = New System.Drawing.Size(191, 32)
        Me.txtnomorHp.TabIndex = 103
        '
        'txttglLahir
        '
        Me.txttglLahir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.txttglLahir.Location = New System.Drawing.Point(604, 45)
        Me.txttglLahir.Margin = New System.Windows.Forms.Padding(2)
        Me.txttglLahir.Name = "txttglLahir"
        Me.txttglLahir.ReadOnly = True
        Me.txttglLahir.Size = New System.Drawing.Size(191, 32)
        Me.txttglLahir.TabIndex = 102
        '
        'Panel2
        '
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
        Me.Panel2.TabIndex = 121
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop1
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(40, 4)
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
        Me.btnprofile.Location = New System.Drawing.Point(40, 127)
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
        Me.btnTransaksi.Location = New System.Drawing.Point(40, 500)
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
        Me.btnBook.Location = New System.Drawing.Point(40, 387)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(72, 69)
        Me.btnBook.TabIndex = 85
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.recruitment
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(40, 250)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(72, 78)
        Me.btnUser.TabIndex = 84
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.ActiveBorderThickness = 1
        Me.btnprev.ActiveCornerRadius = 20
        Me.btnprev.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnprev.ActiveForecolor = System.Drawing.Color.White
        Me.btnprev.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnprev.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnprev.BackgroundImage = CType(resources.GetObject("btnprev.BackgroundImage"), System.Drawing.Image)
        Me.btnprev.ButtonText = "PREV"
        Me.btnprev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprev.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnprev.IdleBorderThickness = 1
        Me.btnprev.IdleCornerRadius = 20
        Me.btnprev.IdleFillColor = System.Drawing.Color.White
        Me.btnprev.IdleForecolor = System.Drawing.Color.Black
        Me.btnprev.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnprev.Location = New System.Drawing.Point(487, 543)
        Me.btnprev.Margin = New System.Windows.Forms.Padding(5)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(107, 53)
        Me.btnprev.TabIndex = 189
        Me.btnprev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.ActiveBorderThickness = 1
        Me.btnNext.ActiveCornerRadius = 20
        Me.btnNext.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnNext.ActiveForecolor = System.Drawing.Color.White
        Me.btnNext.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.ButtonText = "NEXT"
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnNext.IdleBorderThickness = 1
        Me.btnNext.IdleCornerRadius = 20
        Me.btnNext.IdleFillColor = System.Drawing.Color.White
        Me.btnNext.IdleForecolor = System.Drawing.Color.Black
        Me.btnNext.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnNext.Location = New System.Drawing.Point(668, 543)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 53)
        Me.btnNext.TabIndex = 190
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReadUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1135, 610)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ReadUser"
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtjk As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtnomorHp As TextBox
    Friend WithEvents txttglLahir As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnprev As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnNext As Bunifu.Framework.UI.BunifuThinButton2
End Class
