Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(TextBox2.Text & vbCrLf & ComboBox1.Text & vbCrLf & ComboBox2.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
