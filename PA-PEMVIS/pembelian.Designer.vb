<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pembelian))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.judul = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBatal = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button32)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(160, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(988, 70)
        Me.Panel3.TabIndex = 124
        '
        'Button32
        '
        Me.Button32.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button32.FlatAppearance.BorderSize = 0
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(911, 7)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(48, 50)
        Me.Button32.TabIndex = 31
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnProfile)
        Me.Panel2.Controls.Add(Me.btnTransaksi)
        Me.Panel2.Controls.Add(Me.btnbook)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 648)
        Me.Panel2.TabIndex = 123
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop2
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(44, 58)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(72, 67)
        Me.btnHome.TabIndex = 21
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.user
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(44, 208)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(72, 67)
        Me.btnProfile.TabIndex = 20
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.cash_machine
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Location = New System.Drawing.Point(44, 523)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(72, 71)
        Me.btnTransaksi.TabIndex = 19
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'btnbook
        '
        Me.btnbook.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.open_book
        Me.btnbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbook.FlatAppearance.BorderSize = 0
        Me.btnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbook.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbook.Location = New System.Drawing.Point(44, 374)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(72, 69)
        Me.btnbook.TabIndex = 18
        Me.btnbook.UseVisualStyleBackColor = True
        '
        'judul
        '
        Me.judul.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.judul.Location = New System.Drawing.Point(328, 52)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(235, 35)
        Me.judul.TabIndex = 125
        '
        'jumlah
        '
        Me.jumlah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.jumlah.Location = New System.Drawing.Point(328, 151)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(235, 35)
        Me.jumlah.TabIndex = 131
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.total.Location = New System.Drawing.Point(328, 249)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(235, 35)
        Me.total.TabIndex = 132
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.btnBatal)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Button15)
        Me.Panel4.Controls.Add(Me.Button14)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.judul)
        Me.Panel4.Controls.Add(Me.jumlah)
        Me.Panel4.Controls.Add(Me.total)
        Me.Panel4.Location = New System.Drawing.Point(196, 156)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(912, 421)
        Me.Panel4.TabIndex = 133
        '
        'Button5
        '
        Me.Button5.ActiveBorderThickness = 1
        Me.Button5.ActiveCornerRadius = 20
        Me.Button5.ActiveFillColor = System.Drawing.Color.Lime
        Me.Button5.ActiveForecolor = System.Drawing.Color.White
        Me.Button5.ActiveLineColor = System.Drawing.Color.Cyan
        Me.Button5.BackColor = System.Drawing.Color.LightSalmon
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.ButtonText = "Beli"
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.IdleBorderThickness = 1
        Me.Button5.IdleCornerRadius = 20
        Me.Button5.IdleFillColor = System.Drawing.Color.White
        Me.Button5.IdleForecolor = System.Drawing.Color.Black
        Me.Button5.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.Button5.Location = New System.Drawing.Point(328, 364)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 43)
        Me.Button5.TabIndex = 186
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBatal
        '
        Me.btnBatal.ActiveBorderThickness = 1
        Me.btnBatal.ActiveCornerRadius = 20
        Me.btnBatal.ActiveFillColor = System.Drawing.Color.Red
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
        Me.btnBatal.Location = New System.Drawing.Point(467, 364)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(96, 43)
        Me.btnBatal.TabIndex = 185
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(608, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'Button15
        '
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Button15.Location = New System.Drawing.Point(284, 242)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(38, 42)
        Me.Button15.TabIndex = 138
        Me.Button15.Text = ":"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Button14.Location = New System.Drawing.Point(284, 144)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(38, 42)
        Me.Button14.TabIndex = 137
        Me.Button14.Text = ":"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Button6.Location = New System.Drawing.Point(284, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 42)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = ":"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(301, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(366, 53)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Pembelian Buku"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(39, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 28)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "JUDUL BUKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(39, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 28)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "JUMLAH BUKU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(39, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 28)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "TOTAL PEMBELIAN"
        '
        'pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 648)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pembelian"
        Me.Text = "pembelian"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents judul As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnbook As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnBatal As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
