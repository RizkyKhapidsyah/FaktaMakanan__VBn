<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMuffin = New System.Windows.Forms.RadioButton()
        Me.radPopcorn = New System.Windows.Forms.RadioButton()
        Me.radPisang = New System.Windows.Forms.RadioButton()
        Me.tombolTampil = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMuffin)
        Me.GroupBox1.Controls.Add(Me.radPopcorn)
        Me.GroupBox1.Controls.Add(Me.radPisang)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihlah Salah Satu Makanan"
        '
        'radMuffin
        '
        Me.radMuffin.AutoSize = True
        Me.radMuffin.Location = New System.Drawing.Point(12, 70)
        Me.radMuffin.Name = "radMuffin"
        Me.radMuffin.Size = New System.Drawing.Size(115, 17)
        Me.radMuffin.TabIndex = 2
        Me.radMuffin.TabStop = True
        Me.radMuffin.Text = "1 Kue Muffin Besar"
        Me.radMuffin.UseVisualStyleBackColor = True
        '
        'radPopcorn
        '
        Me.radPopcorn.AutoSize = True
        Me.radPopcorn.Location = New System.Drawing.Point(12, 47)
        Me.radPopcorn.Name = "radPopcorn"
        Me.radPopcorn.Size = New System.Drawing.Size(113, 17)
        Me.radPopcorn.TabIndex = 1
        Me.radPopcorn.TabStop = True
        Me.radPopcorn.Text = "1 Cangkir Popcorn"
        Me.radPopcorn.UseVisualStyleBackColor = True
        '
        'radPisang
        '
        Me.radPisang.AutoSize = True
        Me.radPisang.Location = New System.Drawing.Point(12, 24)
        Me.radPisang.Name = "radPisang"
        Me.radPisang.Size = New System.Drawing.Size(66, 17)
        Me.radPisang.TabIndex = 0
        Me.radPisang.TabStop = True
        Me.radPisang.Text = "1 Pisang"
        Me.radPisang.UseVisualStyleBackColor = True
        '
        'tombolTampil
        '
        Me.tombolTampil.Location = New System.Drawing.Point(13, 132)
        Me.tombolTampil.Name = "tombolTampil"
        Me.tombolTampil.Size = New System.Drawing.Size(125, 37)
        Me.tombolTampil.TabIndex = 1
        Me.tombolTampil.Text = "Tampilkan Fakta Makanan"
        Me.tombolTampil.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(158, 132)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(89, 37)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 182)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolTampil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormUtama"
        Me.Text = "Fakta Makanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radMuffin As System.Windows.Forms.RadioButton
    Friend WithEvents radPopcorn As System.Windows.Forms.RadioButton
    Friend WithEvents radPisang As System.Windows.Forms.RadioButton
    Friend WithEvents tombolTampil As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
