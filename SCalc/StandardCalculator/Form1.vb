Public Class Form1
    Dim calcs As Integer = 0
    Dim operat As String = ""

    Private Sub Clr_Click(sender As Object, e As EventArgs) Handles Clr.Click
        resultbox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resultbox.Text += "9"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resultbox.Text += "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        resultbox.Text += "7"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resultbox.Text += "6"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        resultbox.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        resultbox.Text += "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        resultbox.Text += "3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        resultbox.Text += "2"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        resultbox.Text += "1"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        resultbox.Text += "0"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        resultbox.Text += "."
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "+"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "-"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "*"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "/"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (operat = "+") Then
            resultbox.Text += calcs
        ElseIf (operat = "-") Then
            resultbox.Text -= calcs
        ElseIf (operat = "*") Then
            resultbox.Text *= calcs
        ElseIf (operat = "/") Then
            resultbox.Text /= calcs
        End If
        calcs = 0
        operat = ""
    End Sub

    Private Sub bksp_Click(sender As Object, e As EventArgs) Handles bksp.Click
        Dim ilenght As Integer = resultbox.TextLength - 1
        Dim result As String = resultbox.Text
        result = result.Substring(0, ilenght)
        resultbox.Text = result
    End Sub
End Class
