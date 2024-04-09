Public Class Form1
    Sub addtwonumbers(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim sum As Integer
        sum = num1 + num2
        TextBox3.Text = sum

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim Answer As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        Answer = num1 + num2
        TextBox3.Text = Answer
    End Sub
    Sub subtracttwonumbers(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim sum As Integer
        sum = num1 + num2
        TextBox3.Text = sum

    End Sub
    Private Sub Subtraction_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim Answer As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        Answer = num1 - num2
        TextBox3.Text = Answer
    End Sub

    Sub dividetwonumbers(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim sum As Integer
        sum = num1 + num2
        TextBox3.Text = sum

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim Answer As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        Answer = num1 / num2
        TextBox3.Text = Answer
    End Sub
    Sub multiplytwonumbers(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim sum As Integer
        sum = num1 + num2
        TextBox3.Text = sum

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim Answer As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        Answer = num1 * num2
        TextBox3.Text = Answer
    End Sub
End Class
