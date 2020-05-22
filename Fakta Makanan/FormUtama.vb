Public Class FormUtama

    Private Sub tombolTampil_Click(sender As Object, e As EventArgs) Handles tombolTampil.Click
        'Menciptakan sebuah instansi dari FormNutrisi
        Dim frmNutrisi As New FormNutrisi

        'Menemukan tombol radio terseleksi
        If radPisang.Checked = True Then
            frmNutrisi.labelMakanan.Text = "1 Pisang"
            frmNutrisi.labelKalori.Text = "100"
            frmNutrisi.labelLemak.Text = "0.4"
            frmNutrisi.labelKarbo.Text = "27"
        ElseIf radPopcorn.Checked = True Then
            frmNutrisi.labelMakanan.Text = "1 Cangkir Popcorn"
            frmNutrisi.labelKalori.Text = "31"
            frmNutrisi.labelLemak.Text = "0.4"
            frmNutrisi.labelKarbo.Text = "6"
        ElseIf radMuffin.Checked = True Then
            frmNutrisi.labelMakanan.Text = "1 Kue Muffin Besar"
            frmNutrisi.labelKalori.Text = "385"
            frmNutrisi.labelLemak.Text = "9"
            frmNutrisi.labelKarbo.Text = "67"
        End If

        'Menampilkan FormNutrisi
        frmNutrisi.ShowDialog()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class
