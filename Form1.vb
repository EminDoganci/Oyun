Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, a, b As Integer
        x = (Rnd() * 353) + 379
        y = (Rnd() * 306) + 50

        Label1.Left = x
        Label1.Top = y

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        Label2.Left = a
        Label2.Top = b
        If ((a > 732) Or (a < 379)) Then
            Label2.Left = 379
            Label2.Top = 50
            MessageBox.Show("Lütfen soldan sağa 379-732 arasında bir sayı girin.")
        End If
        If ((b > 356) Or (b < 50)) Then
            Label2.Left = 379
            Label2.Top = 50
            MessageBox.Show("Lütfen yukarıdan aşağı 50-356 arasında bir sayı girin.")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Kırmızı karemiz mavi şeridin içerisinde rasgele; soldan sağa 353 birim, yukarıdan aşşağı 306 birim hareket etmektedir. Kare kutuyu yakalamak için; soldan sağa 379-732 arasında, yukarıdan aşağı 50-356 arasında bir sayı giriniz. Girdiğiniz sayılar ile karenin konumu denk gelirse oyunu kazanır ve sadece kareyi görürsünüz. İyi eğlenceler :)")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("18010208007 no'lu, YBS bölümü ikinciöğretim öğrencisi olan Emin DOĞANCI'nın vize çalışmasıdır.")
    End Sub
End Class
