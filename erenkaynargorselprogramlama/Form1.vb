Public Class Form1
    Dim fnum As Double
    Dim snum As Double
    Dim sign As String

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        text1.Text = text1.Text & 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        text1.Text = text1.Text & 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        text1.Text = text1.Text & 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        text1.Text = text1.Text & 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        text1.Text = text1.Text & 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        text1.Text = text1.Text & 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        text1.Text = text1.Text & 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        text1.Text = text1.Text & 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        text1.Text = text1.Text & 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        text1.Text = text1.Text & 9
    End Sub

    Private Sub btnDOT_Click(sender As Object, e As EventArgs) Handles btnDOT.Click
        text1.Text = text1.Text & "."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        text1.Text = ""
    End Sub

    Private Sub btnPLUS_Click(sender As Object, e As EventArgs) Handles btnPLUS.Click
        fnum = text1.Text
        sign = "+"
        text1.Text = ""
    End Sub

    Private Sub btnSLASH_Click(sender As Object, e As EventArgs) Handles btnSLASH.Click
        fnum = text1.Text
        sign = "/"
        text1.Text = ""
    End Sub

    Private Sub btnMULTIPLY_Click(sender As Object, e As EventArgs) Handles btnMULTIPLY.Click
        fnum = text1.Text
        sign = "*"
        text1.Text = ""
    End Sub

    Private Sub btnMINUS_Click(sender As Object, e As EventArgs) Handles btnMINUS.Click
        fnum = text1.Text
        sign = "-"
        text1.Text = ""
    End Sub

    Private Sub btnEQUALS_Click(sender As Object, e As EventArgs) Handles btnEQUALS.Click
        snum = text1.Text
        If sign = "+" Then
            text1.Text = fnum + snum
        ElseIf sign = "/" Then
            text1.Text = fnum / snum
        ElseIf sign = "*" Then
            text1.Text = fnum * snum
        ElseIf sign = "-" Then
            text1.Text = fnum - snum
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If text1.Text.Length > 0 Then
            text1.Text = text1.Text.Remove(text1.Text.Length - 1, 1)
        End If

        If text1.Text = "" Then
            text1.Text = ""
        End If


    End Sub
End Class
