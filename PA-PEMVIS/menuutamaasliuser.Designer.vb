<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuutamaasliuser
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.welcome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnProfile = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnbook = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTransaksi = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.welcome1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnbook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.welcome1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.welcome)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1318, 86)
        Me.Panel3.TabIndex = 117
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button1.ImageActive = Nothing
        Me.Button1.Location = New System.Drawing.Point(1228, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 66)
        Me.Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Button1.TabIndex = 139
        Me.Button1.TabStop = False
        Me.Button1.Zoom = 10
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.welcome.ForeColor = System.Drawing.Color.SandyBrown
        Me.welcome.Location = New System.Drawing.Point(544, 11)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(0, 67)
        Me.welcome.TabIndex = 120
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Controls.Add(Me.btnProfile)
        Me.Panel2.Controls.Add(Me.btnbook)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 798)
        Me.Panel2.TabIndex = 116
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.PA_PEMVIS.My.Resources.Resources.book_shop
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(53, 34)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(109, 101)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 138
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.Image = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.btnProfile.ImageActive = Nothing
        Me.btnProfile.Location = New System.Drawing.Point(53, 218)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(109, 101)
        Me.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnProfile.TabIndex = 134
        Me.btnProfile.TabStop = False
        Me.btnProfile.Zoom = 10
        '
        'btnbook
        '
        Me.btnbook.BackColor = System.Drawing.Color.Transparent
        Me.btnbook.Image = Global.PA_PEMVIS.My.Resources.Resources.open_book1
        Me.btnbook.ImageActive = Nothing
        Me.btnbook.Location = New System.Drawing.Point(53, 410)
        Me.btnbook.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(109, 117)
        Me.btnbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnbook.TabIndex = 136
        Me.btnbook.TabStop = False
        Me.btnbook.Zoom = 10
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaksi.Image = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.btnTransaksi.ImageActive = Nothing
        Me.btnTransaksi.Location = New System.Drawing.Point(53, 608)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(109, 117)
        Me.btnTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTransaksi.TabIndex = 137
        Me.btnTransaksi.TabStop = False
        Me.btnTransaksi.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(481, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(790, 126)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Selamat datang di toko Mantap disini kamu bisa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "beli buku dengan banyak pilihan " &
    "dari kategori sampai" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " judul yang lengkap hanya ada di toko ini"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(629, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(480, 67)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Di TOKO MANTAP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(617, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(489, 67)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "SELAMAT DATANG"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(769, 218)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(203, 192)
        Me.PictureBox3.TabIndex = 126
        Me.PictureBox3.TabStop = False
        '
        'welcome1
        '
        Me.welcome1.AutoSize = True
        Me.welcome1.BackColor = System.Drawing.Color.Transparent
        Me.welcome1.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.welcome1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.welcome1.Location = New System.Drawing.Point(462, 10)
        Me.welcome1.Name = "welcome1"
        Me.welcome1.Size = New System.Drawing.Size(489, 67)
        Me.welcome1.TabIndex = 127
        Me.welcome1.Text = "SELAMAT DATANG"
        '
        'menuutamaasliuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1531, 798)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "menuutamaasliuser"
        Me.Text = "menuutamaasliuser"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnbook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents welcome As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnTransaksi As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnbook As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnProfile As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Button1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents welcome1 As Label
End Class
