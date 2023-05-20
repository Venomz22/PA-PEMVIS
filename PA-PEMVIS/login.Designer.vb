<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lnamed = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lpasss = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(221, 646)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(181, 30)
        Me.Button6.TabIndex = 83
        Me.Button6.Text = "Belum Punya Akun ?"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'lnamed
        '
        Me.lnamed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lnamed.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnamed.HintForeColor = System.Drawing.Color.Empty
        Me.lnamed.HintText = ""
        Me.lnamed.isPassword = False
        Me.lnamed.LineFocusedColor = System.Drawing.Color.Blue
        Me.lnamed.LineIdleColor = System.Drawing.Color.Gray
        Me.lnamed.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.lnamed.LineThickness = 6
        Me.lnamed.Location = New System.Drawing.Point(136, 349)
        Me.lnamed.Margin = New System.Windows.Forms.Padding(6)
        Me.lnamed.Name = "lnamed"
        Me.lnamed.Size = New System.Drawing.Size(329, 57)
        Me.lnamed.TabIndex = 94
        Me.lnamed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label10.Location = New System.Drawing.Point(104, 33)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(386, 44)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "MANTAP BOOKSTORE"
        '
        'lpasss
        '
        Me.lpasss.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lpasss.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpasss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lpasss.HintForeColor = System.Drawing.Color.Empty
        Me.lpasss.HintText = ""
        Me.lpasss.isPassword = True
        Me.lpasss.LineFocusedColor = System.Drawing.Color.Blue
        Me.lpasss.LineIdleColor = System.Drawing.Color.Gray
        Me.lpasss.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.lpasss.LineThickness = 6
        Me.lpasss.Location = New System.Drawing.Point(136, 467)
        Me.lpasss.Margin = New System.Windows.Forms.Padding(6)
        Me.lpasss.Name = "lpasss"
        Me.lpasss.Size = New System.Drawing.Size(329, 57)
        Me.lpasss.TabIndex = 100
        Me.lpasss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 32)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "SELAMAT DATANG"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 107)
        Me.Panel1.TabIndex = 114
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(221, 151)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(152, 156)
        Me.PictureBox3.TabIndex = 99
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.lock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(430, 477)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox2.TabIndex = 98
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.icon_user2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(430, 360)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.ActiveBorderThickness = 1
        Me.Button5.ActiveCornerRadius = 20
        Me.Button5.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Button5.ActiveForecolor = System.Drawing.Color.White
        Me.Button5.ActiveLineColor = System.Drawing.Color.Cyan
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.ButtonText = "LOGIN"
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.IdleBorderThickness = 1
        Me.Button5.IdleCornerRadius = 20
        Me.Button5.IdleFillColor = System.Drawing.Color.White
        Me.Button5.IdleForecolor = System.Drawing.Color.Black
        Me.Button5.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.Button5.Location = New System.Drawing.Point(221, 565)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(181, 63)
        Me.Button5.TabIndex = 93
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lnamed)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.lpasss)
        Me.Name = "login"
        Me.Text = "+"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lnamed As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lpasss As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
