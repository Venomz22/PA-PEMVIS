<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.rbCewek = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rpass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rusernamea = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tanggal = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.rAlamat = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rnomorHP = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rnama = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button5 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnback = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(265, 959)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 37)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Sudah Punya Akun ?"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLaki.Location = New System.Drawing.Point(81, 62)
        Me.RbLaki.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(135, 35)
        Me.RbLaki.TabIndex = 116
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki-laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'rbCewek
        '
        Me.rbCewek.AutoSize = True
        Me.rbCewek.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCewek.Location = New System.Drawing.Point(324, 62)
        Me.rbCewek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbCewek.Name = "rbCewek"
        Me.rbCewek.Size = New System.Drawing.Size(174, 35)
        Me.rbCewek.TabIndex = 117
        Me.rbCewek.TabStop = True
        Me.rbCewek.Text = "Perempuan"
        Me.rbCewek.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.rpass)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.rusernamea)
        Me.Panel3.Controls.Add(Me.tanggal)
        Me.Panel3.Controls.Add(Me.rAlamat)
        Me.Panel3.Controls.Add(Me.rnomorHP)
        Me.Panel3.Controls.Add(Me.rnama)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(28, 272)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(763, 1035)
        Me.Panel3.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(107, 745)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 28)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(107, 502)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 28)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(103, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 28)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Nomor Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(107, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 28)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(103, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 28)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(103, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Nama"
        '
        'rpass
        '
        Me.rpass.BorderColorFocused = System.Drawing.Color.Blue
        Me.rpass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rpass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.rpass.BorderThickness = 3
        Me.rpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rpass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rpass.isPassword = False
        Me.rpass.Location = New System.Drawing.Point(108, 329)
        Me.rpass.Margin = New System.Windows.Forms.Padding(5)
        Me.rpass.Name = "rpass"
        Me.rpass.Size = New System.Drawing.Size(568, 47)
        Me.rpass.TabIndex = 130
        Me.rpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rusernamea
        '
        Me.rusernamea.BorderColorFocused = System.Drawing.Color.Blue
        Me.rusernamea.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rusernamea.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.rusernamea.BorderThickness = 3
        Me.rusernamea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rusernamea.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rusernamea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rusernamea.isPassword = False
        Me.rusernamea.Location = New System.Drawing.Point(108, 218)
        Me.rusernamea.Margin = New System.Windows.Forms.Padding(5)
        Me.rusernamea.Name = "rusernamea"
        Me.rusernamea.Size = New System.Drawing.Size(568, 47)
        Me.rusernamea.TabIndex = 129
        Me.rusernamea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tanggal
        '
        Me.tanggal.BackColor = System.Drawing.Color.Tomato
        Me.tanggal.BorderRadius = 0
        Me.tanggal.ForeColor = System.Drawing.Color.White
        Me.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggal.FormatCustom = Nothing
        Me.tanggal.Location = New System.Drawing.Point(108, 775)
        Me.tanggal.Margin = New System.Windows.Forms.Padding(5)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(568, 44)
        Me.tanggal.TabIndex = 128
        Me.tanggal.Value = New Date(2023, 5, 17, 22, 47, 14, 544)
        '
        'rAlamat
        '
        Me.rAlamat.BorderColorFocused = System.Drawing.Color.Blue
        Me.rAlamat.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rAlamat.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.rAlamat.BorderThickness = 3
        Me.rAlamat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rAlamat.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rAlamat.isPassword = False
        Me.rAlamat.Location = New System.Drawing.Point(108, 534)
        Me.rAlamat.Margin = New System.Windows.Forms.Padding(5)
        Me.rAlamat.Name = "rAlamat"
        Me.rAlamat.Size = New System.Drawing.Size(568, 47)
        Me.rAlamat.TabIndex = 127
        Me.rAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rnomorHP
        '
        Me.rnomorHP.BorderColorFocused = System.Drawing.Color.Blue
        Me.rnomorHP.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rnomorHP.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.rnomorHP.BorderThickness = 3
        Me.rnomorHP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rnomorHP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rnomorHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rnomorHP.isPassword = False
        Me.rnomorHP.Location = New System.Drawing.Point(108, 430)
        Me.rnomorHP.Margin = New System.Windows.Forms.Padding(5)
        Me.rnomorHP.Name = "rnomorHP"
        Me.rnomorHP.Size = New System.Drawing.Size(568, 47)
        Me.rnomorHP.TabIndex = 126
        Me.rnomorHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rnama
        '
        Me.rnama.BorderColorFocused = System.Drawing.Color.Blue
        Me.rnama.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rnama.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.rnama.BorderThickness = 3
        Me.rnama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rnama.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rnama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rnama.isPassword = False
        Me.rnama.Location = New System.Drawing.Point(108, 105)
        Me.rnama.Margin = New System.Windows.Forms.Padding(5)
        Me.rnama.Name = "rnama"
        Me.rnama.Size = New System.Drawing.Size(568, 53)
        Me.rnama.TabIndex = 125
        Me.rnama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button5
        '
        Me.Button5.ActiveBorderThickness = 1
        Me.Button5.ActiveCornerRadius = 20
        Me.Button5.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Button5.ActiveForecolor = System.Drawing.Color.White
        Me.Button5.ActiveLineColor = System.Drawing.Color.Cyan
        Me.Button5.BackColor = System.Drawing.Color.LightSalmon
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.ButtonText = "BUAT"
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.IdleBorderThickness = 1
        Me.Button5.IdleCornerRadius = 20
        Me.Button5.IdleFillColor = System.Drawing.Color.White
        Me.Button5.IdleForecolor = System.Drawing.Color.Black
        Me.Button5.IdleLineColor = System.Drawing.Color.Cyan
        Me.Button5.Location = New System.Drawing.Point(244, 864)
        Me.Button5.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(288, 59)
        Me.Button5.TabIndex = 124
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rbCewek)
        Me.Panel2.Controls.Add(Me.RbLaki)
        Me.Panel2.Location = New System.Drawing.Point(108, 607)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 117)
        Me.Panel2.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(11, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 28)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 131)
        Me.Panel1.TabIndex = 183
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label10.Location = New System.Drawing.Point(207, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(491, 56)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "MANTAP BOOKSTORE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(68, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 108)
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(268, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(283, 56)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "BUAT AKUN"
        '
        'btnback
        '
        Me.btnback.ActiveBorderThickness = 1
        Me.btnback.ActiveCornerRadius = 20
        Me.btnback.ActiveFillColor = System.Drawing.Color.Red
        Me.btnback.ActiveForecolor = System.Drawing.Color.White
        Me.btnback.ActiveLineColor = System.Drawing.Color.Cyan
        Me.btnback.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnback.BackgroundImage = CType(resources.GetObject("btnback.BackgroundImage"), System.Drawing.Image)
        Me.btnback.ButtonText = "back"
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnback.IdleBorderThickness = 1
        Me.btnback.IdleCornerRadius = 20
        Me.btnback.IdleFillColor = System.Drawing.Color.White
        Me.btnback.IdleForecolor = System.Drawing.Color.Black
        Me.btnback.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnback.Location = New System.Drawing.Point(19, 142)
        Me.btnback.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(125, 50)
        Me.btnback.TabIndex = 187
        Me.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 863)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "register"
        Me.Text = "register"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents RbLaki As RadioButton
    Friend WithEvents rbCewek As RadioButton
    Friend WithEvents Button5 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rnama As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rnomorHP As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rAlamat As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tanggal As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents rpass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rusernamea As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnback As Bunifu.Framework.UI.BunifuThinButton2
End Class
