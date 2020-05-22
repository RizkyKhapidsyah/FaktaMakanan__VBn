<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNutrisi
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.labelMakanan = New System.Windows.Forms.Label()
        Me.labelKalori = New System.Windows.Forms.Label()
        Me.labelLemak = New System.Windows.Forms.Label()
        Me.labelKarbo = New System.Windows.Forms.Label()
        Me.tombolTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(44, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Makanan:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(63, 49)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(36, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Kalori:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(29, 86)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(70, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Gram Lemak:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(7, 125)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(92, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Gram Karbohidrat:"
        '
        'labelMakanan
        '
        Me.labelMakanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelMakanan.Location = New System.Drawing.Point(105, 10)
        Me.labelMakanan.Name = "labelMakanan"
        Me.labelMakanan.Size = New System.Drawing.Size(228, 23)
        Me.labelMakanan.TabIndex = 4
        '
        'labelKalori
        '
        Me.labelKalori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelKalori.Location = New System.Drawing.Point(105, 46)
        Me.labelKalori.Name = "labelKalori"
        Me.labelKalori.Size = New System.Drawing.Size(228, 23)
        Me.labelKalori.TabIndex = 5
        '
        'labelLemak
        '
        Me.labelLemak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelLemak.Location = New System.Drawing.Point(105, 83)
        Me.labelLemak.Name = "labelLemak"
        Me.labelLemak.Size = New System.Drawing.Size(228, 23)
        Me.labelLemak.TabIndex = 6
        '
        'labelKarbo
        '
        Me.labelKarbo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelKarbo.Location = New System.Drawing.Point(105, 122)
        Me.labelKarbo.Name = "labelKarbo"
        Me.labelKarbo.Size = New System.Drawing.Size(228, 23)
        Me.labelKarbo.TabIndex = 7
        '
        'tombolTutup
        '
        Me.tombolTutup.Location = New System.Drawing.Point(114, 170)
        Me.tombolTutup.Name = "tombolTutup"
        Me.tombolTutup.Size = New System.Drawing.Size(93, 34)
        Me.tombolTutup.TabIndex = 8
        Me.tombolTutup.Text = "Tutup"
        Me.tombolTutup.UseVisualStyleBackColor = True
        '
        'FormNutrisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 220)
        Me.Controls.Add(Me.tombolTutup)
        Me.Controls.Add(Me.labelKarbo)
        Me.Controls.Add(Me.labelLemak)
        Me.Controls.Add(Me.labelKalori)
        Me.Controls.Add(Me.labelMakanan)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FormNutrisi"
        Me.Text = "Informasi Nutrisi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents labelMakanan As System.Windows.Forms.Label
    Friend WithEvents labelKalori As System.Windows.Forms.Label
    Friend WithEvents labelLemak As System.Windows.Forms.Label
    Friend WithEvents labelKarbo As System.Windows.Forms.Label
    Friend WithEvents tombolTutup As System.Windows.Forms.Button
End Class
