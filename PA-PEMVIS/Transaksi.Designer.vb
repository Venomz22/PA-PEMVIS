<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport21 = New PA_PEMVIS.CrystalReport2()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AllowDrop = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1300, 86)
        Me.Panel3.TabIndex = 134
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 36.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(328, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(542, 67)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "DAFTAR TRANSAKSI"
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 751)
        Me.Panel2.TabIndex = 133
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.exit__1_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1217, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 49)
        Me.Button3.TabIndex = 119
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.btnTransaksi.Location = New System.Drawing.Point(53, 631)
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
        Me.btnBook.Location = New System.Drawing.Point(53, 492)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(96, 85)
        Me.btnBook.TabIndex = 90
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.BackgroundImage = Global.PA_PEMVIS.My.Resources.Resources.recruitment
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(53, 353)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(96, 96)
        Me.btnUser.TabIndex = 89
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(213, 86)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport21
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1300, 665)
        Me.CrystalReportViewer1.TabIndex = 135
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1513, 751)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Transaksi"
        Me.Text = "Form3"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As CrystalReport2
End Class
