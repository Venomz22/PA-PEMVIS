<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Metode))
        Me.cmbMetode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNext = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMetode
        '
        Me.cmbMetode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMetode.FormattingEnabled = True
        Me.cmbMetode.Items.AddRange(New Object() {"COD", "E-Wallet", "Transfer bank"})
        Me.cmbMetode.Location = New System.Drawing.Point(40, 120)
        Me.cmbMetode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMetode.Name = "cmbMetode"
        Me.cmbMetode.Size = New System.Drawing.Size(132, 26)
        Me.cmbMetode.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 17)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "METODE PEMBAYARAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.btnNext.ButtonText = "Next"
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnNext.IdleBorderThickness = 1
        Me.btnNext.IdleCornerRadius = 20
        Me.btnNext.IdleFillColor = System.Drawing.Color.White
        Me.btnNext.IdleForecolor = System.Drawing.Color.Black
        Me.btnNext.IdleLineColor = System.Drawing.Color.PaleGreen
        Me.btnNext.Location = New System.Drawing.Point(55, 214)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(89, 40)
        Me.btnNext.TabIndex = 193
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.book_shop
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(82, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 43)
        Me.PictureBox1.TabIndex = 194
        Me.PictureBox1.TabStop = False
        '
        'Metode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(212, 287)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMetode)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Metode"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMetode As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNext As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
End Class
