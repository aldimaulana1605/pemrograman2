Public Class kalkulator

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub kurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 - angka2
        TextBox3.Text = hasil

    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 + angka2
        TextBox3.Text = hasil

    End Sub

    Private Sub bagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bagi.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 / angka2
        TextBox3.Text = hasil

    End Sub

    Private Sub kali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kali.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 * angka2
        TextBox3.Text = hasil

    End Sub
End Class